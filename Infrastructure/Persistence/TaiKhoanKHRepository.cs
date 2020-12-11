using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class TaiKhoanKHRepository : ITaiKhoanKHRepository
    {
        private readonly DongHoContext _conText;

        public TaiKhoanKHRepository(DongHoContext conText)
        {
            this._conText = conText;
        }

        public IEnumerable<TaiKhoanKH> getAll()
        {
            var listTaiKhoan = _conText.taiKhoanKH.ToList();
            return listTaiKhoan;
        }
        public TaiKhoanKH TimTK(string TaiKhoan, string MatKhau, string IDKhachHang)
        {

            return _conText.taiKhoanKH.Find(TaiKhoan,MatKhau,IDKhachHang); //tìm đối tượng dựa trên mã xong trả về đối tượng tương ứng
        }
        public void ThemTK(TaiKhoanKH taiKhoanKH)//hàm thêm vào database
        {
            _conText.taiKhoanKH.Add(taiKhoanKH);
            _conText.SaveChanges();
        }

    }
}
