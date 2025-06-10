namespace Oommoo.Data.Entities;

public class Rating
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string ShowId { get; set; } = null!;

    public string VenueId { get; set; } = null!;

    public string? EventId { get; set; }

    public string? ReviewId { get; set; }

    public string Type { get; set; } = null!;

    public int Value { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public bool? Held { get; set; }

    public string? ShowUserId { get; set; }

    public string? VenueShowId { get; set; }

    public bool Private { get; set; }
}
