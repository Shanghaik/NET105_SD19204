using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("get-bmi")]
        public String GetBMI(double height, double weight)
        {
            double bmi = Math.Round(weight / height / height, 2);
            if (bmi <= 0) return "Dữ liệu nhập vào có vẻ không đúng, hãy kiểm tra lại";
            else if (bmi > 25)
            {
                return $"Bạn có vẻ thừa cân với BMI = {bmi}";
            }
            else if (bmi < 18)
            {
                return $"Bạn có vẻ hơi gầy với BMI = {bmi}";
            }
            else return $"Bạn cân đối với BMI = {bmi}";
        }
    }
}
