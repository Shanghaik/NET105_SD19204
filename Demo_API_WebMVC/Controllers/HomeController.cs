using Demo_API_WebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_API_WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult GetBMI(double height, double weight)
        {
            if (height == 0 && weight == 0)
            {
                return View();
            }
            else
            {
                // https://localhost:7207/api/Test/get-bmi?height=15&weight=23
                string requestURL = @$"https://localhost:7207/api/Test/get-bmi?height={height}&weight={weight}";
                // Tạo ra 1 HttpClient để đọc dữ liệu => lấy ra responseBody
                HttpClient client = new HttpClient();
                var responseBody = client.GetStringAsync(requestURL).Result;
                Console.WriteLine(responseBody);
                // Chú ý về API có parameter thì để ý giá trị được truyền vào
                // Khi call API với HTTPCLIENT ta lấy là responsebody trùng với httpMethod mà chúng ta dùng
                ViewData["result"] = responseBody;
                return View();
            }
        }
    }
}