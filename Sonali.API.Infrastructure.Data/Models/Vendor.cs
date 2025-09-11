using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class Vendor
{
    public int Id { get; set; }

    public string? VendorName { get; set; }

    public string? Adderss { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? Dateline { get; set; }

    public string? BinNo { get; set; }

    public string? TinNo { get; set; }

    public int? ProcCategoryId { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
