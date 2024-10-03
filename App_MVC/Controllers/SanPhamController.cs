using App_Data.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace App_MVC.Controllers
{
    public class SanPhamController : Controller
    {
        // Tạo ra 1 HttpClient để đọc dữ liệu => lấy ra responseBody
        HttpClient client = new HttpClient();
        public SanPhamController()
        {
        }
        public IActionResult Index() // Get All SanPham
        {
            string requestURL = @$"https://localhost:7207/SanPham/get-all-san-pham";
            var responseBody = client.GetStringAsync(requestURL).Result; // Chuỗi Json
            // Từ chuỗi Json => Ra được List đối tượng
            var data = JsonConvert.DeserializeObject<List<SanPham>>(responseBody); // Bóc Json
            // Chú ý về API có parameter thì để ý giá trị được truyền vào
            // Khi call API với HTTPCLIENT ta lấy là responsebody trùng với httpMethod mà chúng ta dùng
            return View(data);
        }
        public IActionResult Create() // Mở form
        {
            SanPham available = new SanPham()
            {
                Ten = "Nhập tên ở đây",
                Gia = 10000,
                HangSX = "CocaFanta",
                Mota = "Đắng như ngậm kẹo",
                SoLuong = 1000,
                TrangThai = 2
            };
            return View(available);
        }
        [HttpPost]
        public IActionResult Create(SanPham sp) // Form này là form thực hiện Logic thêm
        {
            string requestURL = @$"https://localhost:7207/SanPham/post-by-object";
            var responseBody = client.PostAsJsonAsync(requestURL, sp).Result;
            if (responseBody.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "SanPham");
            }
            else return View();
        }
        [HttpGet]
        public IActionResult Create2()
        {
            return View();         
        }
        [HttpPost]
        public IActionResult Create2(string ten, string mota, long gia, int soluong, int trangthai, string hangsx)
        {
            if (ten == null) return View();
            else
            {
                string requestURL = @$"https://localhost:7207/SanPham/post-by-param?ten={ten}&mota={mota}&soluong={soluong}&gia={gia}&trangthai={trangthai}&hangsx={hangsx}";
                var responseBody = client.GetAsync(requestURL).Result;
                if (responseBody.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "SanPham");
                }
                else return View();
            }
        }
        [HttpGet] // Lấy data từ db để sửa xogn truyền vào view
        public IActionResult Edit(Guid id)
        {
            string requestUrl = $"https://localhost:7207/SanPham/get-by-id?id={id}";
            var response = client.GetStringAsync(requestUrl).Result; 
            SanPham editItem = JsonConvert.DeserializeObject<SanPham>(response);    
            return View(editItem);
        }
        [HttpPost] // sửa thật
        public IActionResult Edit(Guid id, string mota, long gia, int soluong, int trangthai)
        {
            string requestUrl = $"https://localhost:7207/SanPham/put-san-pham" +
                $"?id={id}&mota={mota}&gia={gia}&soluong={soluong}&trangthai={trangthai}";
            var response = client.GetAsync(requestUrl).Result;
            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "SanPham");
            }
            return Content(response.ToString());
        }
        // Lưu ý: Phương thức của Action trong Controller của MVC không liên quan tới 
        // phương thức của API => Chúng có thể khác nhau
        // Razor view chỉ support 2 phương thức HTTP là Get và Post
        public IActionResult Delete(Guid id)
        {
            string requestUrl = $"https://localhost:7207/SanPham/delete-by-id?id={id}";
            var response = client.DeleteAsync(requestUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "SanPham");
            }
            return Content(response.ToString());
        }
        public IActionResult Details(Guid id)
        {
            string requestUrl = $"https://localhost:7207/SanPham/get-by-id?id={id}";
            var response = client.GetStringAsync(requestUrl).Result;
            SanPham item = JsonConvert.DeserializeObject<SanPham>(response);
            return View(item);
        }
    }
}
