namespace SNR.Model;

public class ResponseColumn
{
    public int IdColumn { get; set; }
    public string? TableName { get; set; }
    public string? ModuleName { get; set; }
    public string? PageName { get; set; }
    public string ColumnName { get; set; }
    public string? LocaleTR { get; set; }
    public string? LocaleEN { get; set; }
}

public class ResponseColumn_Get
{
    public int IdColumn { get; set; }
    public string? TableName { get; set; }
    public string? ModuleName { get; set; }
    public string? PageName { get; set; }
    public string ColumnName { get; set; }
    public string? LocaleTR { get; set; }
    public string? LocaleEN { get; set; }
}

public class ResponseColumn_GetAll
{
    public int IdColumn { get; set; }
    public string? TableName { get; set; }
    public string? ModuleName { get; set; }
    public string? PageName { get; set; }
    public string ColumnName { get; set; }
    public string? LocaleTR { get; set; }
    public string? LocaleEN { get; set; }
}

public class ResponseColumn_Save
{
    public int IdColumn { get; set; }
    public string? TableName { get; set; }
    public string? ModuleName { get; set; }
    public string? PageName { get; set; }
    public string ColumnName { get; set; }
    public string? LocaleTR { get; set; }
    public string? LocaleEN { get; set; }
}
