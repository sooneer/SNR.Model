using System.ComponentModel.DataAnnotations;

namespace SNR.Model;

public class RequestColumn : IValidatableObject
{
    [Min(0)]
    public int IdColumn { get; set; }

    [StringLength(50)]
    public string? TableName { get; set; }

    [StringLength(50)]
    public string? ModuleName { get; set; }

    [StringLength(50)]
    public string? PageName { get; set; }

    [Required]
    [StringLength(50)]
    public string ColumnName { get; set; }

    [StringLength(50)]
    public string? LocaleTR { get; set; }

    [StringLength(50)]
    public string? LocaleEN { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        Validator.TryValidateProperty(IdColumn, new ValidationContext(this, null, null) { MemberName = "IdColumn" }, results);
        Validator.TryValidateProperty(TableName, new ValidationContext(this, null, null) { MemberName = "TableName" }, results);
        Validator.TryValidateProperty(ModuleName, new ValidationContext(this, null, null) { MemberName = "ModuleName" }, results);
        Validator.TryValidateProperty(PageName, new ValidationContext(this, null, null) { MemberName = "PageName" }, results);
        Validator.TryValidateProperty(ColumnName, new ValidationContext(this, null, null) { MemberName = "ColumnName" }, results);
        Validator.TryValidateProperty(LocaleTR, new ValidationContext(this, null, null) { MemberName = "LocaleTR" }, results);
        Validator.TryValidateProperty(LocaleEN, new ValidationContext(this, null, null) { MemberName = "LocaleEN" }, results);

        return results;
    }
}

public class RequestColumn_Filter
{
    public int IdColumn { get; set; }

    public string? TableName { get; set; }

    public string? ModuleName { get; set; }

    public string? PageName { get; set; }

    public string? ColumnName { get; set; }

    public string? LocaleTR { get; set; }

    public string? LocaleEN { get; set; }
}