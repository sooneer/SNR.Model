namespace SNR.Model;

[Table("SY_LOG")]
public class SY_LOG : BaseModel
{
    [Key]
    public int IdLog { get; set; }

    public string RequestUrl { get; set; }
    public string ShortMessage { get; set; }
    public string ErrorMessage { get; set; }
}
