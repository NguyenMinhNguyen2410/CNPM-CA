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
    public class QuanLiSanPhamController : Controller
    {
        private readonly ISanPhamServices _sanPhamServices;
        public QuanLiSanPhamController (ISanPhamServices sanPhamServices)
        {
            _sanPhamServices = sanPhamServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ThemSanPham()
        {
            return View(nameof(ThemSanPham));
        }
        public IActionResult ThemSanPham(SanPhamView sanPhamView)
        {
            if(ModelState.IsValid)//kiểm tra dữ liệu đã được post đúng hay chưa
            {   
                _sanPhamServices.themSanPham(sanPhamView.sanPhamDTO);
                return View(nameof(Index));//return view là trả về view nhưng không chạy những gì trong đó
                                            //còn redirecttoaction là thực hiện trong index rồi mới trả về view
            }
            ViewBag.Error = "Thêm sản phẩm thất bại";
            return View(nameof(Index));
        }
    }
}
