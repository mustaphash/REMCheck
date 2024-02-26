using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class PositionConfig : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired();

            builder.HasData(
                new Position
                {
                    Id = 1,
                    Name = "Dealer"
                },

                new Position
                {
                    Id = 2,
                    Name = "Shuffler"
                }
                );
        }
    }
}
