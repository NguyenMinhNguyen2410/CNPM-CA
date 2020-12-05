using Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuanLiLoaiDayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ThemLoaiDay()
        {
            return View();
        }
        public IActionResult SuaLoaiDay()
        {
            return View();
        }
        public IActionResult SuaLoaiDayData(LoaiDayDTO loaiDayDTO)
        {
            return View(nameof(Index));
        }
    }
}
