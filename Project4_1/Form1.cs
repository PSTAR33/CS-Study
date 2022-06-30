namespace Project4_1
{
    public partial class Form1 : Form
    {
        Graphics g;
        int nBlocks = 20;   // ���� 20��
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];  // ��� rectagle �迭
        bool[] bVisible = new bool[100];
        Rectangle ball;

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor = new SolidBrush(Color.Orange);
        Brush ballColor = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        int racketY = 480;  // racket�� ��ġ
        int formW = 300;  // Form�� ��
        int racketW = 50;
        int racketH = 10;

        int blockY = 60;    // ��� ��ġ
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;

        private double slope;       // ���� ���� 0.5~2 ����     
        private double vDir = 1;         // �������� 1=�Ʒ�, -1=��

        Random r = new Random();
        private int clearedBlocks = 0;
        private int MaxBlocks = 100;

        System.Media.SoundPlayer myPlayer;
        System.Media.SoundPlayer[] blockSound = new System.Media.SoundPlayer[4];
        private int initialBallPosition;    // ���� ���� ��ġ(y ��ǥ)
        
        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(300, 500);
            this.Text = "Block Breaker v1.0";

            initbVisible();
            initRacket();
            initBlocks();
            StartBall();


        }
        private void initbVisible()
        {
            for (int i = 0; i < nBlocks; i++)
                bVisible[i] = true;
        }

        private void initRacket()
        {
            racket.X = formW / 2 - racketW / 2;  // �߾�
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }

        private void initBall()
        {
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;    // �߾�
            ball.Y = blockY + nBlocks / 10 * blockH;
            initialBallPosition = ball.Y;
            ball.Width = ballW;
            ball.Height = ballH;
        }

        private void drawBall()
        {
            g.FillRectangle(ballColor, ball);
            g.DrawRectangle(pen, ball);
        }

        private void drawRacket()
        {
            g.FillRectangle(racketColor, racket);
        }

        private void initBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
                blocks[i] = new Rectangle(i % 10 * blockW, blockY + blockH * (i / 10),
                     blockW - 1, blockH - 1);
        }

        private void drawBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
                if (bVisible[i])
                    g.FillRectangle(blockColor, blocks[i]);
        }

         void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
                if (racket.X < 0)
                    racket.X = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                racket.X += 10;
                if (racket.X > formW - racketW)
                    racket.X = formW - racketW;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                myTimer.Stop();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                myTimer.Start();
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;     // �Ǵ� this.CreateGraphics();
            drawRacket();
            drawBlocks();
            drawBall();
        }
        private void StartBall()
        {
            initBall();
            slope = r.Next(5, 20) / 10.0;
            if (r.Next(2) % 2 == 1)
                slope = -slope;
        }
        void myTimer_Tick(object sender, EventArgs e)
        {
            double dX;
            double unit = ballW;

            dX = unit / slope;
            ball.X += (int)dX;  // �ӵ� ������ ���� slope�� ������ ��, +- ������ �ʿ� ����
            ball.Y += (int)(vDir * slope * dX);

            // ball�� �¿� ���� �浹�Ͽ����� üũ
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

            // ball�� ȭ�� �Ʒ����� �� �������ٸ�, �������� �޾Ƴ��� ���� ���̹Ƿ� ���� ��
            if (ball.Y > ClientSize.Height)
            {
                StartBall();
                return;
            }

            // ����� �� �Ʒ� ��ġ���� ���� �� �Ʒ��� �ִٸ� ��ϰ��� intersect�� ������ �ʴ´�
            if (ball.Y > blockY + blockH * nBlocks / 10)
                return;

            Random sRnd = new Random();
            for (int i = 0; i < nBlocks; i++)
            {
                if (bVisible[i] && ball.IntersectsWith(blocks[i]))
                {
                    bVisible[i] = false;
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
        private void newLevelStart()
        {
            if (nBlocks > MaxBlocks)
                return; // nBlocks = MaxBlocks;

            nBlocks += 20;  // 20�� �� ����

            initbVisible();
            initRacket();
            initBall();
            initBlocks();

            clearedBlocks = 0;

            StartBall();
            myTimer.Start();
        }

    }
    
}
