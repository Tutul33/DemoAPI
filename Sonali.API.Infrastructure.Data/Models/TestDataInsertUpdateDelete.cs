using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class TestDataInsertUpdateDelete
{
    public int Id { get; set; }

    public string? Empname { get; set; }

    public string? Empaddress { get; set; }

    public string? Email { get; set; }

    public DateOnly? Hiredate { get; set; }

    public DateTime? Updatedon { get; set; }
}
