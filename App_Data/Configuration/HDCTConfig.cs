using App_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App_Data.Configuration
{
    public class HDCTConfig : IEntityTypeConfiguration<HDCT>
    {
        public void Configure(EntityTypeBuilder<HDCT> builder)
        {
            // Khóa chính
            builder.HasKey(x => x.Id); // Cái này đúng
            // * Khóa composite (Nhiều cột) với anonymous type
            // builder.HasKey(x => new { x.IDSP, x.IDHD });
            // Set thuộc tính là Unique cái này chỉ thử thôi
            // builder.HasAlternateKey(p => p.IDHD);
            // Xác định khóa ngoại
            builder.HasOne(p => p.HoaDon).WithMany(p => p.HDCTs).HasForeignKey(p => p.IDHD).
                HasConstraintName("FK_HDCT_HD");
            builder.HasOne(p => p.SanPham).WithMany(p => p.HDCTs).HasForeignKey(p => p.IDSP).
                HasConstraintName("FK_HDCT_SP");
            // Với mỗi Hóa đơn ta liên với nhiều HDCT với khóa ngoại là cột IDHD có tên là:...
        }
    }
}
