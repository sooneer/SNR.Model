namespace SNR.Model;

[Table("SY_COLUMN")]
public class SY_COLUMN : BaseModel
{
    [Key]
    public int IdColumn { get; set; }

    public string TableName { get; set; }
    public string ModuleName { get; set; }
    public string PageName { get; set; }
    public string ColumnName { get; set; }
    public string LocaleTR { get; set; }
    public string LocaleEN { get; set; }
}
