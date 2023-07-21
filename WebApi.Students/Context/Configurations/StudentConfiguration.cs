using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Students.Entities;

namespace Students.Context.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(s => s.Id);

            builder.OwnsOne(s => s.Perfil, perfil =>
            {
                perfil.Property(p => p.FirstName).HasColumnName("FirstName");
                perfil.Property(p => p.LastName).HasColumnName("LastName");
                perfil.Property(p => p.Gender).HasColumnName("Gender");
                perfil.Property(p => p.Age).HasColumnName("Age");
            });

            builder.OwnsOne(s => s.Email, email =>
            {
                email.Property(e => e.Address).HasColumnName("Email");
                email.Property(e => e.Confirmed).HasColumnName("ConfirmedEmail");
            });

            builder.OwnsOne(s => s.Address, address =>
            {
                address.Property(a => a.Country).HasColumnName("Country");
                address.Property(a => a.State).HasColumnName("State");
                address.Property(a => a.City).HasColumnName("City");
                address.Property(a => a.ZipCode).HasColumnName("ZipCode");
                address.Property(a => a.Street).HasColumnName("Street");
                address.Property(a => a.Number).HasColumnName("Number");
            });
        }
    }
}
