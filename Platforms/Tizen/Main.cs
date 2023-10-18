using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MAUI_App;

internal class Program : MauiApplication
{
    protected override MauiApp CreateMauiApp()
    {
        return MauiProgram.CreateMauiApp();
    }

    private static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }
}