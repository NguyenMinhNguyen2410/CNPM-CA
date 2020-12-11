using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITaiKhoanKHServices
    {
       bool login(string taiKhoan, string matKhau);
        public IEnumerable<TaiKhoanKHDTO> getAll();
        public TaiKhoanKHDTO TimTK(string TaiKhoan, string MatKhau, string IDKhachHang);
        public void ThemTK(TaiKhoanKHDTO taiKhoanKHDTO);
    }
}
