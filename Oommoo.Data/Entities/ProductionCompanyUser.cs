namespace Oommoo.Data.Entities;

public class ProductionCompanyUser
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string ProductionCompanyId { get; set; } = null!;

    public string? Role { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public bool Private { get; set; }
}
