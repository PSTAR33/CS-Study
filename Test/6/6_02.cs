using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._6
{
    internal class _6_02
    {
        static void Main1(string[] args)
        {
            string path = "C:\\Users\\1302\\Desktop\\Gugudan.txt";

            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                //스트림 생성
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                for ( int x = 2; x <= 9; x++)
                {
                    sw.WriteLine($"{x}단");
                    for ( int y = 1; y <= 9; y++)
                    {
                        sw.Write("{0} * {1} = {2}", +x,+y,+x*y);
                        sw.WriteLine();
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                //파일닫기
                sw.Close();
                fs.Close();
            }

            Console.WriteLine("구구단 파일 생성 완료...");
        }
    }
}
