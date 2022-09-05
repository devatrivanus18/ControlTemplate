using ControlTemplate.ViewModels;
using CustomControlLibrary.CustomControls;
namespace ControlTemplate;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


        builder.Services.AddSingleton(new vmLogin());
        builder.Services.AddSingleton(new vmTest());
        builder.Services.AddSingleton(new vmDataSensor());
        builder.Services.AddSingleton(new EntriControl());

        return builder.Build();
	}
}
