using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class CountMaxIdtable
{
    public int Id { get; set; }

    public string? TableName { get; set; }

    public string? MaxId { get; set; }

    public DateTime? DateTimeRecorded { get; set; }

    public string? BeforeAfter { get; set; }
}
