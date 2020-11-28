using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class TaiKhoanKHMapping
    {
        public static TaiKhoanKHDTO MappingDTO(this TaiKhoanKH taiKhoan)
        {
            return new TaiKhoanKHDTO
            {
                TaiKhoan = taiKhoan.TaiKhoan,
                MatKhau = taiKhoan.MatKhau,
                IDKhachHang = taiKhoan.IDKhachHang
            };
        }

    }
}
