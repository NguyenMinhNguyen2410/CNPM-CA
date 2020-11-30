using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class ThuongHieuMapping
    {
        public static ThuongHieuDTO MappingThuongHieuDTO(this ThuongHieu thuongHieu)//Tên biết viết đầu là chữ thường để phân biệt với kiểu dữ liệu 
        {
            return new ThuongHieuDTO
            {
                IDThuongHieu=thuongHieu.IDThuongHieu,
                TenThuongHieu=thuongHieu.TenThuongHieu
            };
        }

        public static ThuongHieu MappingThuongHieu(this ThuongHieuDTO thuongHieuDTO)
        {
            return new ThuongHieu
            {
                IDThuongHieu=thuongHieuDTO.IDThuongHieu,
                TenThuongHieu=thuongHieuDTO.TenThuongHieu
            };
        }
    }
}
