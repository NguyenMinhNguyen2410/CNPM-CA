using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
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
        // public void themThuongHieu(ThuongHieuDTO ThuongHieuDTO)
        // {
        //     _thuongHieuRepository.themThuongHieu(thuongHieuDTO.MappingThuongHieu());
        // }
        // public void suaThuongHieu(ThuongHieuDTO ThuongHieuDTO)
        // {
        //     _thuongHieuRepository.suaThuongHieu(thuongHieuDTO.MappingThuongHieu());
        // }
        // public void xoaThuongHieu(ThuongHieuDTO ThuongHieuDTO)
        // {
        //     _thuongHieuRepository.xoaThuongHieu(thuongHieuDTO.MappingThuongHieu());
        // }
    }
}
