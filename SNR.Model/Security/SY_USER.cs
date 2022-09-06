namespace SNR.Model;

[Table("SY_USER")]
public class SY_USER : BaseModel
{
    [Key]
    public int IdUser { get; set; }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string UserName { get; set; }
    public string Picture { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime? LastLoginDate { get; set; }
    public int IdEmployee { get; set; }
    public int IdCompany { get; set; }
    public bool IsActive { get; set; }
}