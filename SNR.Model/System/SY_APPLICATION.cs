namespace SNR.Model;

[Table("SY_APPLICATION")]
public class SY_APPLICATION : BaseModel
{
    [Key]
    public int IdApplication { get; set; }

    public string ApplicationCode { get; set; }
    public string ApplicationName { get; set; }
}