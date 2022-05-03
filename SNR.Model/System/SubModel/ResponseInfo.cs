namespace SNR.Model;

public class ResponseInfo
{
}

public class ResponseInfo_GetUserInfo
{
    public int IdUser { get; set; }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
}

public class ResponseInfo_GetAllPermission
{
    public int IdMenu { get; set; }
    public string MenuName { get; set; }
    public string MenuUrl { get; set; }
    public string MenuIcon { get; set; }
    public int ParentId { get; set; }

    public bool IsView { get; set; }
    public bool IsNew { get; set; }
    public bool IsEdit { get; set; }
    public bool IsDelete { get; set; }

    private List<ResponseInfo_GetAllPermission> _items;

    public List<ResponseInfo_GetAllPermission> Items
    {
        get
        {
            if (_items == null)
            {
                _items = new List<ResponseInfo_GetAllPermission>();
            }
            return _items;
        }
        set { _items = value; }
    }
}