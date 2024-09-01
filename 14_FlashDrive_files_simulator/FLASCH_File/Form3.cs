using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLASCH_File
{
    public partial class Form3 : Form
    {
        public string FileName { get; private set; }
        public int FileSize { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            FileName = textBox1.Text;
            FileSize = Convert.ToInt32(textBox2.Text);
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}
