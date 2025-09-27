using Microsoft.EntityFrameworkCore;

namespace VampireTheMasquerade.DataContext;

/// <summary>
/// Представляет базовый инструмент для работы с данными.
/// </summary>
public abstract class BaseDataContext : DbContext
{
	#region .ctor
	/// <summary>
	/// Инициализирует новый экземпляр <see cref="BaseDataContext"/>.
	/// </summary>
	/// <param name="options"><see cref="DbContextOptions"/>.</param>
	protected BaseDataContext(DbContextOptions options) : base(options)
	{

	}
	#endregion

	#region Static
	/// <summary>
	/// Путь до БД.
	/// </summary>
	public static string DbPath
	{
		get;
		private set;
	} = string.Empty;

	/// <summary>
	/// Установка пути до БД.
	/// </summary>
	/// <param name="path"></param>
	public static void SetDbPath(string path)
	{
		DbPath = $"Data Source={path}";
	}
	#endregion
}
