using FluentMigrator;

namespace VampireTheMasquerade.Migrations.Migrations;

/// <summary>
/// Представляет миграцию, добавляющая таблицу персонажей.
/// </summary>
[Migration(1, $"Добавляет таблицу {CharacterTableName}.")]
public class M001_AddCharacterTableMigration : Migration
{
	#region Data
	#region Fields
	/// <summary>
	/// Наименование таблицы - Персонажы
	/// </summary>
	public const string CharacterTableName = "character";
	/// <summary>
	/// Наименование колонки - Идентификатор записи.
	/// </summary>
	public const string IdColumnName = "id";
	/// <summary>
	/// Наименование колонки - Дискриминатор.
	/// </summary>
	public const string DiscriminatorColumnName = "discriminator";
	/// <summary>
	/// Наименование колонки - Наименование персонажа.
	/// </summary>
	public const string NameColumnName = "name";
	/// <summary>
	/// Наименование колонки - Наименование клана.
	/// </summary>
	public const string ClanColumnName = "clan_name";
	/// <summary>
	/// Наименование колонки - Кол-во exp.
	/// </summary>
	public const string ExpCountColumnName = "exp_count";
	/// <summary>
	/// Наименование колонки - Дата создания.
	/// </summary>
	public const string CreatedOnColumnName = "CreatedOnColumnName";
	/// <summary>
	/// Наименование колонки - Дата последнего изменения.
	/// </summary>
	public const string LastChangedColumnName = "last_changed";
	#endregion
	#endregion

	#region Overrided
	/// <inheritdoc/>
	public override void Down()
	{
		Delete.Table(CharacterTableName);
	}

	/// <inheritdoc/>
	public override void Up()
	{
		Create.Table(CharacterTableName)
			.WithColumn(IdColumnName)
			.AsGuid()
			.PrimaryKey()
			.NotNullable()
			.WithColumn(NameColumnName)
			.AsString()
			.NotNullable()
			.WithColumn(ClanColumnName)
			.AsString()
			.NotNullable()
			.WithColumn(ExpCountColumnName)
			.AsInt32()
			.WithDefaultValue(0)
			.NotNullable()
			.WithColumn(CreatedOnColumnName)
			.AsDateTime()
			.NotNullable()
			.WithColumn(LastChangedColumnName)
			.AsDateTime()
			.NotNullable()
			.WithColumn(DiscriminatorColumnName)
			.AsString()
			.NotNullable();
	}
	#endregion
}
