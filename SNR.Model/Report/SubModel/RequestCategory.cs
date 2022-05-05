using System.ComponentModel.DataAnnotations;

namespace SNR.Model;

public class RequestCategory : IValidatableObject
{
    [Min(0)]
    public int IdCategory { get; set; }

    [Required]
    [StringLength(50)]
    public string CategoryName { get; set; }

    [Required]
    [StringLength(50)]
    public string CategoryNameEN { get; set; }

    [Min(0)]
    public int OrderNumber { get; set; }

    [Min(0)]
    public int ParentId { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        Validator.TryValidateProperty(IdCategory, new ValidationContext(this, null, null) { MemberName = "IdCategory" }, results);
        Validator.TryValidateProperty(CategoryName, new ValidationContext(this, null, null) { MemberName = "CategoryName" }, results);
        Validator.TryValidateProperty(CategoryNameEN, new ValidationContext(this, null, null) { MemberName = "CategoryNameEN" }, results);
        Validator.TryValidateProperty(OrderNumber, new ValidationContext(this, null, null) { MemberName = "OrderNumber" }, results);
        Validator.TryValidateProperty(ParentId, new ValidationContext(this, null, null) { MemberName = "ParentId" }, results);

        return results;
    }
}

public class RequestCategory_Filter
{
    public int IdCategory { get; set; }

    public string? CategoryName { get; set; }

    public string? CategoryNameEN { get; set; }

    public int OrderNumber { get; set; }

    public int ParentId { get; set; }
}