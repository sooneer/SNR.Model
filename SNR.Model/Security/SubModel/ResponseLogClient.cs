namespace SNR.Model;

public class ResponseLogClient
{
    public int IdLogClient { get; set; }
    public string RequestUrl { get; set; }
    public string? ShortMessage { get; set; }
    public string ErrorMessage { get; set; }
}

public class ResponseLogClient_Get
{
    public int IdLogClient { get; set; }
    public string RequestUrl { get; set; }
    public string? ShortMessage { get; set; }
    public string ErrorMessage { get; set; }
    public string CreDate { get; set; }
    public string CreUser { get; set; }
}

public class ResponseLogClient_GetAll
{
    public int IdLogClient { get; set; }
    public string RequestUrl { get; set; }
    public string? ShortMessage { get; set; }
    public string CreDate { get; set; }
    public string CreUser { get; set; }
}

public class ResponseLogClient_Save
{
    public int IdLogClient { get; set; }
    public string RequestUrl { get; set; }
    public string? ShortMessage { get; set; }
    public string ErrorMessage { get; set; }
}