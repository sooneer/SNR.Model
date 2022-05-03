using System.ComponentModel.DataAnnotations;

namespace SNR.Model;

public class RequestMenu : IValidatableObject
{
    [Min(0)]
    public int IdMenu { get; set; }

    [Min(0)]
    public int OrderNumber { get; set; }

    [StringLength(50)]
    public string? ModuleName { get; set; }

    [Required]
    [StringLength(150)]
    public string MenuName { get; set; }

    [StringLength(150)]
    public string? MenuNameEN { get; set; }

    [StringLength(150)]
    public string? MenuUrl { get; set; }

    [StringLength(50)]
    public string? MenuController { get; set; }

    [StringLength(50)]
    public string? MenuIcon { get; set; }

    [Min(0)]
    public int ParentId { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        Validator.TryValidateProperty(IdMenu, new ValidationContext(this, null, null) { MemberName = "IdMenu" }, results);
        Validator.TryValidateProperty(OrderNumber, new ValidationContext(this, null, null) { MemberName = "OrderNumber" }, results);
        Validator.TryValidateProperty(ModuleName, new ValidationContext(this, null, null) { MemberName = "ModuleName" }, results);
        Validator.TryValidateProperty(MenuName, new ValidationContext(this, null, null) { MemberName = "MenuName" }, results);
        Validator.TryValidateProperty(MenuNameEN, new ValidationContext(this, null, null) { MemberName = "MenuNameEN" }, results);
        Validator.TryValidateProperty(MenuUrl, new ValidationContext(this, null, null) { MemberName = "MenuUrl" }, results);
        Validator.TryValidateProperty(MenuController, new ValidationContext(this, null, null) { MemberName = "MenuController" }, results);
        Validator.TryValidateProperty(MenuIcon, new ValidationContext(this, null, null) { MemberName = "MenuIcon" }, results);
        Validator.TryValidateProperty(ParentId, new ValidationContext(this, null, null) { MemberName = "ParentId" }, results);

        return results;
    }
}

public class RequestMenu_Filter
{
    public int IdMenu { get; set; }
    public int OrderNumber { get; set; }
    public string? ModuleName { get; set; }
    public string? MenuName { get; set; }
    public string? MenuNameEN { get; set; }
    public string? MenuUrl { get; set; }
    public string? MenuController { get; set; }
    public string? MenuIcon { get; set; }
    public int ParentId { get; set; }
}