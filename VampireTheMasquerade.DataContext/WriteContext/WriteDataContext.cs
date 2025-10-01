using Microsoft.EntityFrameworkCore;
using VampireTheMasquerade.Domain.Domain;

namespace VampireTheMasquerade.DataContext.WriteContext;

/// <summary>
/// Представляет инструмент для работы с данными.
/// </summary>
public class WriteDataContext : BaseDataContext
{

	#region .ctor
	/// <summary>
	/// Инициализирует новый экземпляр <see cref="WriteDataContext"/>.
	/// </summary>
	/// <param name="options"><see cref="DbContextOptions{T}"/>.</param>
	public WriteDataContext(DbContextOptions<WriteDataContext> options)
		: base(options)
	{
//#if DEBUG
//		Database.EnsureDeleted();
//#endif
		//Database.EnsureCreated();
	}
	#endregion

	#region Properties
	/// <summary>
	/// Возвращает набор персонажей.
	/// </summary>
	public DbSet<BaseCharacter> Characters
	{
		get;
		private set;
	}
	#endregion

	#region Overrided
	/// <inheritdoc/>
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.ApplyConfigurationsFromAssembly(GetType()
														 .Assembly,
													 type => type.Namespace!.StartsWith(GetType()
																							.Namespace!));
	}
	#endregion
}
