using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FLASCH_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int M, Mi = 0;
        Flash[] MasFlash;
        private void Add_mas_flash_Click(object sender, EventArgs e)
        {
            M = Convert.ToInt32(textBox1.Text);
            MasFlash = new Flash[M];
            dataGridView1.RowCount = M;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Files";
            dataGridView1.Columns[2].HeaderText = "Files size";
            dataGridView1.Columns[3].HeaderText = "Files count";
            dataGridView1.Columns[4].HeaderText = "Max size";
            dataGridView1.Columns[1].Width = 200;
        }
        private void Add_Flash_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                MasFlash[Mi] = f2.n_flash;
                UpdateDataGridViewAtIndex(Mi);
                Mi++;
            }
            if (Mi == M) Add_Flash.Enabled = false;
        }
        private void Add_File_Click(object sender, EventArgs e)
        {
            int flash_Ind = Convert.ToInt32(textBox2.Text);
            Flash selectedFlash = MasFlash[flash_Ind];
            Form3 f3 = new Form3();
            f3.ShowDialog();
            if (f3.DialogResult == DialogResult.OK)
            {
                File newFile = new File(f3.FileName, f3.FileSize);
                selectedFlash.AddFile(newFile);
                UpdateDataGridViewAtIndex(flash_Ind);
            }   
        }
        private void Edit_flash_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textBox3.Text);
            Form2 f2 = new Form2(MasFlash[index]);
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                MasFlash[index] = f2.n_flash;
                UpdateDataGridViewAtIndex(index);
            }
        }
        private void Edit_file_Click(object sender, EventArgs e)
        {
            int flashIndex = Convert.ToInt32(textBox4.Text);
            int fileIndex = Convert.ToInt32(textBox5.Text);
            Form3 f3 = new Form3();
            f3.ShowDialog();
            if (f3.DialogResult == DialogResult.OK)
            {
                MasFlash[flashIndex].Files[fileIndex].Name = f3.FileName;
                MasFlash[flashIndex].Files[fileIndex].Size = f3.FileSize;
                UpdateDataGridViewAtIndex(flashIndex);
            }        
        }
        private void Move_file_Click(object sender, EventArgs e)
        {
            int sourceFlashIndex = Convert.ToInt32(textBox6.Text);
            int destinationFlashIndex = Convert.ToInt32(textBox7.Text);
            int fileIndex = Convert.ToInt32(textBox8.Text);
            File fileToMove = MasFlash[sourceFlashIndex].Files[fileIndex];
            MasFlash[sourceFlashIndex].RemoveFile(fileToMove.Name);
            MasFlash[destinationFlashIndex].AddFile(fileToMove);
            UpdateDataGridViewAtIndex(sourceFlashIndex);
            UpdateDataGridViewAtIndex(destinationFlashIndex);
        }

        private void Swap_fleshes_Click(object sender, EventArgs e)
        {
            int flashIndex1 = Convert.ToInt32(textBox9.Text);
            int flashIndex2 = Convert.ToInt32(textBox10.Text);
            Flash temp = MasFlash[flashIndex1];
            MasFlash[flashIndex1] = MasFlash[flashIndex2];
            MasFlash[flashIndex2] = temp;
            UpdateDataGridViewAtIndex(flashIndex1);
            UpdateDataGridViewAtIndex(flashIndex2);
        }

        private void Find_Flash_Click(object sender, EventArgs e)
        {
            string name = textBox11.Text;
            for (int i = 0; i < MasFlash.Length; i++)
            {
                if (MasFlash[i] != null && MasFlash[i].Name == name)
                {
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                }
            }
        }
        private void Find_file_Click(object sender, EventArgs e)
        {
            string fileName = textBox12.Text;
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }
            bool fileFound = false;
            for (int i = 0; i < MasFlash.Length; i++)
            {
                if (MasFlash[i] != null &&  MasFlash[i].Files != null)
                {
                    for (int j = 0; j < MasFlash[i].FileCount; j++)
                    {
                        if (MasFlash[i].Files[j].Name == fileName)
                        {
                            MessageBox.Show($"File name: {MasFlash[i].Files[j].Name}\nSize: {MasFlash[i].Files[j].Size}\nFlash drive: {MasFlash[i].Name}");
                            fileFound = true;
                            break;
                        }
                        if (fileFound)
                        {
                            break;
                        }
                    }

                }
            }
            if (!fileFound)
                MessageBox.Show("File not found");
        }
        private void UpdateDataGridViewAtIndex(int flashIndex)
        {
            if (flashIndex >= 0 && flashIndex < MasFlash.Length)
            {
                int totalSize = 0;
                string names = "";
                Flash selectedFlash = MasFlash[flashIndex];
                for (int i = 0; i < selectedFlash.FileCount; i++)
                {
                    names += selectedFlash.Files[i].Name + "  ";
                    totalSize += selectedFlash.Files[i].Size;
                }
                dataGridView1.Rows[flashIndex].Cells[0].Value = MasFlash[flashIndex].Name;
                dataGridView1.Rows[flashIndex].Cells[1].Value = names;
                dataGridView1.Rows[flashIndex].Cells[2].Value = totalSize;
                dataGridView1.Rows[flashIndex].Cells[3].Value = selectedFlash.FileCount;
                dataGridView1.Rows[flashIndex].Cells[4].Value = MasFlash[flashIndex].MaxSize;
            }
        }

    }
}
