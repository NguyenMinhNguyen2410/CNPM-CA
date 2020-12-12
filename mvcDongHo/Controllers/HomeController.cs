using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.DTOs;
using mvcDongHo.ViewModels;
namespace mvcDongHo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISanPhamServices _sanPhamServices;//khai báo services
        private readonly IThuongHieuServices _thuongHieuServices;//khai báo services
        private int pageSize = 9;//Số lượng thương hiệu trong 1 trang
        public HomeController(ISanPhamServices sanPhamServices,IThuongHieuServices thuongHieuServices) //contructor
        {
            _sanPhamServices = sanPhamServices;
            _thuongHieuServices=thuongHieuServices;
        }
        
        public ActionResult Index()
        {
            var list = _sanPhamServices.get4sp(12);//hàm lấy tất cả các đối tượng ở dưới database để show thông tin sản phẩm lên
            ViewBag.List = list;
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
        public ActionResult Contactus()
        {
            return View();
        }
        public ActionResult MyAccout()
        {
            return View();
        }
   
        public ActionResult Shop(int pageIndex = 1,string textSearch="",string type="",bool price=true)
        {
            int count;//Tổng số lượng thương hiệu
           
            var list = _sanPhamServices.getAll(pageIndex, pageSize,textSearch,type,price, out count);//Hàm này lấy thương hiệu lên theo số trang , số lượng thương hiệu 1 trang , gắn lại tổng sản phẩm vào bién count
            var indexVM = new SanPhamView
            {
                SanPham = new PaginatedList<SanPhamDTO>(list, count, pageIndex, pageSize),
                textSearch=textSearch,
                type=type,
                price=price,
                ThuongHieu= _thuongHieuServices.getAll()
            };
            //Trả về view + biến indexVM đang giữ list thương hiệu
            return View(indexVM);
            
        }
        public ActionResult Shopdetail(string id)
        {
            ViewBag.Xemsp = _sanPhamServices.Xemsp(id);//gọi hàm lấy một đối tượng thương hiệu bên services và gán cho viewbag
            return View();
        }
        public ActionResult Wishlist()
        {
            return View();
        }
        // [HttpGet]
        // public JsonResult Search(string textSearch){
        //     var list=_sanPhamServices.getAll();
        //     var content = list.Where(i=>i.TenSanPham.Contains(textSearch)).ToList();
        //     return Json(content);
        // }
    }
}
