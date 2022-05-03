namespace SNR.Model;

[Table("SY_MENU")]
public class SY_MENU : BaseModel
{
    [Key]
    public int IdMenu { get; set; }

    public int OrderNumber { get; set; }
    public string MenuName { get; set; }
    public string MenuNameEN { get; set; }
    public string MenuUrl { get; set; }
    public string MenuController { get; set; }
    public string MenuIcon { get; set; }
    public int ParentId { get; set; }
}