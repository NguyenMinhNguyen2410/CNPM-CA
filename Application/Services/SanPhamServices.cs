using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    
    public class SanPhamServices : ISanPhamServices
    {
        private readonly ISanPhamRepository _sanPhamRepository;
        public SanPhamServices(ISanPhamRepository sanPhamRepository)
        {
            _sanPhamRepository = sanPhamRepository;
        }
        public void themSanPham(SanPhamDTO sanPhamDTO)
        {
            _sanPhamRepository.themSanPham(sanPhamDTO.MappingSanPham());
        }
        public void suaSanPham(SanPhamDTO sanPhamDTO)
        {
            _sanPhamRepository.suaSanPham(sanPhamDTO.MappingSanPham());
        }
        public void xoaSanPham(SanPhamDTO sanPhamDTO)
        {
            _sanPhamRepository.xoaSanPham(sanPhamDTO.MappingSanPham());
        }
        public IEnumerable<SanPhamDTO> getAll(int pageIndex, int pageSize, out int count)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _sanPhamRepository.getAll(pageIndex, pageSize, out count).MappingSanPhamDTO1();
        }
        public IEnumerable<SanPhamDTO> get4sp(int boqua)//gọi hàm bên mapping để chuyển dữ liệu mấy hàm kia y chang, khó hiểu nhưng dễ viết
        {
            return _sanPhamRepository.get4sp(boqua).MappingSanPhamDTO1();
        }
        public SanPhamDTO Xemsp(string maSanPham)
        {
            return _sanPhamRepository.Xemsp(maSanPham).MappingSanPhamDTO();

        }
    }
}
