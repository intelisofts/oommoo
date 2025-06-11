using System;
using System.Collections.Generic;

namespace Oommoo.Data.Entities;

public partial class UserPermission
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? EntityId { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;
}
