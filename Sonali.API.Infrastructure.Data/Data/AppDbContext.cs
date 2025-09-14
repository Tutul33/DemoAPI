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

    public virtual DbSet<AccountGroup> AccountGroups { get; set; }

    public virtual DbSet<AccountHead> AccountHeads { get; set; }

    public virtual DbSet<AppUser> AppUsers { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<ChatFile> ChatFiles { get; set; }

    public virtual DbSet<ChatMessage> ChatMessages { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<FinancialYear> FinancialYears { get; set; }

    public virtual DbSet<LockEntry> LockEntries { get; set; }

    public virtual DbSet<PayDepartment> PayDepartments { get; set; }

    public virtual DbSet<PayDesignation> PayDesignations { get; set; }

    public virtual DbSet<PayEmployeeJobDetail> PayEmployeeJobDetails { get; set; }

    public virtual DbSet<PayEmployeesBasicInfo> PayEmployeesBasicInfoes { get; set; }

    public virtual DbSet<PayRole> PayRoles { get; set; }

    public virtual DbSet<SubLedger> SubLedgers { get; set; }

    public virtual DbSet<VoucherAudit> VoucherAudits { get; set; }

    public virtual DbSet<VoucherEntry> VoucherEntries { get; set; }

    public virtual DbSet<VoucherHeader> VoucherHeaders { get; set; }

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

        modelBuilder.Entity<AccountGroup>(entity =>
        {
            entity.HasKey(e => e.AccountGroupId).HasName("PK__AccountG__49A6ED3B495C0420");

            entity.ToTable("AccountGroup");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Type).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.AccountGroups)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AccountGr__Compa__4316F928");

            entity.HasOne(d => d.ParentGroup).WithMany(p => p.InverseParentGroup)
                .HasForeignKey(d => d.ParentGroupId)
                .HasConstraintName("FK__AccountGr__Paren__440B1D61");
        });

        modelBuilder.Entity<AccountHead>(entity =>
        {
            entity.HasKey(e => e.AccountHeadId).HasName("PK__AccountH__0F830A99ACE7C29F");

            entity.ToTable("AccountHead");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.AccountGroup).WithMany(p => p.AccountHeads)
                .HasForeignKey(d => d.AccountGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AccountHe__Accou__48CFD27E");

            entity.HasOne(d => d.Branch).WithMany(p => p.AccountHeads)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__AccountHe__Branc__47DBAE45");

            entity.HasOne(d => d.Company).WithMany(p => p.AccountHeads)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AccountHe__Compa__46E78A0C");
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

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("PK__Branch__A1682FC5850CE61C");

            entity.ToTable("Branch");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.Company).WithMany(p => p.Branches)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Branch__CompanyI__3A81B327");
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
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__Company__2D971CACD5EC4FD9");

            entity.ToTable("Company");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<FinancialYear>(entity =>
        {
            entity.HasKey(e => e.FinancialYearId).HasName("PK__Financia__6ECE4C91A953A74D");

            entity.ToTable("FinancialYear");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Company).WithMany(p => p.FinancialYears)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Financial__Compa__3D5E1FD2");
        });

        modelBuilder.Entity<LockEntry>(entity =>
        {
            entity.HasKey(e => e.LockEntryId).HasName("PK__LockEntr__3C6AF80096C88E6B");

            entity.Property(e => e.LockEnd).HasColumnType("datetime");
            entity.Property(e => e.LockStart).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(255);
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

        modelBuilder.Entity<SubLedger>(entity =>
        {
            entity.HasKey(e => e.SubLedgerId).HasName("PK__SubLedge__9749B1E6D60D001C");

            entity.ToTable("SubLedger");

            entity.Property(e => e.Contact).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ReferenceId).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.SubLedgers)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SubLedger__Compa__4D94879B");
        });

        modelBuilder.Entity<VoucherAudit>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__VoucherA__A17F2398FA3F640F");

            entity.ToTable("VoucherAudit");

            entity.Property(e => e.Action).HasMaxLength(100);
            entity.Property(e => e.ActionAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.ActionBy).HasMaxLength(200);
        });

        modelBuilder.Entity<VoucherEntry>(entity =>
        {
            entity.HasKey(e => e.EntryId).HasName("PK__VoucherE__F57BD2F7A27EE934");

            entity.ToTable("VoucherEntry");

            entity.HasIndex(e => e.AccountHeadId, "IDX_VoucherEntry_AccountHead");

            entity.HasIndex(e => e.SubLedgerId, "IDX_VoucherEntry_SubLedger");

            entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.LineOrder).HasDefaultValue(1);
            entity.Property(e => e.SignedAmount)
                .HasComputedColumnSql("([Debit]-[Credit])", true)
                .HasColumnType("decimal(19, 2)");

            entity.HasOne(d => d.AccountHead).WithMany(p => p.VoucherEntries)
                .HasForeignKey(d => d.AccountHeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VoucherEn__Accou__5812160E");

            entity.HasOne(d => d.SubLedger).WithMany(p => p.VoucherEntries)
                .HasForeignKey(d => d.SubLedgerId)
                .HasConstraintName("FK__VoucherEn__SubLe__59063A47");

            entity.HasOne(d => d.Voucher).WithMany(p => p.VoucherEntries)
                .HasForeignKey(d => d.VoucherId)
                .HasConstraintName("FK__VoucherEn__Vouch__571DF1D5");
        });

        modelBuilder.Entity<VoucherHeader>(entity =>
        {
            entity.HasKey(e => e.VoucherId).HasName("PK__VoucherH__3AEE7921FAEFAFFF");

            entity.ToTable("VoucherHeader");

            entity.HasIndex(e => new { e.CompanyId, e.Date }, "IDX_VoucherHeader_CompanyDate");

            entity.HasIndex(e => new { e.CompanyId, e.FinancialYearId, e.VoucherNo }, "UX_Voucher_Company_FY_No").IsUnique();

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(200);
            entity.Property(e => e.Narration).HasMaxLength(1000);
            entity.Property(e => e.Reference).HasMaxLength(200);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
            entity.Property(e => e.VoucherType).HasMaxLength(50);

            entity.HasOne(d => d.Branch).WithMany(p => p.VoucherHeaders)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__VoucherHe__Branc__5165187F");

            entity.HasOne(d => d.Company).WithMany(p => p.VoucherHeaders)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VoucherHe__Compa__5070F446");

            entity.HasOne(d => d.FinancialYear).WithMany(p => p.VoucherHeaders)
                .HasForeignKey(d => d.FinancialYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VoucherHe__Finan__52593CB8");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
