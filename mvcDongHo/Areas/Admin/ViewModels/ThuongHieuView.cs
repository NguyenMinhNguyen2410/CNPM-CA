using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using mvcDongHo.Areas.Admin.ViewModels;
namespace mvcDongHo.Areas.Admin.ViewModels
{
    public class ThuongHieuView
    {
        public ThuongHieuDTO thuongHieuDTO { get; set; }
        //Hàm để tạo thành list kiểu ThuongHieuDTO
        public PaginatedList<ThuongHieuDTO> ThuongHieu { get; set; }
    }
}
