using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassiHooneLoomine_topolja
{
    public abstract class Hoone
    {
        public int Pindala { get; set; }
        public Uks uks;

        public Hoone(int pindala=100)
        {
            Pindala = pindala;
        }

        public abstract void NaitaInfo();
        public void NaitaInfo1()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
        }

        public Uks GetUks()
        {
            return uks;
        }
    }
}
