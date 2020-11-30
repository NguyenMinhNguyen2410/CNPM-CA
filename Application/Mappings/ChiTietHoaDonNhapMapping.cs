using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class ChiTietHoaDonNhapMapping
    {
        public static ChiTietHoaDonNhapDTO MappingChiTietHoaDonNhapDTO(this ChiTietHoaDonNhap chiTietHoaDonNhap)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new ChiTietHoaDonNhapDTO
            {
                IDChiTietHoaDonNhap=chiTietHoaDonNhap.IDChiTietHoaDonNhap,
                IDHoaDonNhap=chiTietHoaDonNhap.IDHoaDonNhap,
                IDSanPham=chiTietHoaDonNhap.IDSanPham,
                SoLuong=chiTietHoaDonNhap.SoLuong
            };
        }

        public static ChiTietHoaDonNhap MappingChiTietHoaDonNhap(this ChiTietHoaDonNhapDTO chiTietHoaDonNhapDTO)
        {
            return new ChiTietHoaDonNhap
            {
                IDChiTietHoaDonNhap=chiTietHoaDonNhapDTO.IDChiTietHoaDonNhap,
                IDHoaDonNhap=chiTietHoaDonNhapDTO.IDHoaDonNhap,
                IDSanPham=chiTietHoaDonNhapDTO.IDSanPham,
                SoLuong=chiTietHoaDonNhapDTO.SoLuong
            };
        }
    }
}
