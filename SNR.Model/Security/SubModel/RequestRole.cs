using System.ComponentModel.DataAnnotations;

namespace SNR.Model;

public class RequestRole : IValidatableObject
{
    [Min(0)]
    public int IdRole { get; set; }

    [Required]
    [StringLength(50)]
    public string RoleName { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        Validator.TryValidateProperty(IdRole, new ValidationContext(this, null, null) { MemberName = "IdRole" }, results);
        Validator.TryValidateProperty(RoleName, new ValidationContext(this, null, null) { MemberName = "RoleName" }, results);

        return results;
    }
}

public class RequestRole_Filter
{
    public int IdRole { get; set; }

    public string? RoleName { get; set; }
}

public class RequestRole_EditMenu
{
    public int IdMenu { get; set; }
    public int IdRole { get; set; }
    public bool IsActive { get; set; }
}

public class RequestRole_EditPermission
{
    public int IdMenu { get; set; }
    public int IdRole { get; set; }
    public int IdPermission { get; set; }
    public bool IsActive { get; set; }
}