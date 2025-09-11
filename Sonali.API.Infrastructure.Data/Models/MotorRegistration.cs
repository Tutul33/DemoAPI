using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class MotorRegistration
{
    public int MotorId { get; set; }

    public int? NameId { get; set; }

    public string? AssName { get; set; }

    public string? RegistrationNo { get; set; }

    public int? Status { get; set; }

    public int? StockId { get; set; }

    public DateOnly? FitnessExpiryDate { get; set; }

    public DateOnly? RoadTaxExpiryDate { get; set; }

    public DateOnly? InsuranceExpiryDate { get; set; }
}
