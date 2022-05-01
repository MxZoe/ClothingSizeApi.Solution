using Microsoft.EntityFrameworkCore;

namespace ClothingSizeApi.Models
{
    public class ClothingSizeApiContext : DbContext
    {
        public ClothingSizeApiContext(DbContextOptions<ClothingSizeApiContext> options)
            : base(options)
        {
        }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Brand>()
        .HasData(
          new Brand { BrandId = 1, Name = "Gap", ClothingType = "top", Gender = "female", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 2, Name = "Gap", ClothingType = "top", Gender = "male", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 3, Name = "Gap", ClothingType = "bottom", Gender = "female", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 4, Name = "Gap", ClothingType = "bottom", Gender = "male", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 5, Name = "H&M", ClothingType = "top", Gender = "male", XXXS ="n/a", XXS= "n/a", XS="26R", S="32R" ,M= "34R",L ="36R" ,XL="44R", XXL="46R", XXXL=" 48R", XXXXL= "50R"},
          new Brand { BrandId = 6, Name = "H&M", ClothingType = "top", Gender = "male", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 7, Name = "H&M", ClothingType = "bottom", Gender = "female", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 8, Name = "H&M", ClothingType = "bottom", Gender = "female", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" }
        );
    }
        public DbSet <Brand> Brands { get; set; }
    }
}






   
   