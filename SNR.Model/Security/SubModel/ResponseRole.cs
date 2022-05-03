namespace SNR.Model;

public class ResponseRole
{
    public int IdRole { get; set; }
    public string RoleName { get; set; }
}

public class ResponseRole_Get
{
    public int IdRole { get; set; }
    public string RoleName { get; set; }
}

public class ResponseRole_GetAll
{
    public int IdRole { get; set; }
    public string RoleName { get; set; }
}

public class ResponseRole_Save
{
    public int IdRole { get; set; }
    public string RoleName { get; set; }
}

public class ResponseRole_GetAllMenu
{
    public int IdMenu { get; set; }
    public int IdRole { get; set; }
    public string MenuName { get; set; }
    public int OrderNumber { get; set; }
    public int ParentId { get; set; }
    public bool IsActive { get; set; }
    public bool IsView { get; set; }
    public bool IsNew { get; set; }
    public bool IsEdit { get; set; }
    public bool IsDelete { get; set; }

    private List<ResponseRole_GetAllMenu> _items;

    public List<ResponseRole_GetAllMenu> Items
    {
        get
        {
            if (_items == null)
            {
                _items = new List<ResponseRole_GetAllMenu>();
            }
            return _items;
        }
        set { _items = value; }
    }
}