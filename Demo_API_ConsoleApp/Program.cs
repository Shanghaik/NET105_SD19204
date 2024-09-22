namespace Demo_API_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://localhost:7207/api/Test/get-bmi?height=15&weight=23
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hãy nhập chiều cao (m): ");
            double cao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hãy nhập Cân nặng (kg): ");
            double nang = Convert.ToDouble(Console.ReadLine());
            string requestURL = @$"https://localhost:7207/api/Test/get-bmi?height={cao}&weight={nang}";
            // Tạo ra 1 HttpClient để đọc dữ liệu => lấy ra responseBody
            HttpClient client = new HttpClient();
            var responseBody = client.GetStringAsync(requestURL).Result;
            Console.WriteLine(responseBody);
            // Chú ý về API có parameter thì để ý giá trị được truyền vào
            // Khi call API với HTTPCLIENT ta lấy là responsebody trùng với httpMethod mà chúng ta dùng 
        }
    }
}