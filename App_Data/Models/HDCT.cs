using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Data.Models
{
    public class HDCT
    {
        public Guid Id { get; set; }
        public Guid IDSP { get; set; }
        public Guid IDHD { get; set; }
        public int SoLuong { get; set; }
        public long DonGia { get; set; }
        public int TrangThai { get; set; }
        // Navigation
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
