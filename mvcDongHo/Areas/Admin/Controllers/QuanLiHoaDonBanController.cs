using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcDongHo.Areas.Admin.ViewModels;

namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class QuanLiHoaDonBanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HoaDonBan()
        {
            return View();
        }
    }
}
