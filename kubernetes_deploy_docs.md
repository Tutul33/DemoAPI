# Kubernetes Deployment Documentation

This document contains an overview of the Kubernetes manifests used for deploying the SQL Server, Backend API, Redis, Frontend, Ingress, and Namespace creation for the project.

---

## 1. Namespace

**File:** `kubernetes-namespaces.yaml`

**Purpose:** Create a dedicated namespace for the deployment to isolate resources.

```yaml
apiVersion: v1
kind: Namespace
metadata:
  name: dep-app
  labels:
    name: dep-app
```

**Apply:**

```bash
kubectl apply -f kubernetes-namespaces.yaml
```

---

## 2. Backend API Deployment

**File:** `kubernetes-backend-deployment.yaml`

**Purpose:** Deploy the .NET backend API to the cluster.

```yaml
apiVersion: apps/v1
kind: Deployment
metadata:
  name: backend
  namespace: dep-app
spec:
  replicas: 1
  selector:
    matchLabels:
      app: backend
  template:
    metadata:
      labels:
        app: backend
    spec:
      containers:
      - name: backend
        image: tutulchakma/sonali-api:latest
        ports:
          - containerPort: 9090
        env:
          - name: ASPNETCORE_URLS
            value: "http://+:9090"
        resources:
          requests:
            memory: "256Mi"
            cpu: "250m"
          limits:
            memory: "512Mi"
            cpu: "500m"
---
apiVersion: v1
kind: Service
metadata:
  name: backend
  namespace: dep-app
spec:
  type: NodePort
  selector:
    app: backend
  ports:
    - protocol: TCP
      port: 9090
      targetPort: 9090
      nodePort: 30909
```

**Apply:**

```bash
kubectl apply -f kubernetes-backend-deployment.yaml
```

---

## 3. Redis Deployment

**File:** `kubernetes-redis.yaml`

**Purpose:** Deploy Redis for caching and pub/sub functionality.

```yaml
apiVersion: apps/v1
kind: Deployment
metadata:
  name: redis
  namespace: dep-app
spec:
  replicas: 1
  selector:
    matchLabels:
      app: redis
  template:
    metadata:
      labels:
        app: redis
    spec:
      containers:
      - name: redis
        image: redis:7.0
        ports:
        - containerPort: 6379
        resources:
          requests:
            cpu: "100m"
            memory: "128Mi"
          limits:
            cpu: "250m"
            memory: "256Mi"
        volumeMounts:
        - name: redis-data
          mountPath: /data
        command: ["redis-server", "--appendonly", "yes"]
        livenessProbe:
          tcpSocket:
            port: 6379
          initialDelaySeconds: 10
          periodSeconds: 10
        readinessProbe:
          tcpSocket:
            port: 6379
          initialDelaySeconds: 5
          periodSeconds: 5
      volumes:
      - name: redis-data
        emptyDir: {}
---
apiVersion: v1
kind: Service
metadata:
  name: redis
  namespace: dep-app
spec:
  selector:
    app: redis
  ports:
    - port: 6379
      targetPort: 6379
  type: ClusterIP
```

**Apply:**

```bash
kubectl apply -f kubernetes-redis.yaml
```

---

## 4. SQL Server Deployment

**File:** `kubernetes-SQL-server-deployment.yaml`

**Purpose:** Deploy SQL Server as a pod with persistent storage.

```yaml
apiVersion: v1
kind: PersistentVolumeClaim
metadata:
  name: mssql-pvc
  namespace: dep-app
spec:
  accessModes:
    - ReadWriteOnce
  resources:
    requests:
      storage: 5Gi
---
apiVersion: apps/v1
kind: Deployment
metadata:
  name: mssql
  namespace: dep-app
spec:
  replicas: 1
  selector:
    matchLabels:
      app: mssql
  template:
    metadata:
      labels:
        app: mssql
    spec:
      containers:
        - name: mssql
          image: mcr.microsoft.com/mssql/server:2022-latest
          ports:
            - containerPort: 1433
          env:
            - name: ACCEPT_EULA
              value: "Y"
            - name: MSSQL_SA_PASSWORD
              value: "Your_strong_password123"
          volumeMounts:
            - name: mssql-data
              mountPath: /var/opt/mssql
          resources:
            requests:
              cpu: "500m"
              memory: "1Gi"
            limits:
              cpu: "1"
              memory: "2Gi"
      volumes:
        - name: mssql-data
          persistentVolumeClaim:
            claimName: mssql-pvc
---
apiVersion: v1
kind: Service
metadata:
  name: mssql
  namespace: dep-app
spec:
  type: NodePort
  selector:
    app: mssql
  ports:
    - protocol: TCP
      port: 1433
      targetPort: 1433
      nodePort: 31433
```

**Apply:**

```bash
kubectl apply -f kubernetes-SQL-server-deployment.yaml
```

---

## 5. Frontend Deployment

**File:** `kubernetes-frontend-deployment.yaml`

**Purpose:** Deploy the Angular frontend application.

```yaml
apiVersion: apps/v1
kind: Deployment
metadata:
  name: frontend
  namespace: dep-app
spec:
  replicas: 1
  selector:
    matchLabels:
      app: frontend
  template:
    metadata:
      labels:
        app: frontend
    spec:
      containers:
      - name: frontend
        image: tutulchakma/sonalierpext-sol-app:latest
        ports:
          - containerPort: 80
        resources:
          requests:
            memory: "128Mi"
            cpu: "250m"
          limits:
            memory: "256Mi"
            cpu: "500m"
---
apiVersion: v1
kind: Service
metadata:
  name: frontend
  namespace: dep-app
spec:
  type: NodePort
  selector:
    app: frontend
  ports:
    - protocol: TCP
      port: 80
      targetPort: 80
      nodePort: 31919
```

**Apply:**

```bash
kubectl apply -f kubernetes-frontend-deployment.yaml
```

---

## 6. Ingress

**File:** `kubernetes-ingress.yaml`

**Purpose:** Expose frontend and backend services externally using Ingress.

```yaml
apiVersion: networking.k8s.io/v1
kind: Ingress
metadata:
  name: sonali-ingress
  namespace: dep-app
  annotations:
    nginx.ingress.kubernetes.io/rewrite-target: /
spec:
  ingressClassName: nginx
  rules:
    - host: frontend.local
      http:
        paths:
          - path: /
            pathType: Prefix
            backend:
              service:
                name: frontend
                port:
                  number: 80
    - host: backend.local
      http:
        paths:
          - path: /
            pathType: Prefix
            backend:
              service:
                name: backend
                port:
                  number: 9090
```

**Apply:**

```bash
kubectl apply -f kubernetes-ingress.yaml
```

---

### ✅ Summary

1. **Namespace:** isolates resources (`dep-app`).
2. **Backend API:** .NET service deployment with NodePort.
3. **Redis:** caching service with liveness and readiness probes.
4. **SQL Server:** database deployment with PVC and NodePort.
5. **Frontend:** Angular SPA with NodePort.
6. **Ingress:** exposes frontend and backend externally.

**Next Steps:**

- Verify all pods, services, and ingress:

```bash
kubectl get all -n dep-app
```

- Update `/etc/hosts` or DNS to map `frontend.local` and `backend.local`.
- Ensure persistent storage is configured for production environments.

---


