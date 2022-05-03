namespace SNR.Model;

public class ResponseUser
{
    public int IdUser { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime? LastLoginDate { get; set; }
    public bool IsActive { get; set; }
}

public class ResponseUser_Get
{
    public int IdUser { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string LastLoginDate { get; set; }
    public bool IsActive { get; set; }
}

public class ResponseUser_GetAll
{
    public int IdUser { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string LastLoginDate { get; set; }
    public bool IsActive { get; set; }
}

public class ResponseUser_Save
{
    public int IdUser { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime? LastLoginDate { get; set; }
    public bool IsActive { get; set; }
}

public class ResponseUser_GetAllRole
{
    public int IdRole { get; set; }
    public int IdUser { get; set; }
    public string RoleName { get; set; }
    public bool IsActive { get; set; }
}