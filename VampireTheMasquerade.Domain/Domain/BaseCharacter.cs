namespace VampireTheMasquerade.Domain.Domain;

/// <summary>
/// Базовый класс персонажа.
/// </summary>
public abstract class BaseCharacter
{
	#region Properties
	/// <summary>
	/// Наименование персонажа.
	/// </summary>
	public string Name
	{
		get;
		set;
	} = null!;

	/// <summary>
	/// Наименование клана персонажа.
	/// </summary>
	public string Clan
	{
		get;
		set;
	} = null!;

	/// <summary>
	/// Кол-во опыта.
	/// </summary>
	public int ExpCount
	{
		get;
		set;
	}

	/// <summary>
	/// Дата создания.
	/// </summary>
	public DateTime CreatedOn
	{
		get;
		set;
	}

	/// <summary>
	/// Дата последнего изменения.
	/// </summary>
	public DateTime LastEdit
	{
		get;
		set;
	}
	#endregion
}
