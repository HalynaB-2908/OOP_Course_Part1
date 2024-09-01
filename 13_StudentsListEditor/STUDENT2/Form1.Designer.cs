namespace STUDENT2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_stud_to_arr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.create_mas_std = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.find_student = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_stud_to_arr
            // 
            this.add_stud_to_arr.Location = new System.Drawing.Point(244, 99);
            this.add_stud_to_arr.Name = "add_stud_to_arr";
            this.add_stud_to_arr.Size = new System.Drawing.Size(153, 48);
            this.add_stud_to_arr.TabIndex = 0;
            this.add_stud_to_arr.Text = "Add student to arr";
            this.add_stud_to_arr.UseVisualStyleBackColor = true;
            this.add_stud_to_arr.Click += new System.EventHandler(this.add_stud_to_arr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "-> student`s name";
            // 
            // create_mas_std
            // 
            this.create_mas_std.Location = new System.Drawing.Point(35, 99);
            this.create_mas_std.Name = "create_mas_std";
            this.create_mas_std.Size = new System.Drawing.Size(194, 48);
            this.create_mas_std.TabIndex = 2;
            this.create_mas_std.Text = "Create arr students";
            this.create_mas_std.UseVisualStyleBackColor = true;
            this.create_mas_std.Click += new System.EventHandler(this.create_mas_std_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(672, 307);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "-> count of students";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 26);
            this.textBox2.TabIndex = 6;
            // 
            // find_student
            // 
            this.find_student.Location = new System.Drawing.Point(35, 218);
            this.find_student.Name = "find_student";
            this.find_student.Size = new System.Drawing.Size(175, 45);
            this.find_student.TabIndex = 7;
            this.find_student.Text = "Find student";
            this.find_student.UseVisualStyleBackColor = true;
            this.find_student.Click += new System.EventHandler(this.find_student_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Edit student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.find_student);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.create_mas_std);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_stud_to_arr);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_stud_to_arr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_mas_std;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button find_student;
        private System.Windows.Forms.Button button2;
    }
}

