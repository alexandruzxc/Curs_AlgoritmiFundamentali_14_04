using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_AlgoritmiFundamentali_14_04
{
    public class Cplx //- asta e clasa ( putem schimba numele clasei sau numele fisierului
    {
         public float re, im;
         public void init (float _re, float _im)
        {
            re = _re;
            im = _im;
        }
        public string view() //pentru ca am nevoie de string
        {
            if (im > 0)
                return re.ToString("0.00") + " + i" + im.ToString("0.00");
            else
                return re.ToString("0.00") + " - i" + (-1 * im).ToString("0.00");
        }
        public Cplx sum(Cplx a )
        {
            Cplx t = new Cplx();
            t.re = re + a.re;
            t.im = im + a.im;
            
            return t;
        }

        public static Cplx operator + ( Cplx a, Cplx b)
        {
            Cplx t = new Cplx();
            t.re = a.re + b.re;
            t.im = a.im + b.im;

            return t; //e cel mai elegant
        }

        public static Cplx operator -(Cplx a, Cplx b)
        {
            Cplx t = new Cplx();
            t.re = a.re - b.re;
            t.im = a.im - b.im;

            return t; //e cel mai elegant
        }

        public static Cplx operator * ( Cplx a, Cplx b)
        {
            Cplx t = new Cplx();
            t.re = a.re * b.re - a.im * b.im;
            t.im = a.im * b.re + a.re * b.im; //formula matematica

            return t;
        }
        public  Cplx conj()
        {
            Cplx t = new Cplx();
            t.re = re;
            t.im = -1 * im;
            return t;
        }

        public static Cplx operator / (Cplx a, Cplx b)
        {
            Cplx c = b.conj();
            Cplx u = a * c;
            Cplx d = b * c;
            Cplx t = new Cplx();
            t.re = u.re / d.re;
            t.im = u.im / d.re;
            return t; //asta e formula matematica
        }

        public float mod()
        {
            return (float)Math.Sqrt(re * re + im * im);  
        }
    }
}
