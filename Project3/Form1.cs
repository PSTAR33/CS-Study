namespace Project3
{
    public partial class Form1 : Form
    {
        private int margin = 40;
        private int sizeNun = 30;
        private int sizeDol = 28;

        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;

        bool isBlack = true;

        enum STONE { none, black, white };
        STONE[,] dataSet = new STONE[19, 19];

        public Form1()
        {
            InitializeComponent();

            // 그래픽 관련 객체 초기화
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

            // 바둑판 색, 크기
            this.Text = "오목 v1.0";
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNun, 2 * margin + 18 * sizeNun);

            // 파둑판 눈금 그리기
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;
            //Console.WriteLine("x:{0}, y:{1}", x, y);

            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                                          margin + sizeNun * y - sizeNun / 2,
                                          sizeDol,
                                          sizeDol);

            if (dataSet[x,y] != STONE.none)
            {
                MessageBox.Show("이미 돌이 놓여있습니다.");
                return;
            }
            
            // 검은돌, 흰돌 그리기
            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);
                dataSet[x,y] = STONE.black;
                isBlack = false;
            }
            else
            {
                g.FillEllipse(wBrush, dol);
                dataSet[x, y] = STONE.white;
                isBlack = true;
            }

            // 오목 여부 판정
            CheckOmok(x, y);

            
        }

        public void CheckOmok(int x, int y) 
        {
            int count = 1;

            // 오른쪽
            for (int i = x + 1; i <= 18; i++)
            {
                Console.WriteLine("x : " + x);

                if (dataSet[i, y] == dataSet[x, y])
                {
                    count++;
                }
                else
                    break;
            }

            // 왼쪽
            for (int i = x - 1; i >= 0; i--)
            {
                Console.WriteLine("x : " + x);

                if (dataSet[i, y] == dataSet[x, y])
                {
                    count++;
                }
                else
                    break;
            }
            CheckCountAlert(count);
            count = 1;

            // 위쪽
            for (int i = y + 1; i <= 18; i++)
            {
                Console.WriteLine("y : " + y);

                if (dataSet[x, i] == dataSet[x, y])
                {
                    count++;
                }
                else
                    break;
            }

            // 아래쪽
            for (int i = y - 1; i >= 0; i--)
            {
                Console.WriteLine("y : " + y);

                if (dataSet[x, i] == dataSet[x, y])
                {
                    count++;
                }
                else
                    break;
            }
            CheckCountAlert(count);
            count = 1;



            // 대각선 11시
            for (int i = x + 1, j = y + 1; i <= 18 && j <= 18; i++, j++)
            {
                if (dataSet[i, j] == dataSet[x, y])
                {
                    count++;
                    Console.WriteLine(count);
                }
                else
                    break;
            }
            // 대각선 16시
            for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (dataSet[i, j] == dataSet[x, y])
                {
                    count++;
                    Console.WriteLine(count);
                }
                else
                    break;
            }
            CheckCountAlert(count);
            count = 1;

            // 대각선 13시
            for (int i = x - 1, j = y + 1; i >= 0 && j <= 18; i--, j++)
            {
                if (dataSet[i, j] == dataSet[x, y])
                {
                    count++;
                    Console.WriteLine(count);
                }
                else
                    break;
            }

            // 대각선 19시
            for (int i = x + 1, j = y - 1; i <= 18 && j >= 0; i++, j--)
            {
                if (dataSet[i, j] == dataSet[x, y])
                {
                    count++;
                    Console.WriteLine(count);
                }
                else
                    break;
            }
            CheckCountAlert(count);
            count = 1;
        }

        public void NewGame()
        {
            this.Invalidate(); // 화면 갱신 -> OnPanit 호출
            
            for(int x = 0; x < 19; x++)
                for(int y = 0; y < 19; y++)
                    dataSet[x, y] = STONE.none;
            // 검은돌 시작
            isBlack = true;
        }
        
        public void CheckCountAlert(int count)
        {
            if (count == 5)
            {
                DialogResult result = MessageBox.Show("오목입니다! 새로운 게임을 시작할까요?",
                                                      "확인",
                                                      MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NewGame();
                    return;
                }
                else
                {
                    this.Close();
                }
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            // 바둑판 눈금 그리기
            for(int i=0; i<19; i++)
            {
                g.DrawLine(pen, new Point(margin + sizeNun * i, margin), new Point(margin + sizeNun * i, margin + sizeNun * 18));
            }
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin, margin + sizeNun * i), new Point(margin + sizeNun * 18, margin + sizeNun * i));
            }

            // 점 표시
            for(int i = 0; i < 19; i++)
            {
                for(int j = 0; j <19; j++)
                {
                    g.FillEllipse(bBrush, margin - 2 + sizeNun * i, margin - 2 + sizeNun * j, 4, 4);
                }
            }
            
        }
    }
}