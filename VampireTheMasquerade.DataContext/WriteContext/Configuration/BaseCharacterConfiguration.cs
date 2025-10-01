using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VampireTheMasquerade.Domain.Domain;
using static VampireTheMasquerade.Migrations.Migrations.M001_AddCharacterTableMigration;


namespace VampireTheMasquerade.DataContext.WriteContext.Configuration;
public class BaseCharacterConfiguration : IEntityTypeConfiguration<BaseCharacter>
{

	#region IEntityTypeConfiguration<BaseCharacter> members
	/// <inheritdoc/>
	public void Configure(EntityTypeBuilder<BaseCharacter> builder)
	{
		builder.ToTable(CharacterTableName);
	}
	#endregion
}
