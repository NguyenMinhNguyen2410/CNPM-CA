using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mvcDongHo.Areas.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcDongHo.Areas.Admin.Controllers
{
    [Area("Admin")] //để nó hiểu được những class trong Admin
    public class QuanLiThuongHieuController : Controller
    {
        private readonly IThuongHieuServices _thuongHieuServices;//khai báo services

        public QuanLiThuongHieuController(IThuongHieuServices thuongHieuServices) //contructor
        {
            _thuongHieuServices = thuongHieuServices;
        }
        public IActionResult Index()
        {
            var list = _thuongHieuServices.getAll();//hàm lấy tất cả các đối tượng ở dưới database để show thông tin sản phẩm lên
            ViewBag.List = list;//lưu danh sách vừa lấy được vào viewbag đê show ra bên index
            return View();
        }

        public IActionResult ThemThuongHieu()
        { 
            return View();
        }
        public IActionResult ThemThuongHieuData(ThuongHieuView thuongHieuView)//thêm đối tượng xuống database
        {
            ViewBag.Error = "1";
            if(ModelState.IsValid)
            {
                _thuongHieuServices.themThuongHieu(thuongHieuView.thuongHieuDTO);
                ViewBag.Success = "Đã thêm thành công";
                return Redirect(nameof(ThemThuongHieu));
            }
            ViewBag.Error = "0";
            return View(nameof(ThemThuongHieu));
        }

        public IActionResult SuaThuongHieuData(ThuongHieuView thuongHieuView)//Cập nhật một đối tượng xuống database
        {
            ViewBag.Error = "Cập nhật thành công";
            if (ModelState.IsValid)//kiểm tra xem đã có dữ liệu truyền trên url hay chưa
            {
                _thuongHieuServices.suaThuongHieu(thuongHieuView.thuongHieuDTO);//gọi hàm sửa ở services
                Index();//cập nhật xong load lại trang index
                return View(nameof(Index));//quay về trang index
            }
            ViewBag.Error = "Cập nhật thất bại";
            return View();
        }

        public IActionResult SuaThuongHieu(string id)//truyền mã vào để sửa, mục đích là để khi bấm nút sửa dựa vào mã ở
            //giao diện QuanLiThuongHieu/Index truy xuất xuống services/reponsitory để lấy đối tượng thương hiệu lên và gán dữ liệu cho trang SuaThuongHieu
        {
            ViewBag.SuaThuongHieu = _thuongHieuServices.GetThuongHieu(id);//gọi hàm lấy một đối tượng thương hiệu bên services và gán cho viewbag
            return View();
        }

        public IActionResult XoaThuongHieuData(string id) //truyền mã vào để xóa một đối tượng
        {
            _thuongHieuServices.xoaThuongHieu(id);//gọi hàm xóa bên services
            Index();//chạy lại hàm index và các dòng trong index, mục đích là để xóa xong nó load lại trang luôn
            return View(nameof(Index)); // trả về view
        }
    }
}
