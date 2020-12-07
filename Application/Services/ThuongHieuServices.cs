using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    
    public class ThuongHieuServices : IThuongHieuServices
    {
        private readonly IThuongHieuRepository _ThuongHieuRepository;//Tạo biến chứa dữ liệu 
        public ThuongHieuServices(IThuongHieuRepository ThuongHieuRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _ThuongHieuRepository = ThuongHieuRepository;
        }

        public IEnumerable<ThuongHieuDTO> getAll()//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
           return _ThuongHieuRepository.getAll().MappingThuongHieuDTO1();
        }

        public ThuongHieuDTO GetThuongHieu(string maThuongHieu)
        {
           return  _ThuongHieuRepository.GetThuongHieu(maThuongHieu).MappingThuongHieuDTO();

        }

        public void suaThuongHieu(ThuongHieuDTO thuongHieuDTO)
        {
            _ThuongHieuRepository.SuaThuongHieu(thuongHieuDTO.MappingThuongHieu());
        }

        public void themThuongHieu(ThuongHieuDTO thuongHieuDTO)
        {
            _ThuongHieuRepository.ThemThuongHieu(thuongHieuDTO.MappingThuongHieu());
        }


        public void xoaThuongHieu(string maThuongHieu)
        {
            _ThuongHieuRepository.XoaThuongHieu(maThuongHieu);
        }

    }
}
