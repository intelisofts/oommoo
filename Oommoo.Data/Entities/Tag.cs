namespace Oommoo.Data.Entities;

public class Tag
{
    public string Id { get; set; } = null!;

    public string EntityType { get; set; } = null!;

    public string EntityId { get; set; } = null!;

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public string Tag1 { get; set; } = null!;

    public bool Private { get; set; }
}
