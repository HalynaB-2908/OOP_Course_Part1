using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace STUDENT2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetupToolTips();
            SetupValidation();
        }
        public Form2(ref Stud stEdit)
        {
            InitializeComponent();
            textBox1.Text = stEdit.Name;
            textBox2.Text = stEdit.Ex1.ToString();
            textBox3.Text = stEdit.Ex2.ToString();
            textBox4.Text = stEdit.Ex3.ToString();
            btn_Save.Text = "Save Edit";
            _stEdit =stEdit;
            SetupValidation();
            SetupToolTips();
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
        private void SetupToolTips()
        {
            toolTip.SetToolTip(textBox1, "Enter the student's name");
            toolTip.SetToolTip(textBox2, "Enter the valid grade");
            toolTip.SetToolTip(textBox3, "Enter the valid grade");
            toolTip.SetToolTip(textBox4, "Enter the valid grade");
        }
        private void SetupValidation()
        {
            textBox1.TextChanged += ValidateInputs;
            textBox2.TextChanged += ValidateInputs;
            textBox3.TextChanged += ValidateInputs;
            textBox4.TextChanged += ValidateInputs;
            ValidateInputs(null, null);
        }

        private void ValidateInputs(object sender, EventArgs e)
        {
            bool isNameValid = !string.IsNullOrWhiteSpace(textBox1.Text);
            bool isEx1Valid = int.TryParse(textBox2.Text, out _);
            bool isEx2Valid = int.TryParse(textBox3.Text, out _);
            bool isEx3Valid = int.TryParse(textBox4.Text, out _);
            btn_Save.Enabled = isNameValid && isEx1Valid && isEx2Valid && isEx3Valid;
        }
    }
}
