using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class LGRemocon : IRemoteControl
    {
        public void ChDown()
        {
            Console.WriteLine("LGRemocon ChDown...");
        }

        public void ChUp()
        {
            Console.WriteLine("LGRemocon ChUp...");
        }

        public void PowerOff()
        {
            Console.WriteLine("LGRemocon PowerOff...");
        }

        public void PowerOn()
        {
            Console.WriteLine("LGRemocon PowerOn...");
        }

        public void SoundDown()
        {
            Console.WriteLine("LGRemocon SoundDown...");
        }

        public void SoundUp()
        {
            Console.WriteLine("LGRemocon SoundUp...");
        }
    }
}
