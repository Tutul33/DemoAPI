using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class QuSetup
{
    public int QuId { get; set; }

    public int OrEntryId { get; set; }

    public int FprId { get; set; }

    public string TrnId { get; set; } = null!;

    public int? BankId { get; set; }

    public DateOnly? OrEntryDate { get; set; }

    public double? TotalPremAmt { get; set; }

    public double? DepositAmt { get; set; }

    public int? AgentId { get; set; }

    public int? NthYr { get; set; }

    public double? Bp { get; set; }

    public double? Sp { get; set; }

    public int? TotIns { get; set; }

    public int? CurrentInsNo { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? NextPremDueDt { get; set; }

    public int? ProductId { get; set; }

    public int? TotInsPaid { get; set; }

    public int? TotInsDue { get; set; }

    public int OrProcess { get; set; }

    public int MatProcess { get; set; }

    public int SmsProcess { get; set; }

    public int AgentProcessBusComPf { get; set; }

    public int LapsProcess { get; set; }

    public int PolicyProcess { get; set; }

    public int AccProcessOr { get; set; }

    public int AccProcessPf { get; set; }

    public int FullProcess { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public double? PTotalPolicyAmount { get; set; }

    public double? PYsapa { get; set; }

    public int AgentProcessCtr { get; set; }
}
