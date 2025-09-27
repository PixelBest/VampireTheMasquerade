using FluentMigrator;

namespace VampireTheMasquerade.Migrations.Migrations;

/// <summary>
/// Тестовая миграция.
/// </summary>
[Migration(1, "Тест таблица")]
public class M001_AddTestTableMigrations : Migration
{
	#region Data
	#region Const
	public const string TestTableName = "tests";
	public const string IdColumnName = "id";
	public const string NameColumnName = "name";
	#endregion
	#endregion

	#region .ctor
	/// <summary>
	/// Инициализирует новый экземпляр <see cref="M001_AddTestTableMigrations"/>.
	/// </summary>
	public M001_AddTestTableMigrations() : base()
	{
	}
	#endregion

	#region Overrided
	/// <inheritdoc/>
	public override void Down()
	{
		Delete.Table(TestTableName);
	}

	/// <inheritdoc/>
	public override void Up()
	{
		Create.Table(TestTableName)
			  .WithColumn(IdColumnName)
			  .AsGuid()
			  .PrimaryKey()
			  .Nullable()
			  .WithColumn(NameColumnName)
			  .AsString()
			  .Nullable();
	}
	#endregion
}
