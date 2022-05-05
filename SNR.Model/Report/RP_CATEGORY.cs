namespace SNR.Model;

[Table("RP_CATEGORY")]
public class RP_CATEGORY : BaseModel
{
    [Key]
    public int IdCategory { get; set; }

    public string CategoryName { get; set; }
    public string CategoryNameEN { get; set; }
    public int OrderNumber { get; set; }
    public int ParentId { get; set; }
}