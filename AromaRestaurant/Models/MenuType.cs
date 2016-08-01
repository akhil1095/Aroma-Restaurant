using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AromaRestaurant.Models
{
    public class MenuType
    {
        public MenuType()
        {

        }

        public MenuType(string Name)
        {
            this.Name = Name;
        }
        public virtual string Name { get; set; }
        public virtual int MenuTypeId { get; set; }
        public virtual List<MenuItem> MenuItems { get; set; }

    }
}