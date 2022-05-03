namespace SNR.Model;

[Table("SY_FILTER")]
public class SY_FILTER : BaseModel
{
    [Key]
    public int IdFilter { get; set; }

    public string FilterName { get; set; }
    public bool IsSubmit { get; set; }
    public bool IsModify { get; set; }
    public bool IsDelete { get; set; }
    public bool IsGetEntry { get; set; }
    public string RunIf { get; set; }
    public int FilterOrder { get; set; }
    public bool IsActive { get; set; }
}
