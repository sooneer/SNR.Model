namespace SNR.Model;

public class ResponseLog
{
    public int IdLog { get; set; }
    public string? RequestUrl { get; set; }
    public string? ShortMessage { get; set; }
    public string? ErrorMessage { get; set; }
}

public class ResponseLog_Get
{
    public int IdLog { get; set; }
    public string? RequestUrl { get; set; }
    public string? ShortMessage { get; set; }
    public string? ErrorMessage { get; set; }
}

public class ResponseLog_GetAll
{
    public int IdLog { get; set; }
    public string? RequestUrl { get; set; }
    public string? ShortMessage { get; set; }
    public string? ErrorMessage { get; set; }
}

public class ResponseLog_Save
{
    public int IdLog { get; set; }
    public string? RequestUrl { get; set; }
    public string? ShortMessage { get; set; }
    public string? ErrorMessage { get; set; }
}
