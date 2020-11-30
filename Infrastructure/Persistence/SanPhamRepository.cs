using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class SanPhamRepository : ISanPhamRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public SanPhamRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
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
