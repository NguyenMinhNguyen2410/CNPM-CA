using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IThuongHieuServices
    {
        public void themThuongHieu(ThuongHieuDTO thuongHieu);

        public void suaThuongHieu(ThuongHieuDTO thuongHieu);

        public void xoaThuongHieu(string maThuongHieu);

        public ThuongHieuDTO GetThuongHieu(string maThuongHieu);
        IEnumerable<ThuongHieuDTO> getAll();
    }
}
