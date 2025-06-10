namespace Oommoo.Data.Entities;

public class File
{
    public string Id { get; set; } = null!;

    public string EntityType { get; set; } = null!;

    public string EntityId { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public string Filetype { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Path { get; set; } = null!;

    public double? Size { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public string? Type { get; set; }

    public bool? Private { get; set; }
}
