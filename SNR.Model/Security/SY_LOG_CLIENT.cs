namespace SNR.Model;

[Table("SY_LOG_CLIENT")]
public class SY_LOG_CLIENT : BaseModel
{
    [Key]
    public int IdLogClient { get; set; }

    public string RequestUrl { get; set; }
    public string ShortMessage { get; set; }
    public string ErrorMessage { get; set; }
}