using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Infrastructure.Data.Models;

namespace Sonali.API.Infrastructure.Data.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccChart> AccCharts { get; set; }

    public virtual DbSet<AccDemo> AccDemos { get; set; }

    public virtual DbSet<AccDemoItem> AccDemoItems { get; set; }

    public virtual DbSet<AccDemoItemFileAttachment> AccDemoItemFileAttachments { get; set; }

    public virtual DbSet<AccUserRole> AccUserRoles { get; set; }

    public virtual DbSet<AccUserRoleMap> AccUserRoleMaps { get; set; }

    public virtual DbSet<AccVoucherReferral> AccVoucherReferrals { get; set; }

    public virtual DbSet<Accgl2025> Accgl2025s { get; set; }

    public virtual DbSet<AppUser> AppUsers { get; set; }

    public virtual DbSet<ChatFile> ChatFiles { get; set; }

    public virtual DbSet<ChatMessage> ChatMessages { get; set; }

    public virtual DbSet<PayDepartment> PayDepartments { get; set; }

    public virtual DbSet<PayDesignation> PayDesignations { get; set; }

    public virtual DbSet<PayEmployeeJobDetail> PayEmployeeJobDetails { get; set; }

    public virtual DbSet<PayEmployeesBasicInfo> PayEmployeesBasicInfoes { get; set; }

    public virtual DbSet<PayRole> PayRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=MsSqlConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccChart>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AccChart");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.AccLevel).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ActCode).HasColumnType("numeric(30, 0)");
            entity.Property(e => e.ActName).HasMaxLength(500);
            entity.Property(e => e.Brokerage)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Cl).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Ex).HasMaxLength(50);
            entity.Property(e => e.Inserted)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsGroup)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<AccDemo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Demo");

            entity.ToTable("AccDemo");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccDemoItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DemoItem");

            entity.ToTable("AccDemoItem");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccDemoItemFileAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DemoItemFileAttachment");

            entity.ToTable("AccDemoItemFileAttachment");

            entity.Property(e => e.FileName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccUserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserRole");

            entity.ToTable("AccUserRole");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccUserRoleMap>(entity =>
        {
            entity.ToTable("AccUserRoleMap");
        });

        modelBuilder.Entity<AccVoucherReferral>(entity =>
        {
            entity.ToTable("AccVoucherReferral");

            entity.Property(e => e.Comments)
                .HasMaxLength(1500)
                .IsUnicode(false);
            entity.Property(e => e.RefBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RefTo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RefType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReferDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Accgl2025>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Accgl2025");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("id");
            entity.Property(e => e.AccStatement).HasMaxLength(400);
            entity.Property(e => e.ActCode).HasMaxLength(50);
            entity.Property(e => e.ActName).HasMaxLength(300);
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Camount)
                .HasColumnType("money")
                .HasColumnName("CAmount");
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckedDate).HasColumnType("datetime");
            entity.Property(e => e.ChkDt).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Damount)
                .HasColumnType("money")
                .HasColumnName("DAmount");
            entity.Property(e => e.DelDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DelUser).HasMaxLength(100);
            entity.Property(e => e.Descrp).IsUnicode(false);
            entity.Property(e => e.FromActCode).HasMaxLength(50);
            entity.Property(e => e.MainCode).HasMaxLength(50);
            entity.Property(e => e.ModOfPay).HasMaxLength(50);
            entity.Property(e => e.OpeningBalance).HasMaxLength(10);
            entity.Property(e => e.ShopId).HasMaxLength(50);
            entity.Property(e => e.ToActCode).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<AppUser>(entity =>
        {
            entity.ToTable("AppUser");

            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateCardBy).IsUnicode(false);
            entity.Property(e => e.UpdateCardDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ChatFile>(entity =>
        {
            entity.ToTable("ChatFile");

            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.FileType).HasMaxLength(10);
            entity.Property(e => e.FileUrl).HasMaxLength(100);
            entity.Property(e => e.SentDate).HasColumnType("datetime");

            entity.HasOne(d => d.ChatMessage).WithMany(p => p.ChatFiles)
                .HasForeignKey(d => d.ChatMessageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChatFile_ChatMessage");
        });

        modelBuilder.Entity<ChatMessage>(entity =>
        {
            entity.ToTable("ChatMessage");

            entity.Property(e => e.Receiver).HasMaxLength(100);
            entity.Property(e => e.Sender).HasMaxLength(100);
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.Text).HasColumnType("text");
        });

        modelBuilder.Entity<PayDepartment>(entity =>
        {
            entity.HasKey(e => e.DeptId);

            entity.HasIndex(e => e.DeptName, "Unique_PayDepartments").IsUnique();

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayDesignation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasFillFactor(90);

            entity.HasIndex(e => new { e.DeptId, e.DesignationName }, "Unique_PayDesignations")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DesignationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DesignationShortFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayEmployeeJobDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasFillFactor(90);

            entity.HasIndex(e => new { e.EmpId, e.DesignationId, e.RoleId }, "Unique_PayEmployeeJobDetails")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.UserName, "Unique_PayEmployeeJobDetails_Username")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.BankAcNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankBranch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EmpIdNo)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.EmpJobStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Emp_Job_Status");
            entity.Property(e => e.EmpJobType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Emp_Job_Type");
            entity.Property(e => e.EmpType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InchargeId).HasColumnName("InchargeID");
            entity.Property(e => e.JobEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Job_End_Date");
            entity.Property(e => e.JobStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Job_Start_Date");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RoomNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Room_No");
            entity.Property(e => e.Tinno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TINNo");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayEmployeesBasicInfo>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasFillFactor(90);

            entity.HasIndex(e => new { e.EmpName, e.Mobile1 }, "UniqueKey_PayEmployeesBasicInfoes")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Age)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Education).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FamilyContactNum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Gender).IsUnicode(false);
            entity.Property(e => e.ImageName)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.Marital)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Mobile2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MotherName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NationalId)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nidimage)
                .HasMaxLength(100)
                .HasColumnName("NIDImage");
            entity.Property(e => e.OtizmStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtizmType)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAdd)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RefContactNum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SignatureImage)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Subject).HasMaxLength(250);
            entity.Property(e => e.SurName).IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasFillFactor(90);

            entity.HasIndex(e => e.RoleName, "Unique_PayRoles").IsUnique();

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RoleName)
                .HasMaxLength(550)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Usertype)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
