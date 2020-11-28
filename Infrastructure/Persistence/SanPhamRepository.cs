using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private readonly DongHoContext _conText;
        public SanPhamRepository(DongHoContext conText)
        {
            this._conText = conText;
        }
        public void themSanPham(SanPham sanPham)
        {
            _conText.sanPham.Add(sanPham);//gọi biến sanPham ở donghocontext thêm vào database
            _conText.SaveChanges();//lưu lại thay đổi
        }

        public IEnumerable<SanPham> getAll()
        {
            var listSanPham = _conText.sanPham.ToList();
            return listSanPham;
        }
    }
}
