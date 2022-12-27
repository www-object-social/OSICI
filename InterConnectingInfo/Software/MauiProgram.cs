using Microsoft.Extensions.Logging;
using OSICI.Product;

namespace Software;
 public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();
        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddPI(Name.InterConnectingInfo, OSICI.Product.Type.Application);
        #if DEBUG
		    builder.Services.AddBlazorWebViewDeveloperTools();
		    builder.Logging.AddDebug();
        #endif
        return builder.Build();
    }
}