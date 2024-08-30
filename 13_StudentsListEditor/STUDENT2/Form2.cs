using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(ref Stud stEdit)
        {
            InitializeComponent();
            textBox1.Text = stEdit.Name;
            textBox2.Text = stEdit.Ex1.ToString();
            textBox3.Text = stEdit.Ex2.ToString();
            textBox4.Text = stEdit.Ex3.ToString();
            btn_Save.Text = "Save Edit";
            btn_Save.Text = "Save Edit";
            _stEdit =stEdit;
        }
        Stud _stEdit;
        public Stud pr_stud 
        {
            get 
            { 
                Stud st1 = new Stud();
                st1.Name = textBox1.Text;
                st1.Ex1 = Convert.ToInt32(textBox2.Text);
                st1.Ex2 = Convert.ToInt32(textBox3.Text);
                st1.Ex3 = Convert.ToInt32(textBox4.Text);
                return st1;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!(_stEdit is null))
            {
                _stEdit.Name = textBox1.Text;
                _stEdit.Ex1 = Convert.ToInt32(textBox2.Text);
                _stEdit.Ex2 = Convert.ToInt32(textBox3.Text);
                _stEdit.Ex3 = Convert.ToInt32(textBox4.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
