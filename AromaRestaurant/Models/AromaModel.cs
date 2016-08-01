//    -File Name: AromaModel.cs
//    - Author's Name: Akhil Thakkar(200300312) and Gurpanth Singh(200299024)
//    - Website Name: aromarestaurant.azurewebsites.net
//    - Full Description: This file Initilizes the MenuType and MenuItem.
namespace AromaRestaurant.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AromaModel : DbContext
    {
        public AromaModel()
            : base("name=AromaConnection")
        {
        }

        public virtual DbSet<MenuType> MenuTypes { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Menu>()
        //        .Property(e => e.ThumbImage)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Menu>()
        //        .Property(e => e.LargeImage)
        //        .IsUnicode(false);
        //}
    }
}
