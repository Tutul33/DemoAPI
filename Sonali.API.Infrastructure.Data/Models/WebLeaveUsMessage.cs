using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class WebLeaveUsMessage
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? PhoneNo { get; set; }

    public string? Email { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public DateTime? CreateDate { get; set; }
}
