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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Flash _flashEdit;
        public Form2(Flash flashEdit) : this()
        {
            _flashEdit = flashEdit;
            textBox1.Text = _flashEdit.Name;
            textBox2.Text = _flashEdit.MaxSize.ToString();
            Btn_save_flash.Text = "Save Edit";
        }
        public Flash n_flash
        {
            get
            {
                return new Flash(textBox1.Text, Convert.ToInt32(textBox2.Text));
            }
        }
        private void Btn_save_flash_Click(object sender, EventArgs e)
        {
            if (!(_flashEdit is null))
            {
                _flashEdit.Name = textBox1.Text;
                _flashEdit.MaxSize = Convert.ToInt32(textBox2.Text);
            }
        }

    }
}
