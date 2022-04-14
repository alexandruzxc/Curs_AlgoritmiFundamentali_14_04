using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_AlgoritmiFundamentali_14_04
{
    public static class Engine
    {
        public static Cplx sum(Cplx a, Cplx b)
        {
            Cplx t = new Cplx();
            t.re = a.re + b.re;
            t.im = a.im + b.im;

            return t;
        }
        //cand o clasa este declarata statica
        //nu mai are nevoie de constructor
        // dar ramane o singura clasa, nu se poate face o a 2-a clasa
    }
}
