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
