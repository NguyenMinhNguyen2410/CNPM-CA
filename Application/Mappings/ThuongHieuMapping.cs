using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections;
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

        public static IEnumerable<ThuongHieuDTO> MappingThuongHieuDTOList(this IEnumerable<ThuongHieu> thuongHieuS)
        {
            foreach (var thuongHieu in thuongHieuS)
            {
                yield return thuongHieu.MappingThuongHieuDTO();
            }
        }/// cái hàm này nè là e đang lấy dữ liệu từ entity lên r chuyển sang DTO là e thấy nó truyền dữ liệu lên là của entity tại a chưa hiểu cái yiel này lắm

        public static IEnumerable<ThuongHieuDTO> MappingThuongHieuDTO1(this IEnumerable<ThuongHieu> thuongHieuS)
        {
            List<ThuongHieuDTO> listreturn = new List<ThuongHieuDTO>(); 
            foreach (var thuongHieu in thuongHieuS)
            {
                var obnow = thuongHieu.MappingThuongHieuDTO();
                listreturn.Add(obnow);
            }
            return listreturn;
        }
    }
}
