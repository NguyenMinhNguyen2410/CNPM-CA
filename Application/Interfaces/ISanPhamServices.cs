using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISanPhamServices
    {
        public void themSanPham(SanPhamDTO sanPham);
        public void suaSanPham(SanPhamDTO sanPham);
        public void xoaSanPham(SanPhamDTO sanPham);
        IEnumerable<SanPhamDTO> getAll(int pageIndex, int pageSize,string textSearch, out int count);
        IEnumerable<SanPhamDTO> getAll();
        public IEnumerable<SanPhamDTO> get4sp(int boqua);
        public SanPhamDTO Xemsp(string maSanPham);
    }
}
