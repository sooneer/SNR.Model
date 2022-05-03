namespace SNR.Model;

[Table("SY_USER_ROLE")]
public class SY_USER_ROLE : BaseModel
{
    [Key]
    public int IdUserRole { get; set; }

    public int IdUser { get; set; }
    public int IdRole { get; set; }
}