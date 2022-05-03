namespace SNR.Model;

public class BaseModel
{
    public int CreUser { get; set; }
    public int ModUser { get; set; }
    public int DelUser { get; set; }

    private string _client;

    public string Client
    {
        get
        {
            //if (Request != null && string.IsNullOrEmpty(_client))
            //{
            //    _client = Request.GetCurrentClientName();
            //    return _client;
            //}
            //else
            //{
            return _client;
            //}
        }
        set { _client = value; }
    }

    private string _clientIp;

    public string ClientIp
    {
        get
        {
            //if (HttpContext.Request != null && string.IsNullOrEmpty(_clientIp))
            //{
            //    _clientIp = HttpRequestHelper.GetCurrentIP(HttpContext.Request);
            //    return _clientIp;
            //}
            //else
            //{
            return _clientIp;
            //}
        }
        set { _clientIp = value; }
    }

    private DateTime _credate;

    [Write(false)]
    public DateTime CreDate
    {
        get
        {
            if (_credate.Year < 1911)
            {
                _credate = DateTime.Now;
                return _credate;
            }
            else
            {
                return _credate;
            }
        }
        set { _credate = value; }
    }

    public DateTime? ModDate { get; set; }

    public DateTime? DelDate { get; set; }

    public bool Deleted { get; set; }
}
