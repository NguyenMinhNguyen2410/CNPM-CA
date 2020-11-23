using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace CNPM.Models
{
    public class ChiTietHoaDonBan
    {
        [Key]
        [Column(TypeName = "int")]
        public int IDChiTietHoaDonBan{get; set;}

        [Column(TypeName = "char(5)")]
        public string IDHoaDon{get; set;}

        [Column(TypeName = "char(5)")]
        public string IDSanPham{get; set;}

        [Column(TypeName = "int")]
        public int SoLuong{get; set;}
    }
}