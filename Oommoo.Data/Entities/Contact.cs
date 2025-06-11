using System;
using System.Collections.Generic;

namespace Oommoo.Data.Entities;

public partial class Contact
{
    public string Id { get; set; } = null!;

    public string EntityType { get; set; } = null!;

    public string EntityId { get; set; } = null!;

    public bool? Primary { get; set; }

    public string? Phone { get; set; }

    public string? Phone2 { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? Address2 { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? PostalCode { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public bool Private { get; set; }
}
