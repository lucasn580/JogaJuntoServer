using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace webApi.Models.Mapping
{
    public class QuadraMap : EntityTypeConfiguration<Quadra>
    {
        public QuadraMap()
        {
            // Primary Key
            this.HasKey(t => t.Id_Quadra);

            // Properties
            this.Property(t => t.Id_Quadra)
            	.IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CoordernateOne)
           		.IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CoordernateTwo)
            	.IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Opcionais)
                .HasMaxLength(100);

            this.Property(t => t.Tipo_Quadra)
            	.IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Quadra");
            this.Property(t => t.Id_Quadra).HasColumnName("Id_Quadra");
            this.Property(t => t.Id_Dono).HasColumnName("Id_Dono");
            this.Property(t => t.Id_End).HasColumnName("Id_End");
            this.Property(t => t.CoordernateOne).HasColumnName("CoordernateOne");
            this.Property(t => t.CoordernateTwo).HasColumnName("CoordernateTwo");
            this.Property(t => t.Opcionais).HasColumnName("Opcionais");
            this.Property(t => t.Tipo_Quadra).HasColumnName("Tipo_Quadra");

            // Relationships
            //this.HasRequired(t => t.Dono)
            //    .WithMany(t => t.Quadras)
            //    .HasForeignKey(d => d.Id_Dono);
            //this.HasRequired(t => t.Endereco)
            //    .WithMany(t => t.Quadras)
            //    .HasForeignKey(d => d.Id_End);

        }
    }
}
