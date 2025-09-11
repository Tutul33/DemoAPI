using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class PorichoyDatum
{
    public int Id { get; set; }

    public string? FullNameEn { get; set; }

    public string? FathersNameEn { get; set; }

    public string? MothersNameEn { get; set; }

    public string? SpouseNameEn { get; set; }

    public string? PresentAddressEn { get; set; }

    public string? PermenantAddressEn { get; set; }

    public string? FullNameBn { get; set; }

    public string? FathersNameBn { get; set; }

    public string? MothersNameBn { get; set; }

    public string? SpouseNameBn { get; set; }

    public string? PresentAddressBn { get; set; }

    public string? PermanentAddressBn { get; set; }

    public string? Gender { get; set; }

    public string? Profession { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? NationalIdNumber { get; set; }

    public string? OldNationalIdNumber { get; set; }

    public string? PhotoUrl { get; set; }

    public DateTime? CreateDate { get; set; }
}
