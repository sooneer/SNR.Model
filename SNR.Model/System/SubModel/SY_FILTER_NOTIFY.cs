namespace SNR.Model;

[Table("SY_FILTER_NOTIFY")]
public class SY_FILTER_NOTIFY : BaseModel
{
    [Key]
    public int IdFilterNotify { get; set; }
    public int IdFilter { get; set; }
    public string NotifyMessage { get; set; }
}