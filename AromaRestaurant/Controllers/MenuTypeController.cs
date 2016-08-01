using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AromaRestaurant.Models;


namespace AromaRestaurant.Controllers
{

    public class MenuTypeController : Controller
    {

        private AromaModel menuDB = new AromaModel();
        // GET: AromaRestaurant
        public ActionResult Index()
        {
            List<MenuType> types = menuDB.MenuTypes.ToList();
            return View(types);
        }

        public ActionResult Browse(string MenuType)
        {
            MenuType MenuTypeModel = menuDB.MenuTypes.Include("MenuItems").Single(g => g.Name == MenuType);
            return View(MenuTypeModel);
        }
        public ActionResult Details(int id = 1)
        {
            MenuItem MenuItem = menuDB.MenuItems.Find(id);
            return View(MenuItem);
        }
    }
}