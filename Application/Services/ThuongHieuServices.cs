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
        private readonly IThuongHieuRepository _thuongHieuRepository;//Tạo biến chứa dữ liệu 
        public ThuongHieuServices(IThuongHieuRepository thuongHieuRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _thuongHieuRepository = thuongHieuRepository;
        }


        public IEnumerable<ThuongHieuDTO> getAll()
        {
           return _thuongHieuRepository.getAll().MappingThuongHieuDTO1();
        }

        public ThuongHieuDTO GetThuongHieu(string maThuongHieu)
        {
           return  _thuongHieuRepository.GetThuongHieu(maThuongHieu).MappingThuongHieuDTO();

        }
        //ủa đúng rồi m
        //em thấy nó đúng rồi mà ta

        public void suaThuongHieu(ThuongHieuDTO thuongHieuDTO)
        {
            _thuongHieuRepository.SuaThuongHieu(thuongHieuDTO.MappingThuongHieu());
        }

        public void themThuongHieu(ThuongHieuDTO thuongHieuDTO)
        {
            _thuongHieuRepository.ThemThuongHieu(thuongHieuDTO.MappingThuongHieu());
        }


        public void xoaThuongHieu(string maThuongHieu)
        {
            _thuongHieuRepository.XoaThuongHieu(maThuongHieu);
        }
    }
}
