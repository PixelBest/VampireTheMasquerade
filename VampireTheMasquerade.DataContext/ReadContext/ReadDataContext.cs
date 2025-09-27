using Microsoft.EntityFrameworkCore;

namespace VampireTheMasquerade.DataContext.ReadContext;

/// <summary>
/// Представляет инструмент для чтения данных.
/// </summary>
public class ReadDataContext : BaseDataContext
{
	#region .ctor
	/// <summary>
	/// Инициализирует новый экземпляр <see cref="ReadDataContext"/>.
	/// </summary>
	/// <param name="options"><see cref="DbContextOptions{T}"/>.</param>
	public ReadDataContext(DbContextOptions<ReadDataContext> options) : base(options)
	{
	}
	#endregion
}
