using FluentMigrator.Runner;
using VampireTheMasquerade.DataContext;
using VampireTheMasquerade.DataContext.WriteContext;
using VampireTheMasquerade.Migrations.Migrations;

namespace VampireTheMasquerade.Migrations;

/// <summary>
/// Представляет класс расширений для миграций.
/// </summary>
public static class MigrationExtension
{
	/// <summary>
	/// Добавляет миграции.
	/// </summary>
	/// <param name="services"><see cref="IServiceCollection"/>.</param>
	/// <returns><see cref="IServiceCollection"/>.</returns>
	public static IServiceCollection AddMigrations(this IServiceCollection services)
	{
		//TODO: Добавить ссылку на настоящию миграцию, тестовую убрать.
		services.AddFluentMigratorCore()
				.ConfigureRunner(rb => rb.AddSQLite()
										 .WithGlobalConnectionString(BaseDataContext.DbPath)
										 .ScanIn(typeof(M001_AddTestTableMigrations).Assembly)
										 .For
										 .All());

		return services;
	}

	/// <summary>
	/// Запускает повышение миграции.
	/// </summary>
	/// <param name="app"><see cref="MauiApp"/>.</param>
	public static void RunMigarions(this MauiApp app)
	{
		var runner = app.Services.GetRequiredService<IMigrationRunner>();

		runner.MigrateUp();
	}
}
