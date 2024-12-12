using Web.Client.Services;

namespace Web.Services;

public class HttpLanguageProvider(IHttpContextAccessor httpContextAccessor) : ILanguageProvider
{
    public ValueTask<string?> DetectLanguage()
    {
        var lang = httpContextAccessor.HttpContext?.Request.GetTypedHeaders().AcceptLanguage?.FirstOrDefault()?.Value.ToString();
        return ValueTask.FromResult(lang);
    }

}

public class HttpTimeZoneProvider : ITimeZoneProvider
{
    public ValueTask<string?> DetectTimeZoneId()
    {
        return ValueTask.FromResult((string?)null);
    }
}

public class HttpNavigationProvider : INavigationProvider
{
    // noop
    public ValueTask Jump(string target) => ValueTask.CompletedTask;
}