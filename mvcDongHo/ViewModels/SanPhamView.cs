using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using mvcDongHo.ViewModels;
namespace mvcDongHo.ViewModels
{
    public class SanPhamView
    {
        public SanPhamDTO sanPhamDTO { get; set; }
        //Hàm để tạo thành list kiểu ThuongHieuDTO
        public PaginatedList<SanPhamDTO> SanPham { get; set; }
    }
}
