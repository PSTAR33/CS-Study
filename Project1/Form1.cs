namespace Project1
{
    // 복합연산 가능하게 만들기
    public partial class main : Form
    {
        private int var1 = 0;
        private int var2 = 0;

        private List<int> list = new List<int>();
        private List<int> operators = new List<int>();
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
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            list.Add(8);
            txtResult.Text = String.Join("", list);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            list.Add(9);
            txtResult.Text = String.Join("", list);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            list.Add(4);
            txtResult.Text = String.Join("", list);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            list.Add(5);
            txtResult.Text = String.Join("", list);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            list.Add(6);
            txtResult.Text = String.Join("", list);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            list.Add(1);
            txtResult.Text = String.Join("", list);
            

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            list.Add(2);
            txtResult.Text = String.Join("", list);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            list.Add(3);
            txtResult.Text = String.Join("", list);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            var1 = 0;
            var2 = 0;
            list.Clear();
            operators.Clear();
        }

        private void btnEq_Click(object sender, EventArgs e)
        {

            string currentNum = txtResult.Text.ToString();
            var2 = int.Parse(currentNum);
            list.Clear();

            switch (operate)
            {
                case 1:
                    result = var1 + var2;
                    break;
                case 2:
                    result = var1 - var2;
                    break;
                case 3:
                    result = var1 * var2;
                    break;
                case 4:
                    result = var1 / var2;
                    break;
            }
            txtResult.Text = result.ToString();

            operators.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);


            list.Clear();

            operators.Add(1);
            process.Add(var1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);
            
            list.Clear();

            operators.Add(2);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);

            list.Clear();

            operators.Add(3);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();
            var1 = int.Parse(currentNum);

            list.Clear();

            operators.Add(4);
        }
    }
}