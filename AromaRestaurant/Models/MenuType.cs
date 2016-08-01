using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//    -File Name: MenuType.cs
//    - Author's Name: Akhil Thakkar(200300312) and Gurpanth Singh(200299024)
//    - Website Name: aromarestaurant.azurewebsites.net
//    - Full Description: This Model file initializes the Menu 
//        Type with all the fields included in it.
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