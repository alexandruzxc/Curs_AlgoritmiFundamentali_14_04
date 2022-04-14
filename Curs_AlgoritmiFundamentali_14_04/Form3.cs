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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Cplx a = new Cplx();
            Cplx b = new Cplx();
            Cplx c = new Cplx();
            Cplx d = new Cplx();
            a.init(2, 6);
            b.init(5, 9);            
            c = a * b;
            d = a / b;
            listBox1.Items.Add(c.view());

            listBox2.Items.Add(d.view());
        }

        
    }
}
