using Microsoft.Extensions.Logging;
using BHD_Demo.ViewModels.Store;
using BHD_Demo.Views.Store;
using BHD_Demo.ViewModels.Service;
using BHD_Demo.Views.Service;

namespace BHD_Demo;

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
				fonts.AddFont("Iceland-Regular.ttf", "Iceland");
			});


		//Register ViewModels
		builder.Services.AddSingleton<StoreViewModel>();
		builder.Services.AddTransient<DetailViewModel>();

		builder.Services.AddSingleton<ServiceSchedulerViewModel>();
		builder.Services.AddTransient<ServiceDetailViewModel>();

		//Register Pages
		builder.Services.AddSingleton<StorePage>();
		builder.Services.AddTransient<DetailPage>();

		builder.Services.AddSingleton<ServiceSchedulerPage>();
		builder.Services.AddTransient<ServiceDetailPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif


		return builder.Build();
	}
}
