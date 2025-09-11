using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PayEmployeeJobDetails20012024
{
    public int UserId { get; set; }

    public int? EmpId { get; set; }

    public int? DesignationId { get; set; }

    public int? RoleId { get; set; }

    public string? EmpJobStatus { get; set; }

    public string? EmpJobType { get; set; }

    public DateTime? JobStartDate { get; set; }

    public DateTime? JobEndDate { get; set; }

    public double? EmpSalary { get; set; }

    public string? RoomNo { get; set; }

    public int? BranchCode { get; set; }

    public string? EmpIdNo { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Tinno { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public string? BankAcNo { get; set; }

    public int? InchargeId { get; set; }

    public int? AgentId { get; set; }

    public string? EmpType { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? ImgStatus { get; set; }

    public int? NidStatus { get; set; }

    public int? SignStatus { get; set; }

    public int? BankStatus { get; set; }

    public int? IdCardStatus { get; set; }

    public string? Comments { get; set; }

    public int? Grade { get; set; }
}
