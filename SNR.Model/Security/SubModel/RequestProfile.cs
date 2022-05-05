using System.ComponentModel.DataAnnotations;

namespace SNR.Model;

public class RequestProfile_Save : IValidatableObject
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

        return results;
    }
}