using System.ComponentModel.DataAnnotations;

namespace SNR.Model;

public class RequestLogClient : IValidatableObject
{
    [Min(0)]
    public int IdLogClient { get; set; }

    [Required]
    [StringLength(150)]
    public string RequestUrl { get; set; }

    [StringLength(8000)]
    public string? ShortMessage { get; set; }

    [Required]
    [StringLength(8000)]
    public string ErrorMessage { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        Validator.TryValidateProperty(IdLogClient, new ValidationContext(this, null, null) { MemberName = "IdLogClient" }, results);
        Validator.TryValidateProperty(RequestUrl, new ValidationContext(this, null, null) { MemberName = "RequestUrl" }, results);
        Validator.TryValidateProperty(ShortMessage, new ValidationContext(this, null, null) { MemberName = "ShortMessage" }, results);
        Validator.TryValidateProperty(ErrorMessage, new ValidationContext(this, null, null) { MemberName = "ErrorMessage" }, results);

        return results;
    }
}

public class RequestLogClient_Filter
{
    public int IdLogClient { get; set; }

    public string? RequestUrl { get; set; }

    public string? ShortMessage { get; set; }

    public string? ErrorMessage { get; set; }
}