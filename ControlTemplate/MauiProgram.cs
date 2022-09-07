using CommunityToolkit.Maui;
using ControlTemplate.ViewModels;

namespace ControlTemplate;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton(new vmLogin());
        builder.Services.AddSingleton(new vmTest());
        builder.Services.AddSingleton(new vmTransaksi());
        builder.Services.AddSingleton(new vmData());

        return builder.Build();
	}
}
