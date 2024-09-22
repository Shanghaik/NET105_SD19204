using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Data.Models
{
    public class HoaDon
    {
        public Guid ID { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public long TongTien { get; set; }
        public int TrangThai { get; set; }
        // Navigation
        public virtual List<HDCT> HDCTs { get; set; }
    }
}
