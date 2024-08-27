using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr_El_Replacement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] mas1;
        int N, M;
        private void button1_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(textBox1.Text);
            M = Convert.ToInt32(textBox2.Text);
            mas1 = new int[N, M];
            dataGridView1.RowCount = N;
            dataGridView1.ColumnCount = M;
            Random myR = new Random();
            int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    mas1[i, j] = myR.Next(20);
                    dataGridView1.Rows[i].Cells[j].Value = mas1[i, j];

                    if (mas1[i, j] < mas1[minRow, minCol])
                    {
                        minRow = i;
                        minCol = j;
                    }
                    if (mas1[i, j] > mas1[maxRow, maxCol])
                    {
                        maxRow = i;
                        maxCol = j;
                    }
                }

            for (int j = 0; j < M; j++)
                dataGridView1.Columns[j].Width = 30;

            dataGridView1.Rows[minRow].Cells[minCol].Style.BackColor = System.Drawing.Color.Red;
            dataGridView1.Rows[maxRow].Cells[maxCol].Style.BackColor = System.Drawing.Color.Gray;
            label3.Text = $"Min: ({minRow}, {minCol})";
            label4.Text = $"Мax: ({maxRow}, {maxCol})";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
