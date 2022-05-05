namespace SNR.Model;

public class ResponseCategory
{
    public int IdCategory { get; set; }
    public string CategoryName { get; set; }
    public string CategoryNameEN { get; set; }
    public int OrderNumber { get; set; }
    public int ParentId { get; set; }
}

public class ResponseCategory_Get
{
    public int IdCategory { get; set; }
    public string CategoryName { get; set; }
    public string CategoryNameEN { get; set; }
    public int OrderNumber { get; set; }
    public int ParentId { get; set; }
}

public class ResponseCategory_GetAll
{
    public int IdCategory { get; set; }
    public string CategoryName { get; set; }
    public string CategoryNameEN { get; set; }
    public int OrderNumber { get; set; }
    public int ParentId { get; set; }
}

public class ResponseCategory_Save
{
    public int IdCategory { get; set; }
    public string CategoryName { get; set; }
    public string CategoryNameEN { get; set; }
    public int OrderNumber { get; set; }
    public int ParentId { get; set; }
}