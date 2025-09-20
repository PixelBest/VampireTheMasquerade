namespace VampireTheMasquerade.Extensions;
public static class PageExtensions
{
	public static IServiceCollection AddPages(this IServiceCollection services)
	{
		services.AddSingleton<MainPage>();

		return services;
	}
}
