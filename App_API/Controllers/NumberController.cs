using Microsoft.AspNetCore.Mvc;

namespace App_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberController : ControllerBase
    {
        [HttpGet("get-second-number")] // Trả về số lớn thứ 2 trong 3 số a,b,c
        public IActionResult GetSecondNumber(int a, int b, int c)
        {
            int max2 = (a - b) * (a - c) <= 0 ? a : (b - a) * (b - c) <= 0 ? b : c;
            // Duy nhất số lớn thứ 2 trừ đi 2 số còn lại sẽ thu được 2 kết quả trái dấu
            // Phép nhân 2 kết kết quả đó => Số âm
            // Còn số lớn nhất hay nhỏ nhất trừ đi 2 số còn lại sẽ ra 2 kết quả cùng dấu
            // Phép nhân 2 kết quả đó => dương
            // Toán tử 3 ngôi được dùng theo cú pháp như sau
            // vd: a = x > y ? 10 : 15; thì được hiểu là a sẽ = 10 nếu x > y, còn không thì a = 15
            return Ok(max2);
        }
        [HttpGet]
        [Route("check-number")] // Kiểm tra 1 số có phải số chính phương hay không
        public IActionResult CheckNumber(int x)
        {
            bool check = false;
            //for (int i = 0; i < x; i++)
            //{
            //    if (i * i < x) continue;
            //    else if (i * i == x) { check = true; break; }
            //    else if (i * i > x) break;
            //}
            if (Math.Round(Math.Sqrt(x), 0) == Math.Sqrt(x)) check = true;
            return Ok(check + " " + Math.Round(Math.Sqrt(x), 0) + " " + Math.Sqrt(x));
            // Một số chính phương khi lấy căn bậc 2 sẽ là 1 số nguyên
            // Nếu không phải số nguyên thì phép làm tròn của căn bậc 2 chắc chắc sẽ không = chính nó
        }
        // Lưu ý với API controller
        /*
         * Phải kế thừa ControllerBase
         * Các phương thức phải có mô tả về HttpMethod
         * Một Api controller sẽ chỉ có 1 phương thức duy nhất cho 1 method nếu chúng
         * không được đặt route cho nên chúng ta nên đặt route cho mỗi phương thức
         * Get thường dùng để mô tả 1 phương thức dùng để lấy dữ liệu
         * Post thường dùng để mô tả 1 phương thức dùng tạo mới dữ liệu
         * Put thường dùng để mô tả 1 phương thức dùng sửa dữ liệu
         * Delete thường dùng để mô tả 1 phương thức dùng xóa dữ liệu
         * Dữ liệu trả về response body thường được biểu thị ở dạng json
         * requestURL là thông tin quan trọng nhất để trỏ tới một API cụ thể
         * API: Application Program Interface là 1 phương pháp để có thể sử dụng chung
         * các phương thức cho nhiều loại ứng dụng thông qua URL.
         */
        // BTVN:
        // Viết 1 API controller chứa 2 phương thức
        // 1. Tính BMI(double height, double weight) để tính chỉ số BMI của ai đó
        // 2. Nhập vào 3 cạnh của 1 tam giác và xác định nó là tam giác gì?
    }
}
