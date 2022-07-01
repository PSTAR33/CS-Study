namespace Project1
{
    // ���տ��� �����ϰ� �����
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
            Console.WriteLine("����7�Է�");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            list.Add(8);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("����8�Է�");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            list.Add(9);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("����9�Է�");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            list.Add(4);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("����4�Է�");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            list.Add(5);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("����5�Է�");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            list.Add(6);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("����6�Է�");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            list.Add(1);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("����1�Է�");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            list.Add(2);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("����2�Է�");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            list.Add(3);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("����3�Է�");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            list.Add(0);
            txtResult.Text = String.Join("", list);
            Console.WriteLine("����0�Է�");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            list.Clear();
            process.Clear();
            result = 0;
            Console.WriteLine("��� �Է�");
        }

        private void btnEq_Click(object sender, EventArgs e)
        {            
            string currentNum = txtResult.Text.ToString();
            List<int> process = new List<int> { int.Parse(currentNum) };

            list.Clear();

            Console.WriteLine("�����Է�");

            result = process[0];
            for (int i= 2; i < process.Count; i++)
            {
                if(i % 2 == 0)  // �Է��� ���ڵ�
                {
                    switch(process[i-1])  // �Է��� �����ڵ�(1~4)
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
                Console.WriteLine("������� ��");
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

            Console.WriteLine("�÷����Է�");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();

            list.Clear();

            process.Add(int.Parse(currentNum));
            process.Add(2);

            Console.WriteLine("���̳ʽ��Է�");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();            

            list.Clear();

            process.Add(int.Parse(currentNum));
            process.Add(3);

            Console.WriteLine("���ϱ��Է�");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();

            list.Clear();

            process.Add(int.Parse(currentNum));
            process.Add(4);

            Console.WriteLine("�������Է�");
        }
    }
}