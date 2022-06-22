namespace Ch11
{
    public partial class btn1 : Form
    {
        public btn1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼1 클릭");
        }

        private void btn1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지박스1");
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제목과 내용이 있는 메시지박스", "메시지박스2");
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("두개의 버튼을 갖는 메시지박스", "메시지박스3", MessageBoxButtons.YesNo);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("세개의 버튼을 갖는 메시지박스",
                            "메시지박스4",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Exclamation);
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "결과 : " + uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbName.Text = "결과 : " + txtName.Text;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            string hp = txtHp.Text;
            lbHp.Text = "결과 : " + hp;
        }
        private void btnFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chbFruits = { chbFruit1, chbFruit2, chbFruit3, chbFruit4, chbFruit5 };

            List<string> fruits = new List<string>();

            foreach (CheckBox chb in chbFruits)
            {
                if (chb.Checked)
                {
                    fruits.Add(chb.Text);
                }
            }

            lbResultFruit.Text = "선택한 과일 : " + string.Join(", ", fruits);
            
        }
        private void btnGender_Click(object sender, EventArgs e)
        {
            if(rdFemale.Checked)
            {
                lbResultGender.Text = "결과 : 남성";
            }
            else
            {
                lbResultGender.Text = "결과 : 여자";
            }
        }
        private void btnYear_Click(object sender, EventArgs e)
        {
            if (rdYear1.Checked)
            {
                lbResultYear.Text = "결과 : 1학년";
            }
            else if (rdYear2.Checked)
            {
                lbResultYear.Text = "결과 : 2학년";
            }
            else if (rdYear3.Checked)
            {
                lbResultYear.Text = "결과 : 3학년";
            }
            else if (rdYear4.Checked)
            {
                lbResultYear.Text = "결과 : 4학년";
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}