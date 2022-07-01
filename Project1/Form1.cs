namespace Project1
{
    // 복합연산 가능하게 만들기
    public partial class main : Form
    {

        private List<int> list = new List<int>();
        private List<int> process = new List<int>();
        private int result = 0;

        public main()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            list.Add(7);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("숫자7입력");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            list.Add(8);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("숫자8입력");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            list.Add(9);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("숫자9입력");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            list.Add(4);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("숫자4입력");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            list.Add(5);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("숫자5입력");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            list.Add(6);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("숫자6입력");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            list.Add(1);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("숫자1입력");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            list.Add(2);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("숫자2입력");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            list.Add(3);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("숫자3입력");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            list.Add(0);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("숫자0입력");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            list.Clear();
            process.Clear();
            result = 0;
            Console.WriteLine("취소 입력");
        }

        private void btnEq_Click(object sender, EventArgs e)
        {            
            string currentNum = txtResult.Text.ToString();
            List<int> process = new List<int> { int.Parse(currentNum) };

            list.Clear();

            Console.WriteLine("엔터입력");

            result = process[0];
            for (int i= 2; i < process.Count; i++)
            {
                if(i % 2 == 0)  // 입력한 숫자들
                {
                    switch(process[i-1])  // 입력한 연산자들(1~4)
                    {
                        case 1:
                            result = result + process[i];
                            break;
                        case 2:
                            result = result - process[i];
                            break;
                        case 3:
                            result = result * process[i];
                            break;
                        case 4:
                            result = result / process[i];
                            break;
                    }
                    
                }
                Console.WriteLine("연산과정 중");
            }

            txtResult.Text = result.ToString();

            list.Clear();
            process.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();

            list.Clear();

            process.Add(int.Parse(currentNum));
            process.Add(1);

            Console.WriteLine("플러스입력");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();

            list.Clear();

            process.Add(int.Parse(currentNum));
            process.Add(2);

            Console.WriteLine("마이너스입력");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();            

            list.Clear();

            process.Add(int.Parse(currentNum));
            process.Add(3);

            Console.WriteLine("곱하기입력");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();

            list.Clear();

            process.Add(int.Parse(currentNum));
            process.Add(4);

            Console.WriteLine("나누기입력");
        }
    }
}