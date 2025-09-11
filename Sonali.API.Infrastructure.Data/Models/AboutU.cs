using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class AboutU
{
    public int Id { get; set; }

    public string? AboutTitle { get; set; }

    public string? AboutTitleBangla { get; set; }

    public string? AboutDesc { get; set; }

    public string? AboutDescBangla { get; set; }

    public string? AboutImg { get; set; }
}
