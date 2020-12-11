using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISanPhamRepository
    {
        IEnumerable<SanPham> getAll(int pageIndex, int pageSize, out int count);
        public IEnumerable<SanPham> get4sp(int boqua);
        void themSanPham(SanPham sanPham);
        void suaSanPham(SanPham sanPham);
        void xoaSanPham(SanPham sanPham);
        public SanPham Xemsp(string maSanPham);
    }
}
