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
        public static TaiKhoanKHDTO MappingTaiKhoanDTO(this TaiKhoanKH taiKhoan)
        {
            return new TaiKhoanKHDTO
            {
                TaiKhoan = taiKhoan.TaiKhoan,
                MatKhau = taiKhoan.MatKhau,
                IDKhachHang = taiKhoan.IDKhachHang
            };
        }
        public static TaiKhoanKH MappingTaiKhoan(this TaiKhoanKHDTO taiKhoanDTO)
        {
            return new TaiKhoanKH
            {
                TaiKhoan = taiKhoanDTO.TaiKhoan,
                MatKhau = taiKhoanDTO.MatKhau,
                IDKhachHang = taiKhoanDTO.IDKhachHang
            };
        }
        public static IEnumerable<TaiKhoanKHDTO> MappingTaiKhoanDTOList(this IEnumerable<TaiKhoanKH> taiKhoanKHs)
        {
            foreach (var sp in taiKhoanKHs)
            {
                yield return sp.MappingTaiKhoanDTO();
            }
        }// cái hàm này nè là đang lấy dữ liệu từ entity lên r chuyển sang DTO 
        public static IEnumerable<TaiKhoanKHDTO> MappingTaiKhoanDTO1(this IEnumerable<TaiKhoanKH> taiKhoanKHs)
        {
            List<TaiKhoanKHDTO> listreturn = new List<TaiKhoanKHDTO>();
            foreach (var sp in taiKhoanKHs)
            {
                var obnow = sp.MappingTaiKhoanDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }

    }
}
