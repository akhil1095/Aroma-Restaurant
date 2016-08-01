using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AromaRestaurant.Models
{
    public class MenuItem
    {
        public MenuItem()
        {

        }

        public MenuItem(string MenuName)
        {
            this.MenuName = MenuName;
        }
        [Display(Name = "Menu Item")]
        public virtual int MenuItemId { get; set; }
        public virtual int MenuTypeId { get; set; }
        public virtual MenuType MenuType { get; set; }
        [Display(Name = "Menu Type")]
        public virtual string MenuName { get; set; }
        public virtual string description { get; set; }
        public virtual decimal Price { get; set; }
        [Display(Name = "Food Url")]
        public virtual string FoodUrl { get; set; }

    }
}