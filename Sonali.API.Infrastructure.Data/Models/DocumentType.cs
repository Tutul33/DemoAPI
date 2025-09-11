using System;
using System.Collections.Generic;

namespace Sonali.API.Infrastructure.Data.Models;

public partial class DocumentType
{
    public int DocumentTypeId { get; set; }

    public string DocumentTypeName { get; set; } = null!;

    public string? DocumentTypeNameBng { get; set; }

    public DateTime CreateDate { get; set; }
}
