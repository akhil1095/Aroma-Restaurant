using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AromaRestaurant.Models;

namespace AromaRestaurant.Controllers
{
    public class MenuController : Controller
    {
        //AromaModel menuDB = new AromaModel();
        private AromaModel db = new AromaModel();

        public ActionResult Index()
        {
            //var MenuItem = db.MenuItems.Include(a => a.MenuType);
            return View(/*MenuItem.ToList()*/);
        }
    }
}