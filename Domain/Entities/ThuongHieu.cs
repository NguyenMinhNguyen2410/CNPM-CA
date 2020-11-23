using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace CNPM.Models
{
    public class ThuongHieu
    {
        [Key]
        [Column(TypeName = "char(5)")]
        public string IDThuongHieu{get; set;}

        [Column(TypeName = "nvarchar(50)")]
        public string TenThuongHieu{get; set;}
    }
}