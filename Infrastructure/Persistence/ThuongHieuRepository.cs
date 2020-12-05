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
        //Viết chức năng ở đây, xem mẫu ở SanPhamRepository.cs
        public void themThuongHieu(ThuongHieu thuongHieu)
        {
            _conText.thuongHieu.Add(thuongHieu);//gọi biến thuongHieu ở donghocontext thêm vào database
            _conText.SaveChanges();//lưu lại thay đổi
        }

        // public IEnumerable<ThuongHieu> getAll()
        // {
        //     var listThuongHieu = _conText.ThuongHieu.ToList();
        //     return listThuongHieu;
        // }
        // public void suaThuongHieu(ThuongHieu thuongHieu)
        // {
        //     _conText.ThuongHieu.Add(thuongHieu);//gọi biến thuongHieu ở donghocontext thêm vào database
        //     _conText.SaveChanges();//lưu lại thay đổi
        // }
        // public void xoaThuongHieu(ThuongHieu thuongHieu)
        // {
        //     _conText.ThuongHieu.Add(thuongHieu);//gọi biến thuongHieu ở donghocontext thêm vào database
        //     _conText.SaveChanges();//lưu lại thay đổi
        // }
    }
}
