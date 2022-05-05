namespace SNR.Model;

public class ResponseFilter
{
    public int IdFilter { get; set; }
    public string FilterName { get; set; }
    public bool IsSubmit { get; set; }
    public bool IsModify { get; set; }
    public bool IsDelete { get; set; }
    public bool IsGetEntry { get; set; }
    public string? RunIf { get; set; }
    public int FilterOrder { get; set; }
    public bool IsActive { get; set; }
}

public class ResponseFilter_Get
{
    public int IdFilter { get; set; }
    public string FilterName { get; set; }
    public bool IsSubmit { get; set; }
    public bool IsModify { get; set; }
    public bool IsDelete { get; set; }
    public bool IsGetEntry { get; set; }
    public string? RunIf { get; set; }
    public int FilterOrder { get; set; }
    public bool IsActive { get; set; }
}

public class ResponseFilter_GetAll
{
    public int IdFilter { get; set; }
    public string FilterName { get; set; }
    public bool IsSubmit { get; set; }
    public bool IsModify { get; set; }
    public bool IsDelete { get; set; }
    public bool IsGetEntry { get; set; }
    public string? RunIf { get; set; }
    public int FilterOrder { get; set; }
    public bool IsActive { get; set; }
}

public class ResponseFilter_Save
{
    public int IdFilter { get; set; }
    public string FilterName { get; set; }
    public bool IsSubmit { get; set; }
    public bool IsModify { get; set; }
    public bool IsDelete { get; set; }
    public bool IsGetEntry { get; set; }
    public string? RunIf { get; set; }
    public int FilterOrder { get; set; }
    public bool IsActive { get; set; }
}