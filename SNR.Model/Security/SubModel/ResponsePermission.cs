namespace SNR.Model;

public class ResponsePermission
{
    public int IdPermission { get; set; }
    public string PermissionName { get; set; }
    public string? PermissionNameEN { get; set; }
    public string? FullPath { get; set; }
    public string? PermissionDesc { get; set; }
    public string? PermissionDescEN { get; set; }
    public bool IsGeneral { get; set; }
}

public class ResponsePermission_Get
{
    public int IdPermission { get; set; }
    public string PermissionName { get; set; }
    public string? PermissionNameEN { get; set; }
    public string? FullPath { get; set; }
    public string? PermissionDesc { get; set; }
    public string? PermissionDescEN { get; set; }
    public bool IsGeneral { get; set; }
}

public class ResponsePermission_GetAll
{
    public int IdPermission { get; set; }
    public string PermissionName { get; set; }
    public string? PermissionNameEN { get; set; }
    public string? FullPath { get; set; }
    public string? PermissionDesc { get; set; }
    public string? PermissionDescEN { get; set; }
    public bool IsGeneral { get; set; }
}

public class ResponsePermission_Save
{
    public int IdPermission { get; set; }
    public string PermissionName { get; set; }
    public string? PermissionNameEN { get; set; }
    public string? FullPath { get; set; }
    public string? PermissionDesc { get; set; }
    public string? PermissionDescEN { get; set; }
    public bool IsGeneral { get; set; }
}
