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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stud[] stMas;
        int N, Ni = 0;
        string fName;

        private void create_mas_std_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            try
            {
                N = Convert.ToInt32(textBox1.Text);
                if (N <= 0)
                {
                    throw new ArgumentOutOfRangeException(); 
                }
            }
            catch (FormatException) 
            {
                MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
                return;
            }
            catch (OverflowException) 
            {
                MessageBox.Show("The number is too large or too small.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("The number must be greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stMas = new Stud[N];
            dataGridView1.RowCount = N;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Last Name";
            dataGridView1.Columns[1].HeaderText = "Exam 1";
            dataGridView1.Columns[2].HeaderText = "Exam 2";
            dataGridView1.Columns[3].HeaderText = "Exam 3";
            dataGridView1.Columns[4].HeaderText = "Avg Score";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            textBox1.Text = "";
        }
        private void add_stud_to_arr_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                stMas[Ni] = f2.pr_stud;
                dataGridView1.Rows[Ni].Cells[0].Value = stMas[Ni].Name;
                dataGridView1.Rows[Ni].Cells[1].Value = stMas[Ni].Ex1;
                dataGridView1.Rows[Ni].Cells[2].Value = stMas[Ni].Ex2;
                dataGridView1.Rows[Ni].Cells[3].Value = stMas[Ni].Ex3;
                dataGridView1.Rows[Ni].Cells[4].Value = stMas[Ni].AverGrade;
                Ni++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int NomEdit = -1;
            fName = textBox2.Text;
            for (int i = 0; i < N; i++)
            {
                if (stMas[i] != null && stMas[i].Name == fName)
                {
                    NomEdit = i;
                    break;
                }
            }
            if (NomEdit == -1)
            {
                MessageBox.Show("Student not found");
                return;
            }
            Form2 fEdit = new Form2(ref stMas[NomEdit]);
            fEdit.ShowDialog();
            dataGridView1.Rows[NomEdit].Cells[0].Value = stMas[NomEdit].Name;
            dataGridView1.Rows[NomEdit].Cells[1].Value = stMas[NomEdit].Ex1;
            dataGridView1.Rows[NomEdit].Cells[2].Value = stMas[NomEdit].Ex2;
            dataGridView1.Rows[NomEdit].Cells[3].Value = stMas[NomEdit].Ex3;
            dataGridView1.Rows[NomEdit].Cells[4].Value = stMas[NomEdit].AverGrade;
            textBox2.Text = "";
        }
        private void find_student_Click(object sender, EventArgs e)
        {
            fName = textBox2.Text;
            int NomEdit = -1;

            for (int i = 0; i < N; i++)
            {
                if (stMas[i] != null && stMas[i].Name == fName)
                {
                    NomEdit = i;
                    break;
                }
            }
            if (NomEdit == -1)
            {
                MessageBox.Show("Student not found");
                return;
            }
            dataGridView1.Rows[NomEdit].DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            textBox2.Text = "";
        }
    }
}
