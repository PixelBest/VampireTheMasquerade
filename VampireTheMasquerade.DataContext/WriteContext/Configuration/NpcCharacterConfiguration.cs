using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VampireTheMasquerade.Domain.Domain;
using static VampireTheMasquerade.Migrations.Migrations.M001_AddCharacterTableMigration;

namespace VampireTheMasquerade.DataContext.WriteContext.Configuration;

/// <summary>
/// Представляет конфигурацию для <see cref="NpcCharacter"/>.
/// </summary>
public class NpcCharacterConfiguration : IEntityTypeConfiguration<NpcCharacter>
{
	#region IEntityTypeConfiguration<NpcCharacter> members
	/// <inheritdoc/>
	public void Configure(EntityTypeBuilder<NpcCharacter> builder)
	{
		builder.ToTable(CharacterTableName);
	}
	#endregion
}
