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
            MessageBox.Show("��ư1 Ŭ��");
        }

        private void btn1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�޽����ڽ�1");
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ������ �ִ� �޽����ڽ�", "�޽����ڽ�2");
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�ΰ��� ��ư�� ���� �޽����ڽ�", "�޽����ڽ�3", MessageBoxButtons.YesNo);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ��ư�� ���� �޽����ڽ�",
                            "�޽����ڽ�4",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Exclamation);
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "��� : " + uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbName.Text = "��� : " + txtName.Text;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            string hp = txtHp.Text;
            lbHp.Text = "��� : " + hp;
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

            lbResultFruit.Text = "������ ���� : " + string.Join(", ", fruits);
            
        }
        private void btnGender_Click(object sender, EventArgs e)
        {
            if(rdFemale.Checked)
            {
                lbResultGender.Text = "��� : ����";
            }
            else
            {
                lbResultGender.Text = "��� : ����";
            }
        }
        private void btnYear_Click(object sender, EventArgs e)
        {
            if (rdYear1.Checked)
            {
                lbResultYear.Text = "��� : 1�г�";
            }
            else if (rdYear2.Checked)
            {
                lbResultYear.Text = "��� : 2�г�";
            }
            else if (rdYear3.Checked)
            {
                lbResultYear.Text = "��� : 3�г�";
            }
            else if (rdYear4.Checked)
            {
                lbResultYear.Text = "��� : 4�г�";
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}