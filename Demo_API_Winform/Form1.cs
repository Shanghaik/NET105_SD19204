namespace Demo_API_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {

            // https://localhost:7207/api/Test/get-bmi?height=15&weight=23
            double cao = Convert.ToDouble(tbt_height.Text);
            double nang = Convert.ToDouble(tbt_weight.Text);
            string requestURL = @$"https://localhost:7207/api/Test/get-bmi?height={cao}&weight={nang}";
            // Tạo ra 1 HttpClient để đọc dữ liệu => lấy ra responseBody
            HttpClient client = new HttpClient();
            var responseBody = client.GetStringAsync(requestURL).Result;
            lb_result.Text = responseBody;
            // Chú ý về API có parameter thì để ý giá trị được truyền vào
            // Khi call API với HTTPCLIENT ta lấy là responsebody trùng với httpMethod mà chúng ta dùng 
        }
    }
}