using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Records
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Student class definition
        class Student
        {
            public string LastName; // Student's last name
            private int exam1, exam2, exam3; // Exam scores

            public double AvgScore // Average score property
            {
                get { return (exam1 + exam2 + exam3) / 3.0; }
            }

            // Exam1 property with validation
            public int Exam1
            {
                set { if (value > 0 && value <= 5) exam1 = value; }
                get { return exam1; }
            }

            // Exam2 property with validation
            public int Exam2
            {
                set { if (value > 0 && value <= 5) exam2 = value; }
                get { return exam2; }
            }

            // Exam3 property with validation
            public int Exam3
            {
                set { if (value > 0 && value <= 5) exam3 = value; }
                get { return exam3; }
            }

            // Default constructor
            public Student() { }

            // Constructor with parameters
            public Student(int x1, int x2, int x3)
            {
                exam1 = x1;
                exam2 = x2;
                exam3 = x3;
            }
        }

        // Button click event to display student's average score
        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.LastName = textBox1.Text;
            stud.Exam1 = Convert.ToInt32(textBox2.Text);
            stud.Exam2 = Convert.ToInt32(textBox3.Text);
            stud.Exam3 = Convert.ToInt32(textBox4.Text);
            label5.Text = stud.LastName + " " + stud.AvgScore.ToString("F2"); // Display average score with 2 decimal places
        }

        Student studWithParams;

        // Button click event to create a student with provided parameters and display their average score
        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox2.Text);
            int x2 = Convert.ToInt32(textBox3.Text);
            int x3 = Convert.ToInt32(textBox4.Text);
            studWithParams = new Student(x1, x2, x3);
            studWithParams.LastName = textBox1.Text;
            MessageBox.Show(studWithParams.LastName + " " + studWithParams.AvgScore.ToString("F2"));
        }

        Student[] studArray;
        int currStudInd = 0;
        int maxStudCount = 10;

        // Button click event to initialize the students array and configure DataGridView
        private void button4_Click(object sender, EventArgs e)
        {
            studArray = new Student[maxStudCount];
            dataGridView1.RowCount = maxStudCount;
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
        }

        // Button click event to add a student to the array and display in DataGridView
        private void button3_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.LastName = textBox1.Text;
            stud.Exam1 = Convert.ToInt32(textBox2.Text);
            stud.Exam2 = Convert.ToInt32(textBox3.Text);
            stud.Exam3 = Convert.ToInt32(textBox4.Text);
            studArray[currStudInd] = stud;
            dataGridView1.Rows[currStudInd].Cells[0].Value = studArray[currStudInd].LastName;
            dataGridView1.Rows[currStudInd].Cells[1].Value = studArray[currStudInd].Exam1;
            dataGridView1.Rows[currStudInd].Cells[2].Value = studArray[currStudInd].Exam2;
            dataGridView1.Rows[currStudInd].Cells[3].Value = studArray[currStudInd].Exam3;
            dataGridView1.Rows[currStudInd].Cells[4].Value = studArray[currStudInd].AvgScore.ToString("F2");
            currStudInd++;
        }

        // Button click event to find and display the student with the highest average score
        private void button5_Click(object sender, EventArgs e)
        {
            if (studArray != null && currStudInd > 0)
            {
                Student topStud = studArray[0];

                for (int i = 1; i < currStudInd; i++)
                {
                    if (studArray[i].AvgScore > topStud.AvgScore)
                        topStud = studArray[i];
                }
                MessageBox.Show("Student with the highest average score: " + topStud.LastName + ", Score: " + topStud.AvgScore.ToString("F2"));
            }
            else
                MessageBox.Show("The student array is empty.");
        }
    }
}