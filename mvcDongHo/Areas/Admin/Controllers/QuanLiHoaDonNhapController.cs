using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuanLiHoaDonNhapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HoaDonNhap()
        {
            return View();
        }
    }
}
