using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcDongHo.Areas.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuanLiThuongHieuController : Controller
    {
        private readonly IThuongHieuServices _thuongHieuServices;

        public QuanLiThuongHieuController(IThuongHieuServices thuongHieuServices)
        {
            _thuongHieuServices = thuongHieuServices;
        }
        public IActionResult Index()
        {
            var list = _thuongHieuServices.getAll();// ấn bên đó là khi nó chạy qua sẽ dừng lại cho e , e xem trong console để theo dõi dữ liệu đang chạy
            ViewBag.List = list;
            return View();
        }

        public IActionResult ThemThuongHieu()
        { 
            return View();
        }

        public IActionResult ThemThuongHieuData(ThuongHieuView thuongHieuView)
        {
            ViewBag.Error = "Thêm thành công";
            if(ModelState.IsValid)
            {
                _thuongHieuServices.themThuongHieu(thuongHieuView.thuongHieuDTO);
                return View(nameof(ThemThuongHieu));
            }
            ViewBag.Error = "Thêm thất bại";
            return View(nameof(ThemThuongHieu));
        }

        public IActionResult SuaThuongHieuData(ThuongHieuView thuongHieuView)
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)
            {
                _thuongHieuServices.suaThuongHieu(thuongHieuView.thuongHieuDTO);
                return View();
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaThuongHieu(string maThuongHieu)
        {
            var tH = _thuongHieuServices.GetThuongHieu(maThuongHieu);
            return View(tH);
        }

        public IActionResult XoaThuongHieu(string maThuongHieu)
        {
            if(ModelState.IsValid)
            {
                _thuongHieuServices.xoaThuongHieu(maThuongHieu);
                return View(nameof(Index));
            }
            return View(nameof(Index));
        }
    }
}
