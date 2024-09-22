using App_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Data.Configuration
{
    public class HoaDonConfig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            // Cấu hình Khóa chính của bảng
            builder.HasKey(p => p.ID);
            // (Có thể làm)
            // Cấu hình tên cột/tên bảng
            // builder.ToTable("Bill");
            builder.Property(p => p.NgayTao).HasColumnName("CreateDate");// Tên cột
            // Xác định kiểu dữ liệu (Để bảng sau)
        }
    }
}
