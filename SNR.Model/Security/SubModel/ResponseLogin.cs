namespace SNR.Model;

public class ResponseLogin
{
}

public class ResponseLogin_Token
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Picture { get; set; }
    public string Token { get; set; }
    public List<int> IdRole { get; set; }
}