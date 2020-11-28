using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ISanPhamRepository
    {
        IEnumerable<SanPham> getAll();

        void themSanPham(SanPham sanPham);
    }
}
