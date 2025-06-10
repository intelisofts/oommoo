namespace Oommoo.Data.Entities;

public class Venue
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
}
