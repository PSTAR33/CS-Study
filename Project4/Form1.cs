namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;

        int nBlocks = 20;
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        bool[] blockVisible = new bool[100];
        Rectangle ball;

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor = new SolidBrush(Color.Orange);
        Brush ballColor = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        int formW = 300;  
        int formH = 500;   //�ٸ�


        int racketY = 480;
        int racketW = 50;
        int racketH = 10;

        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;

        double slope; // ����
        double vDir = 1; // ���� ��, �Ʒ��� ���ϴ� ���� ����

        Random rand = new Random();
        public int clearedBlocks = 0;
        public int MaxBlocks = 100;
        public int initialBallPosition;

        public Form1()
        {
            InitializeComponent();

            // �� ������
            ClientSize = new Size(formW, formH);
            this.Text = "BlockBreak v1.0";

            InitblockVisible();
            InitBlocks();
            InitRacket();
            StartBall();
        }

        public void InitblockVisible()
        {
            for (int i = 0; i < nBlocks; i++)
                blockVisible[i] = true;
        }
        public void InitRacket()
        {
            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }
        public void InitBall()
        {
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;
        }
        public void DrawBall()
        {
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);
        }
        public void DrawRacket()
        {
            g.FillRectangle(racketColor, racket);
        }
        public void InitBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW,
                                          blockY + blockH * (i / 10),
                                          blockW - 1,
                                          blockH - 1);
            }
        }
        public void DrawBlock()
        {
            for (int i = 0; i < nBlocks; i++)
            {
                if (blockVisible[i])
                {
                    g.FillRectangle(blockColor, blocks[i]);
                }
            }
        }
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                racket.X += 10;
            }

            if (e.KeyCode == Keys.Escape)
            {
                myTimer.Stop();
            }
            if (e.KeyCode == Keys.Enter)
            {
                myTimer.Start();
            }


            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            g = CreateGraphics();

            // ���� �׸���
            DrawBlock();

            // ���� �׸���
            DrawRacket();

            // �� �׸���
            DrawBall();

        }
        public void StartBall()
        {
            InitBall();
            slope = rand.Next(5, 20) / 10.0;
            if (rand.Next(2) % 2 == 1)
                slope = -slope;
        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            // Console.WriteLine("tick!");
            double dx = 0;
            double unit = ballW;

            dx = unit / slope;

            ball.X += (int)dx;
            ball.Y += (int)(vDir * slope * dx);

            // ball�� �¿� ���� �浹 �ߴ��� üũ
            if (ball.X < 0 || ball.X > formW - ballW)
            {
                slope = -slope;
            }

            // ball�� õ���̳� ���Ͽ� �¾Ҵ��� üũ
            if (ball.Y < 0 || racket.IntersectsWith(ball))
            {
                vDir = -vDir;
            }
            Invalidate();

            // ball�� �������� ������ ��
            if (ball.Y > ClientSize.Height)
            {
                StartBall();
                return;
            }

            // ����� �� �Ʒ� ��ġ���� ���� �� �Ʒ��� �ִٸ� ��ϰ��� intersect�� ������ �ʴ´�.
            if (ball.Y > blockY + blockH * blockH * nBlocks / 10)
                return;

            Random sRnd = new Random();
            for (int i = 0; i < nBlocks; i++)
            {
                if (blockVisible[i] && ball.IntersectsWith(blocks[i]))
                {
                    blockVisible[i] = false;
                    vDir = -vDir;

                    int index = sRnd.Next(0, 3);
                    if (++clearedBlocks >= nBlocks)
                    {
                        myTimer.Stop();

                        if (nBlocks == MaxBlocks)
                        {
                            MessageBox.Show("Final Stage Cleared!", "Mission Completed!!", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            string str = string.Format("Level {0} Completed! Play More?", nBlocks / 20);
                            DialogResult result = MessageBox.Show(str, "Level Clear!", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                                newLevelStart();
                            else
                                Close();
                        }
                    }
                }
            }



        }
        public void newLevelStart()
        {
            if (nBlocks > MaxBlocks)
                return; // nBlocks = MaxBlocks;

            nBlocks += 20;  // 20�� �� ����

            InitblockVisible();
            InitRacket();
            InitBall();
            InitBlocks();

            clearedBlocks = 0;

            StartBall();
            myTimer.Start();
        }

        
    }
}