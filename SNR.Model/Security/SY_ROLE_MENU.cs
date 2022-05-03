namespace SNR.Model;

[Table("SY_ROLE_MENU")]
public class SY_ROLE_MENU : BaseModel
{
    [Key]
    public int IdRoleMenu { get; set; }

    public int IdRole { get; set; }
    public int IdMenu { get; set; }
}