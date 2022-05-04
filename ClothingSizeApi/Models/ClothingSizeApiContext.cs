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
          new Brand { BrandId = 1, Name = "Gap", ClothingType = "top", Gender = "mens", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 2, Name = "Gap", ClothingType = "top", Gender = "mens", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 3, Name = "Gap", ClothingType = "bottom", Gender = "mens", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 4, Name = "Gap", ClothingType = "bottom", Gender = "mens", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 5, Name = "H&M", ClothingType = "top", Gender = "mens", XXXS ="n/a", XXS= "n/a", XS="26R", S="32R" ,M= "34R",L ="36R" ,XL="44R", XXL="46R", XXXL=" 48R", XXXXL= "50R"},
          new Brand { BrandId = 6, Name = "H&M", ClothingType = "top", Gender = "mens", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 7, Name = "H&M", ClothingType = "bottom", Gender = "womens", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" },
          new Brand { BrandId = 8, Name = "H&M", ClothingType = "bottom", Gender = "womens", XXXS = "00", XXS= "0", XS="0", S= "2", M= "6", L = "12", XL="16", XXL="18", XXXL="20", XXXXL="24" }
        );

        builder.Entity<Size>()
        .HasData(
          new Size { SizeId = 1, Brand = "Gap", ClothingType = "top", Gender = "womens", LetterSize ="s", Neck =15, Chest =38, Sleeve =32, Waist =32, Hip =30, Inseam =31},
          new Size { SizeId = 2, Brand = "H&M", ClothingType = "top", Gender = "mens", LetterSize ="s", Neck =16, Chest =38, Sleeve =32, Waist =32, Hip =30, Inseam = 31},
          new Size { SizeId = 3, Brand = "Gap", ClothingType = "bottom", Gender = "womens", LetterSize ="s", Neck =15.5, Chest =38, Sleeve =32, Waist =32, Hip =30, Inseam =31},
          new Size { SizeId = 4, Brand = "H&M", ClothingType = "bottom", Gender = "mens", LetterSize ="m", Neck =16, Chest =40, Sleeve =33, Waist =34, Hip =30, Inseam =32},
          new Size { SizeId = 5, Brand = "Gap", ClothingType = "top", Gender = "mens", LetterSize ="m", Neck =16.5, Chest =40, Sleeve =33, Waist =34, Hip =30, Inseam =32},
          new Size { SizeId = 6, Brand = "H&M", ClothingType = "top", Gender = "mens", LetterSize ="m", Neck =16, Chest =40, Sleeve =33, Waist =34, Hip =30, Inseam =32},
          new Size { SizeId = 7, Brand = "Gap", ClothingType = "bottom", Gender = "womens", LetterSize ="l", Neck =16.5, Chest =42, Sleeve =34, Waist =36, Hip =30, Inseam =34},
          new Size { SizeId = 8, Brand = "H&M", ClothingType = "bottom", Gender = "womens",LetterSize ="l", Neck =17, Chest =42, Sleeve =34, Waist =36, Hip =30, Inseam =34}
        );
    }
        public DbSet <Brand> Brands { get; set; }
        public DbSet <Size> Sizes {get; set; }
    }
}
