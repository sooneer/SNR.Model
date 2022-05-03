namespace SNR.Model;

[Table("SY_ROLE_PERMISSION")]
public class SY_ROLE_PERMISSION : BaseModel
{
    [Key]
    public int IdRolePermission { get; set; }

    public int IdRole { get; set; }
    public int IdPermission { get; set; }
    public int IdMenu { get; set; }
}