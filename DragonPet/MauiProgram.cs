﻿using Microsoft.Extensions.Logging;

namespace DragonPet;

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
				fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf","Font1");
                fonts.AddFont("Font Awesome 6 Free-Solid-900.otf","Font2");
                fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf","Font3");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
