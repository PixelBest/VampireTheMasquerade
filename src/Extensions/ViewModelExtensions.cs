using VampireTheMasquerade.Pages.MainPages;

namespace VampireTheMasquerade.Extensions;
public static class ViewModelExtensions
{
	public static IServiceCollection AddViewModel(this IServiceCollection services)
	{
		services.AddSingleton<MainPageViewModel>();

		return services;
	}
}
