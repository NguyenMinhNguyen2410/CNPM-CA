using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    
    public class ThuongHieuServices : IThuongHieuServices
    {
        private readonly IThuongHieuRepository _ThuongHieuRepository;//Tạo biến chứa dữ liệu 
        public ThuongHieuServices(IThuongHieuRepository ThuongHieuRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _ThuongHieuRepository = ThuongHieuRepository;
        }
    }
}
