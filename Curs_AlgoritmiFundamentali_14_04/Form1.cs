using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_AlgoritmiFundamentali_14_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Cplx sum(Cplx a, Cplx b) //varianta care merge doar pentru operatorii locali
        {
            Cplx t = new Cplx();
            t.re = a.re + b.re;
            t.im = a.im + b.im;

            return t;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Cplx a = new Cplx();
            a.init(2, 3);
          
            Cplx b = new Cplx();
            b.init(5, -3);

            Cplx c = new Cplx();
            c.init(2, 7);

            Cplx d = new Cplx();
            d.init(3, 1);
           

            Cplx d1 = d.conj();

            Cplx r = ((a * b)/ c) - d1 ;
            Cplx t1 = a.sum(b);
            listBox1.Items.Add(r.view());
            listBox1.Items.Add(r.mod().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            myForm2.ShowDialog();
        }
    }
}
