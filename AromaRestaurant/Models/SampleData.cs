using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace AromaRestaurant.Models
{
    public class SampleData : DropCreateDatabaseAlways<AromaModel>
    {
        protected override void Seed(AromaModel context)
        {
            var types = new List<MenuType>
            {
                new MenuType { Name = "Appetizer"},
                new MenuType { Name = "Main Course"},
                new MenuType { Name = "Desserts"}
            };

            new List<MenuItem>
            {
                new MenuItem {MenuName = "Gulab Jamun",description="Gulab jamun, or gulaab jamun, is a milk-solids-based sweet mithai, popular in countries of South Asia, in particular in India", Price=5.99M, MenuType = types.Single(g => g.Name == "Appetizer"), FoodUrl = "/Assets/images/gulabjamun.jpg" },
                new MenuItem {MenuName = "Chicken Biryani", description="", Price=10.25M, MenuType = types.Single(g => g.Name == "Main Course"), FoodUrl = "/Assets/images/Biryani.jpg" },
                new MenuItem {MenuName = "Dal Makhani", description = "Dal makhani or dal makhni Buttery Lentil is a popular dish originating from the Punjab region of the Indian Subcontinent. The primary ingredients in dal makhani are whole black lentil with red kidney beans, butter and cream.", Price=13.99M, MenuType= types.Single(g => g.Name == "Main Course"), FoodUrl = "/Assets/images/dal_makhani.jpg" },
                new MenuItem {MenuName = "Naan Bread", description ="Naan, nan or khamiri is a leavened, oven-baked flatbread[1] found in the cuisines of West, Central and South Asia", Price=23.55M, MenuType= types.Single(g => g.Name == "Main Course"), FoodUrl="/Assets/images/naan.jpg" },
                new MenuItem {MenuName = "Chicken Kebab", description="Honey chicken kabobs with veggies. You can marinate overnight and make these kabobs for an outdoor barbecue as a tasty alternative to the usual barbecue fare!", Price=27.24M, MenuType= types.Single(g => g.Name == "Main Course"), FoodUrl="/Assets/images/kebab.jpg" },
                new MenuItem {MenuName = "Chicken Butter Masala", description="Easy creamy and delicious chicken masala in onion tomato gravy", Price=24.21M, MenuType= types.Single(g => g.Name == "Main Course"), FoodUrl="/Assets/images/chickenbuttermasala.jpg" },
                new MenuItem {MenuName = "Kulfi", description="Indian Matka kulfi with many flavours", Price=1.99M, MenuType = types.Single(g => g.Name == "Desserts"), FoodUrl= "/Assets/images/Matkakulfi.jpg" }

            }.ForEach(a => context.MenuItems.Add(a));
        }
    }
}