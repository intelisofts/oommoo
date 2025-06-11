using System;
using System.Collections.Generic;

namespace Oommoo.Data.Entities;

public partial class WatchlistItem
{
    public string Id { get; set; } = null!;

    public string WatchlistId { get; set; } = null!;

    public string ShowId { get; set; } = null!;

    public int Position { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public bool Private { get; set; }
}
