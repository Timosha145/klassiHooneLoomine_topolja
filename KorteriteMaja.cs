using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassiHooneLoomine_topolja
{
    public class KorteriteMaja : Hoone
    {
        public KorteriteMaja(int pindala = 100) : base(pindala)
        {
            Pindala = pindala;
        }
        public int Korrused
        {
            get 
            {
                Random r = new Random();
                int korrused = 0;
                if (Pindala>1000)
                {
                    korrused = r.Next(5, 10);
                }
                else if (Pindala>10000)
                {
                    korrused = r.Next(20, 40);
                }
                else
                {
                    korrused = r.Next(1, 3);
                }
                return korrused;
            }
        }

        public override void NaitaInfo()
        {
            Console.WriteLine($"Ma olen {Korrused} maja");
        }
    }
}
