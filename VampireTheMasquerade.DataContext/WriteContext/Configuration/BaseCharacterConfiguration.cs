using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VampireTheMasquerade.Domain.Domain;
using static VampireTheMasquerade.Migrations.Migrations.M001_AddCharacterTableMigration;

namespace VampireTheMasquerade.DataContext.WriteContext.Configuration;

/// <summary>
/// Представляет конфигурацию данных для <see cref="BaseCharacter"/>.
/// </summary>
public class BaseCharacterConfiguration : IEntityTypeConfiguration<BaseCharacter>
{
	#region IEntityTypeConfiguration<BaseCharacter> members
	/// <inheritdoc/>
	public void Configure(EntityTypeBuilder<BaseCharacter> builder)
	{
		builder.ToTable(CharacterTableName);
		builder.HasKey(p => p.Id);
		builder.Property(unit => unit.Id).HasColumnName(IdColumnName);
		builder.HasDiscriminator<string>(DiscriminatorColumnName)
			   .HasValue<NpcCharacter>(nameof(NpcCharacter))
			   .HasValue<GameCharacter>(nameof(GameCharacter));
		builder.Property(unit => unit.Name).HasColumnName(NameColumnName);
		builder.Property(unit => unit.ExpCount).HasColumnName(ExpCountColumnName);
		builder.Property(p => p.Clan).HasColumnName(ClanColumnName);
		builder.Property(unit => unit.CreatedOn).HasColumnName(CreatedOnColumnName);
		builder.Property(unit => unit.LastChanged).HasColumnName(LastChangedColumnName);
	}
	#endregion
}
