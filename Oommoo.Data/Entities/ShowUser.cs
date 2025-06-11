using System;
using System.Collections.Generic;

namespace Oommoo.Data.Entities;

public partial class ShowUser
{
    public string Id { get; set; } = null!;

    public string ShowId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string AttendanceType { get; set; } = null!;

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public string VenueShowId { get; set; } = null!;
}
