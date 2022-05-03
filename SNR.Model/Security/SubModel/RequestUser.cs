using System.ComponentModel.DataAnnotations;

namespace SNR.Model;

public class RequestUser : IValidatableObject
{
    [Min(0)]
    public int IdUser { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Surname { get; set; }

    [Required]
    [StringLength(50)]
    public string UserName { get; set; }

    [Required]
    [StringLength(50)]
    public string Email { get; set; }

    [Required]
    [StringLength(250)]
    public string Password { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public bool IsActive { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        Validator.TryValidateProperty(IdUser, new ValidationContext(this, null, null) { MemberName = "IdUser" }, results);
        Validator.TryValidateProperty(Name, new ValidationContext(this, null, null) { MemberName = "Name" }, results);
        Validator.TryValidateProperty(Surname, new ValidationContext(this, null, null) { MemberName = "Surname" }, results);
        Validator.TryValidateProperty(UserName, new ValidationContext(this, null, null) { MemberName = "UserName" }, results);
        Validator.TryValidateProperty(Email, new ValidationContext(this, null, null) { MemberName = "Email" }, results);
        Validator.TryValidateProperty(Password, new ValidationContext(this, null, null) { MemberName = "Password" }, results);
        Validator.TryValidateProperty(LastLoginDate, new ValidationContext(this, null, null) { MemberName = "LastLoginDate" }, results);

        return results;
    }
}

public class RequestUser_Filter
{
    public int IdUser { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public bool IsActive { get; set; }
}

public class RequestUser_EditRole
{
    public int IdRole { get; set; }
    public int IdUser { get; set; }
    public bool IsActive { get; set; }
}