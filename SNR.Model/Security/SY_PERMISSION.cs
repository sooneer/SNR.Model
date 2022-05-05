namespace SNR.Model;

[Table("SY_PERMISSION")]
public class SY_PERMISSION : BaseModel
{
    [Key]
    public int IdPermission { get; set; }

    public string PermissionName { get; set; }
    public string PermissionNameEN { get; set; }
    public string FullPath { get; set; }
    public string PermissionDesc { get; set; }
    public string PermissionDescEN { get; set; }
    public bool IsGeneral { get; set; }
}