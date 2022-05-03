using System.ComponentModel.DataAnnotations;

namespace SNR.Model;

public class RequestPermission : IValidatableObject
{
    [Min(0)]
    public int IdPermission { get; set; }

    [Required]
    [StringLength(50)]
    public string PermissionName { get; set; }

    [StringLength(50)]
    public string? PermissionNameEN { get; set; }

    [StringLength(50)]
    public string? FullPath { get; set; }

    [StringLength(500)]
    public string? PermissionDesc { get; set; }

    [StringLength(500)]
    public string? PermissionDescEN { get; set; }

    public bool IsGeneral { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        Validator.TryValidateProperty(IdPermission, new ValidationContext(this, null, null) { MemberName = "IdPermission" }, results);
        Validator.TryValidateProperty(PermissionName, new ValidationContext(this, null, null) { MemberName = "PermissionName" }, results);
        Validator.TryValidateProperty(PermissionNameEN, new ValidationContext(this, null, null) { MemberName = "PermissionNameEN" }, results);
        Validator.TryValidateProperty(FullPath, new ValidationContext(this, null, null) { MemberName = "FullPath" }, results);
        Validator.TryValidateProperty(PermissionDesc, new ValidationContext(this, null, null) { MemberName = "PermissionDesc" }, results);
        Validator.TryValidateProperty(PermissionDescEN, new ValidationContext(this, null, null) { MemberName = "PermissionDescEN" }, results);

        return results;
    }
}

public class RequestPermission_Filter
{
    public int IdPermission { get; set; }

    public string? PermissionName { get; set; }

    public string? PermissionNameEN { get; set; }

    public string? FullPath { get; set; }

    public string? PermissionDesc { get; set; }

    public string? PermissionDescEN { get; set; }

    public bool IsGeneral { get; set; }

}
