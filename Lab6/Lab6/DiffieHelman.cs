using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6
{
    public class DiffieHelman
    {
        int g = 43;
        int p = 107;
        int a = 0;
        int b = 0;

        public DiffieHelman(int a, int b) {
            this.a = a; 
            this.b = b;
        }

        public int compute(int num) {
            long aux = (long)Math.Pow(g, a);
            int reponse = (int)(aux % p);

            return 0;
        }
    }
}
