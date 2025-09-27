using Microsoft.EntityFrameworkCore;
using VampireTheMasquerade.DataContext.ReadContext;
using VampireTheMasquerade.DataContext.WriteContext;

namespace VampireTheMasquerade.DataContext.Extensions;

/// <summary>
/// Представляет расширения для работы с данными.
/// </summary>
public static class DataContextExtension
{
	#region Public
	/// <summary>
	/// Добавляет контекст данных.
	/// </summary>
	/// <param name="services"><see cref="IServiceCollection"/>.</param>
	/// <returns><see cref="IServiceCollection"/>.</returns>
	public static IServiceCollection AddDataContext(this IServiceCollection services)
	{
		var folder = Environment.SpecialFolder.LocalApplicationData;
		var path = Environment.GetFolderPath(folder);
		var pathDb = Path.Join(path, "vampire.db");
		BaseDataContext.SetDbPath(pathDb);
		services.AddWriteDataContext();
		services.AddReadDataContext();

		return services;
	}
	#endregion

	#region Private
	private static IServiceCollection AddWriteDataContext(this IServiceCollection services)
	{
		services.AddDbContext<WriteDataContext>(options =>
		{
			options.UseSqlite(WriteDataContext.DbPath);
		});

		return services;
	}

	private static IServiceCollection AddReadDataContext(this IServiceCollection services)
	{
		services.AddPooledDbContextFactory<ReadDataContext>(options =>
		{
			options.UseSqlite(ReadDataContext.DbPath);
			options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
		});

		return services;
	}
	#endregion


}
