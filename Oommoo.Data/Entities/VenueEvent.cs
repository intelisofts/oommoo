using System;
using System.Collections.Generic;

namespace Oommoo.Data.Entities;

public partial class VenueEvent
{
    public string Id { get; set; } = null!;

    public string VenueId { get; set; } = null!;

    public string EventId { get; set; } = null!;

    public string? ShowId { get; set; }

    public bool? Active { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public string? Type { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
