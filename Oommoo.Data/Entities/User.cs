namespace Oommoo.Data.Entities;

public class User
{
    public string Id { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? FullName { get; set; }

    public string? Type { get; set; }

    public string? Subtype { get; set; }

    public DateTime Dob { get; set; }

    public string? Gender { get; set; }

    public int Age { get; set; }

    public string Password { get; set; } = null!;

    public string? SystemId { get; set; }

    public string? Notes { get; set; }

    public string? Role { get; set; }

    public bool? LoggedIn { get; set; }

    public bool? Verified { get; set; }

    public string? VerificationCode { get; set; }

    public string? VerificationType { get; set; }

    public string? ResetCode { get; set; }

    public string Email { get; set; } = null!;

    public DateTime CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? UpdatedBy { get; set; }

    public string IsDeleted { get; set; } = null!;

    public string? DisplayImageUrl { get; set; }

    public bool Private { get; set; }
}
