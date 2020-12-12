using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface INhaCungCapServices
    {
        public void themNhaCungCap(NhaCungCapDTO nhaCungCap);

        public void suaNhaCungCap(NhaCungCapDTO nhaCungCap);

        public void xoaNhaCungCap(string maNhaCungCap);

        public NhaCungCapDTO GetNhaCungCap(string maNhaCungCap);

        IEnumerable<NhaCungCapDTO> getAll(int pageIndex, int pageSize, out int count);
    }
}
