using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Data.Models
{
    public class SanPham
    {
        // Thuộc tính
        public Guid Id { get; set; }
        [StringLength(20, ErrorMessage = "Tên không quá 20 kí tự")] // ĐỘ dài max là 20
        public string Ten { get; set; }
        [StringLength(100, ErrorMessage = "Mô tả quá dài")]
        public string Mota { get; set; }
        [Range(0, 1000000, ErrorMessage = "Giá phải nằm trong khoảng 0 đến 1 triệu đồng")]
        public long Gia { get; set; }
        [Required(ErrorMessage = "Bắt buộc phải nhập số lượng")]
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
        public string HangSX { get; set; }
        // Navigation
        public virtual List<HDCT> HDCTs { get; set; }
        // Data Anotation Validation - Validate dữ liệu
    }
}
