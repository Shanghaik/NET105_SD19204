using App_Data.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        AppDbContext _context = new AppDbContext();
        // GET: api/<SanPhamController>
        [HttpGet("get-all-san-pham")]
        public IEnumerable<SanPham> GetAll() // IEnumerable - List
        {
            return _context.SanPhams.ToList();
        }
        // GET api/<SanPhamController>/5
        [HttpGet("get-by-id")]
        public SanPham GetById(Guid id)
        {
            return _context.SanPhams.Find(id); // Find chỉ dùng cho khóa chính
            return _context.SanPhams.FirstOrDefault(x => x.Id == id);
            return _context.SanPhams.SingleOrDefault(x => x.Id == id);
            // Find chỉ dùng cho khóa chính
            // FirtOrDefault: Trả về đối tượng đầu tiên trong DbSet thỏa mãn đk hoặc null
            // Nếu có nhiều đối tượng thỏa mãn => Lấy cái đầu tiên
            // SingleOrDefault: Trả về đối tượng duy nhất thỏa mãn DK hoặc null
            // Nếu có nhiều đối tượng thỏa mãn => Trả ra 1 exception
        }

        // POST api/<SanPhamController>
        [HttpPost("post-by-param")]
        public ActionResult PostByParam(string ten, string mota, long gia, int soluong, int trangthai, string hangsx)
        {
            SanPham sp = new SanPham() // Tạo đối tượng dựa vào các tham số
            {
                Id = Guid.NewGuid(),
                Ten = ten,
                Mota = mota,
                Gia = gia,
                SoLuong = soluong,
                TrangThai = trangthai,
                HangSX = hangsx
            };
            try
            {
                _context.SanPhams.Add(sp);
                _context.SaveChanges();
                return Ok(sp);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }
        [HttpPost("post-by-object")]
        public ActionResult PostByObject(SanPham sp)
        {
            try
            {
                _context.SanPhams.Add(sp);
                _context.SaveChanges();
                return Ok(sp);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }

        // PUT api/<SanPhamController>/5
        [HttpPut("put-san-pham")]
        public ActionResult Put(Guid id, string mota, long gia, int soluong, int trangthai)
        {
            // Lấy ra đối tượng cần sửa thai Id
            SanPham editItem = _context.SanPhams.Find(id);
            editItem.Mota = mota; editItem.Gia = gia; editItem.SoLuong = soluong; editItem.TrangThai = trangthai;
            _context.SanPhams.Update(editItem);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/<SanPhamController>/5
        [HttpDelete("delete-by-id")]
        public ActionResult Delete(Guid id)
        {
            SanPham deleteItem = _context.SanPhams.Find(id);
            _context.SanPhams.Remove(deleteItem);
            _context.SaveChanges();
            return Ok();
        }
        // 7 Phương thức
        /*
         * GetAll() 
         * GetById(Guid id)
         * PostByParam(7 thuộc tính)
         * PostByObject(SanPham sp)
         * Put(Guid id, string mota, long gia, int soluong, int trangthai)
         * Delete(Guid id)
         */
    }
}
