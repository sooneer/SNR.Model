namespace SNR.Model;

[Table("SY_ROLE")]
public class SY_ROLE : BaseModel
{
    [Key]
    public int IdRole { get; set; }

    public string RoleName { get; set; }
}