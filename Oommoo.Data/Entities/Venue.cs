using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oommoo.Data.Entities;

public partial class Venue
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Type { get; set; }

    public string? Accessibility { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public string? DisplayImageUrl { get; set; }

    public bool Private { get; set; }

    public string? Capacity { get; set; }

    public string? VenueAddress  { get; set; }

    public string? Location { get; set; }

    public string? CurrentManagement { get; set; }

    public string? PhoneNumber { get; set; }

    public string? OpenedOn { get; set; }

    public string? Stagedoor { get; set; }

    public string? ShowScore { get; set; }

}
