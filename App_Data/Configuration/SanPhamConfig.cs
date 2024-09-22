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
    public class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            // Khóa chính
            builder.HasKey(x => x.Id);
            // Cấu hình cột
            builder.Property(p => p.HangSX).HasColumnType("nvarchar(50)");
            //builder.Property(p => p.HangSX).HasMaxLength(50).IsFixedLength(true)
            //    .IsUnicode(true); 
            // 2 câu lệnh trên cho kết quả như nhau

        }
    }
}
