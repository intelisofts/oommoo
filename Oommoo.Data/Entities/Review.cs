using System;
using System.Collections.Generic;

namespace Oommoo.Data.Entities;

public partial class Review
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string ShowId { get; set; } = null!;

    public string? VenueId { get; set; }

    public string? EventId { get; set; }

    public string? Type { get; set; }

    public string Review1 { get; set; } = null!;

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public string? DisplayImageUrl { get; set; }

    public bool? Held { get; set; }

    public string? ShowUserId { get; set; }

    public string? VenueShowId { get; set; }

    public bool Private { get; set; }
}
