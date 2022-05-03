namespace SNR.Model;

public static class ValidationLocale
{
    public static string GetLocale(string key, string locale)
    {
        if (key == "MinAttribute_Invalid")
        {
            return "The field {0} must be greater than or equal to {1}";
        }
        return "";
    }
}