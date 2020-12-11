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
    
    public class ChiTietHoaDonBanServices : IChiTietHoaDonBanServices
    {
        private readonly IChiTietHoaDonBanRepository _chiTietHoaDonBanRepository;//Tạo biến chứa dữ liệu 
        public ChiTietHoaDonBanServices(IChiTietHoaDonBanRepository chiTietHoaDonBanRepository)//constructor để gán dữ liệu vào biến, chi tiết xem thêm ở SanPhamServices.cs
        {
            _chiTietHoaDonBanRepository = chiTietHoaDonBanRepository;
        }
    }
}
