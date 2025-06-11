using System;
using System.Collections.Generic;

namespace Oommoo.Data.Entities;

public partial class Watchlist
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public string? DisplayImageUrl { get; set; }

    public bool Private { get; set; }
}
