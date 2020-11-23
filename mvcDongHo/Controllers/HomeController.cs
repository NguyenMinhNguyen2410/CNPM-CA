using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mvcDongHo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Contactus()
        {
            return View();
        }
        public ActionResult MyAccout()
        {
            return View();
        }
   
        public ActionResult Shop()
        {
            return View();
        }
        public ActionResult Shopdetail()
        {
            return View();
        }
        public ActionResult Wishlist()
        {
            return View();
        }
    }
}
