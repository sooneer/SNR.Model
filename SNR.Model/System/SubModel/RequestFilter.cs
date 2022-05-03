using System.ComponentModel.DataAnnotations;

namespace SNR.Model;

public class RequestFilter : IValidatableObject
{
    [Min(0)]
    public int IdFilter { get; set; }

    [Required]
    [StringLength(150)]
    public string FilterName { get; set; }

    public bool IsSubmit { get; set; }

    public bool IsModify { get; set; }

    public bool IsDelete { get; set; }

    public bool IsGetEntry { get; set; }

    [StringLength(500)]
    public string? RunIf { get; set; }

    [Min(0)]
    public int FilterOrder { get; set; }

    [Min(0)]
    public bool IsActive { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        Validator.TryValidateProperty(IdFilter, new ValidationContext(this, null, null) { MemberName = "IdFilter" }, results);
        Validator.TryValidateProperty(FilterName, new ValidationContext(this, null, null) { MemberName = "FilterName" }, results);
        Validator.TryValidateProperty(RunIf, new ValidationContext(this, null, null) { MemberName = "RunIf" }, results);
        Validator.TryValidateProperty(FilterOrder, new ValidationContext(this, null, null) { MemberName = "FilterOrder" }, results);
        Validator.TryValidateProperty(IsActive, new ValidationContext(this, null, null) { MemberName = "IsActive" }, results);

        return results;
    }
}

public class RequestFilter_Filter
{
    public int IdFilter { get; set; }

    public string? FilterName { get; set; }

    public bool IsSubmit { get; set; }

    public bool IsModify { get; set; }

    public bool IsDelete { get; set; }

    public bool IsGetEntry { get; set; }

    public string? RunIf { get; set; }

    public int FilterOrder { get; set; }

    public bool IsActive { get; set; }

}
