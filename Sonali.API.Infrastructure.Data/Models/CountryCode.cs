using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class CountryCode
{
    public int Id { get; set; }

    public string? CodeName { get; set; }

    public string? PhoneCode { get; set; }

    public string? CountryName { get; set; }

    public int? PhoneNoLength { get; set; }
}
