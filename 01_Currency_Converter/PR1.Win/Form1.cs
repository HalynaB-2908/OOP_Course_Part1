using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double grn, kurs, doll;
            grn = double.Parse(textBox1.Text);
            kurs = Convert.ToDouble(textBox2.Text);
            doll = grn / kurs;
            

            int dollars, cents;
            dollars = (int)doll;
            cents = Convert.ToInt32((doll - dollars) * 100);
            double zal = grn - (dollars * kurs);
            label3.Text = doll.ToString() + "\n" + "dollars  = " + dollars.ToString() + " cents  = " + cents.ToString() + "\n" + "залишок = " + zal.ToString("F1");
            
        }
    }
}
