using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ThuongHieuRepository : IThuongHieuRepository //kế thừa interface, từ Domain/Interfaces
    {
        private readonly DongHoContext _conText;//Khởi tạo biến context
        public ThuongHieuRepository(DongHoContext conText)//contructor để gán giá trị database cho biến context
        {
            this._conText = conText;
        }

        public IEnumerable<ThuongHieu> getAll()
        {
            var list = _conText.thuongHieu.ToList();
            return list;
        }

        public ThuongHieu GetThuongHieu(string maThuongHieu)
        {
            return _conText.thuongHieu.Find(maThuongHieu); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }

        public void SuaThuongHieu(ThuongHieu thuongHieu)//hàm sửa vào database
        {
            _conText.thuongHieu.Update(thuongHieu);
            _conText.SaveChanges();
        }

        public void ThemThuongHieu(ThuongHieu thuongHieu)//hàm thêm vào database
        {
            _conText.thuongHieu.Add(thuongHieu);
            _conText.SaveChanges();
        }

        public void XoaThuongHieu(string maThuongHieu)//xóa một đối tượng ở database
        {
            
            var thuongHieuDaTimThay = _conText.thuongHieu.Find(maThuongHieu);
            _conText.thuongHieu.Remove(thuongHieuDaTimThay);
            _conText.SaveChanges();

        }
    }
}
