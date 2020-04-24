using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6
{
    public class Diffie
    {
        int a { get; set; }
        int b { get; set; }
        int g = 43;
        int p = 107;

        public Diffie(int a, int b) {
            this.a = a;
            this.b = b;
        }

        public int generateKey() {
            long auxA = (long)Math.Pow(g, a);
            long auxB = (long)Math.Pow(g, b);

            int A = (int)(auxA % p);
            int B = (int)(auxB % p);

            int K = (int)(Math.Pow(B, a) % p);
            int auxK = (int)(Math.Pow(A, b) % p);
            return K;
        }
    }
}
