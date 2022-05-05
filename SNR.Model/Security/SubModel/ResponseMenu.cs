namespace SNR.Model;

public class ResponseMenu
{
    public int IdMenu { get; set; }
    public int OrderNumber { get; set; }
    public string? ModuleName { get; set; }
    public string MenuName { get; set; }
    public string? MenuNameEN { get; set; }
    public string? MenuUrl { get; set; }
    public string? MenuController { get; set; }
    public string? MenuIcon { get; set; }
    public int ParentId { get; set; }
}

public class ResponseMenu_Get
{
    public int IdMenu { get; set; }
    public int OrderNumber { get; set; }
    public string? ModuleName { get; set; }
    public string MenuName { get; set; }
    public string? MenuNameEN { get; set; }
    public string? MenuUrl { get; set; }
    public string? MenuController { get; set; }
    public string? MenuIcon { get; set; }
    public int ParentId { get; set; }
}

public class ResponseMenu_GetAll
{
    public int IdMenu { get; set; }
    public int OrderNumber { get; set; }
    public string? ModuleName { get; set; }
    public string MenuName { get; set; }
    public string? MenuNameEN { get; set; }
    public string? MenuUrl { get; set; }
    public string? MenuController { get; set; }
    public string? MenuIcon { get; set; }
    public int ParentId { get; set; }
}

public class ResponseMenu_Save
{
    public int IdMenu { get; set; }
    public int OrderNumber { get; set; }
    public string? ModuleName { get; set; }
    public string MenuName { get; set; }
    public string? MenuNameEN { get; set; }
    public string? MenuUrl { get; set; }
    public string? MenuController { get; set; }
    public string? MenuIcon { get; set; }
    public int ParentId { get; set; }
}