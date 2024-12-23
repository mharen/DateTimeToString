using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Web.Client.Services
{
    public interface ILanguageProvider
    {
        ValueTask<string?> DetectLanguage();
    }

    public class JsLanguageProvider(IJSRuntime js) : ILanguageProvider
    {
        public async ValueTask<string?> DetectLanguage()
        {
            var lang = await js.InvokeAsync<string?>("getBrowserLanguage");
            return lang;
        }
    }


    public interface ITimeZoneProvider
    {
        ValueTask<string?> DetectTimeZoneId();
    }

    public class JsTimeZoneProvider(IJSRuntime js) : ITimeZoneProvider
    {
        public async ValueTask<string?> DetectTimeZoneId()
        {
            var tz = await js.InvokeAsync<string>("getBrowserTimeZone");
            return tz;
        }
    }


    public interface INavigationProvider
    {
        ValueTask Jump(string target);
    }
    public class JsNavigationProvider(IJSRuntime js) : INavigationProvider
    {
        public ValueTask Jump(string target) => js.InvokeVoidAsync("jump", target);
    }
}