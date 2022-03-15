using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassiHooneLoomine_topolja
{
    public class EraMaja : Hoone
    {
        public EraMaja(int pindala = 100) : base(pindala)
        {
            Pindala = pindala;
        }

        public string Staatus
        {
            get
            {
                var staatus = "";
                if (Pindala < 20)
                {
                    staatus = "vaike maja";
                }
                else if (Pindala < 60)
                {
                    staatus = "keskmine maja";
                }
                else if (Pindala < 100)
                {
                    staatus = "suur maja";
                }
                else
                {
                    staatus = "liiga suur maja";
                }
                return staatus;
            }
        }

        public override void NaitaInfo()
        {
            Console.WriteLine($"Ma olen {Staatus}");
        }
    }
}
