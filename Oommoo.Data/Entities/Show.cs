using System;
using System.Collections.Generic;

namespace Oommoo.Data.Entities;

public partial class Show
{
    public string Id { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? ProductionCompanyId { get; set; }

    public string? AgeRecommendation { get; set; }

    public string? Duration { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Type { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public string? DisplayImageUrl { get; set; }

    public bool Private { get; set; }

    public float AverageRating { get; set; }
}
