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


    }
}
