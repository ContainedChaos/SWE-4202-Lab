namespace LabTask1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentNameBox = new System.Windows.Forms.TextBox();
            this.StudentIDBox = new System.Windows.Forms.TextBox();
            this.StudentDeptBox = new System.Windows.Forms.TextBox();
            this.SemesterBox = new System.Windows.Forms.TextBox();
            this.ClearOnClick = new System.Windows.Forms.Button();
            this.SaveOnClick = new System.Windows.Forms.Button();
            this.StudentList = new System.Windows.Forms.ListBox();
            this.ShowStudentListOnClick = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TeacherDesignBox = new System.Windows.Forms.TextBox();
            this.TeacherDeptBox = new System.Windows.Forms.TextBox();
            this.TeacherIDBox = new System.Windows.Forms.TextBox();
            this.TeacherNameBox = new System.Windows.Forms.TextBox();
            this.TeacherSalaryBox = new System.Windows.Forms.TextBox();
            this.ClearOnClick2 = new System.Windows.Forms.Button();
            this.SaveOnClick2 = new System.Windows.Forms.Button();
            this.TeacherList = new System.Windows.Forms.ListBox();
            this.ShowOnClick2 = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AdminDesignBox = new System.Windows.Forms.TextBox();
            this.AdminSalaryBox = new System.Windows.Forms.TextBox();
            this.AdminIDBox = new System.Windows.Forms.TextBox();
            this.AdminNameBox = new System.Windows.Forms.TextBox();
            this.ClearOnClick3 = new System.Windows.Forms.Button();
            this.SaveOnClick3 = new System.Windows.Forms.Button();
            this.ShowOnClick3 = new System.Windows.Forms.Button();
            this.AdminList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dept";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester";
            // 
            // StudentNameBox
            // 
            this.StudentNameBox.Location = new System.Drawing.Point(101, 66);
            this.StudentNameBox.Name = "StudentNameBox";
            this.StudentNameBox.Size = new System.Drawing.Size(132, 22);
            this.StudentNameBox.TabIndex = 4;
            this.StudentNameBox.TextChanged += new System.EventHandler(this.StudentNameBox_TextChanged);
            // 
            // StudentIDBox
            // 
            this.StudentIDBox.Location = new System.Drawing.Point(101, 105);
            this.StudentIDBox.Name = "StudentIDBox";
            this.StudentIDBox.Size = new System.Drawing.Size(132, 22);
            this.StudentIDBox.TabIndex = 5;
            // 
            // StudentDeptBox
            // 
            this.StudentDeptBox.Location = new System.Drawing.Point(101, 150);
            this.StudentDeptBox.Name = "StudentDeptBox";
            this.StudentDeptBox.Size = new System.Drawing.Size(132, 22);
            this.StudentDeptBox.TabIndex = 6;
            this.StudentDeptBox.TextChanged += new System.EventHandler(this.StudentDeptBox_TextChanged);
            // 
            // SemesterBox
            // 
            this.SemesterBox.Location = new System.Drawing.Point(101, 199);
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Size = new System.Drawing.Size(132, 22);
            this.SemesterBox.TabIndex = 7;
            // 
            // ClearOnClick
            // 
            this.ClearOnClick.Location = new System.Drawing.Point(48, 354);
            this.ClearOnClick.Name = "ClearOnClick";
            this.ClearOnClick.Size = new System.Drawing.Size(75, 23);
            this.ClearOnClick.TabIndex = 8;
            this.ClearOnClick.Text = "Clear";
            this.ClearOnClick.UseVisualStyleBackColor = true;
            this.ClearOnClick.Click += new System.EventHandler(this.ClearOnClick_Click);
            // 
            // SaveOnClick
            // 
            this.SaveOnClick.Location = new System.Drawing.Point(146, 354);
            this.SaveOnClick.Name = "SaveOnClick";
            this.SaveOnClick.Size = new System.Drawing.Size(75, 23);
            this.SaveOnClick.TabIndex = 9;
            this.SaveOnClick.Text = "Save";
            this.SaveOnClick.UseVisualStyleBackColor = true;
            this.SaveOnClick.Click += new System.EventHandler(this.SaveOnClick_Click);
            // 
            // StudentList
            // 
            this.StudentList.FormattingEnabled = true;
            this.StudentList.ItemHeight = 16;
            this.StudentList.Location = new System.Drawing.Point(251, 51);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(254, 180);
            this.StudentList.TabIndex = 10;
            // 
            // ShowStudentListOnClick
            // 
            this.ShowStudentListOnClick.Location = new System.Drawing.Point(355, 354);
            this.ShowStudentListOnClick.Name = "ShowStudentListOnClick";
            this.ShowStudentListOnClick.Size = new System.Drawing.Size(75, 23);
            this.ShowStudentListOnClick.TabIndex = 11;
            this.ShowStudentListOnClick.Text = "Show";
            this.ShowStudentListOnClick.UseVisualStyleBackColor = true;
            this.ShowStudentListOnClick.Click += new System.EventHandler(this.ShowStudentListOnClick_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(21, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(200, 25);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Student Information";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel2.Location = new System.Drawing.Point(531, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(205, 25);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Teacher Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dept";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Designation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Salary";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TeacherDesignBox
            // 
            this.TeacherDesignBox.Location = new System.Drawing.Point(627, 195);
            this.TeacherDesignBox.Name = "TeacherDesignBox";
            this.TeacherDesignBox.Size = new System.Drawing.Size(138, 22);
            this.TeacherDesignBox.TabIndex = 19;
            this.TeacherDesignBox.TextChanged += new System.EventHandler(this.TeacherDesignBox_TextChanged);
            // 
            // TeacherDeptBox
            // 
            this.TeacherDeptBox.Location = new System.Drawing.Point(627, 156);
            this.TeacherDeptBox.Name = "TeacherDeptBox";
            this.TeacherDeptBox.Size = new System.Drawing.Size(138, 22);
            this.TeacherDeptBox.TabIndex = 20;
            // 
            // TeacherIDBox
            // 
            this.TeacherIDBox.Location = new System.Drawing.Point(627, 112);
            this.TeacherIDBox.Name = "TeacherIDBox";
            this.TeacherIDBox.Size = new System.Drawing.Size(138, 22);
            this.TeacherIDBox.TabIndex = 21;
            // 
            // TeacherNameBox
            // 
            this.TeacherNameBox.Location = new System.Drawing.Point(627, 66);
            this.TeacherNameBox.Name = "TeacherNameBox";
            this.TeacherNameBox.Size = new System.Drawing.Size(138, 22);
            this.TeacherNameBox.TabIndex = 22;
            // 
            // TeacherSalaryBox
            // 
            this.TeacherSalaryBox.Location = new System.Drawing.Point(627, 239);
            this.TeacherSalaryBox.Name = "TeacherSalaryBox";
            this.TeacherSalaryBox.Size = new System.Drawing.Size(138, 22);
            this.TeacherSalaryBox.TabIndex = 23;
            this.TeacherSalaryBox.TextChanged += new System.EventHandler(this.TeacherSalaryBox_TextChanged);
            // 
            // ClearOnClick2
            // 
            this.ClearOnClick2.Location = new System.Drawing.Point(562, 354);
            this.ClearOnClick2.Name = "ClearOnClick2";
            this.ClearOnClick2.Size = new System.Drawing.Size(75, 23);
            this.ClearOnClick2.TabIndex = 24;
            this.ClearOnClick2.Text = "Clear";
            this.ClearOnClick2.UseVisualStyleBackColor = true;
            this.ClearOnClick2.Click += new System.EventHandler(this.ClearOnClick2_Click);
            // 
            // SaveOnClick2
            // 
            this.SaveOnClick2.Location = new System.Drawing.Point(661, 354);
            this.SaveOnClick2.Name = "SaveOnClick2";
            this.SaveOnClick2.Size = new System.Drawing.Size(75, 23);
            this.SaveOnClick2.TabIndex = 25;
            this.SaveOnClick2.Text = "Save";
            this.SaveOnClick2.UseVisualStyleBackColor = true;
            this.SaveOnClick2.Click += new System.EventHandler(this.SaveOnClick2_Click);
            // 
            // TeacherList
            // 
            this.TeacherList.FormattingEnabled = true;
            this.TeacherList.ItemHeight = 16;
            this.TeacherList.Location = new System.Drawing.Point(783, 51);
            this.TeacherList.Name = "TeacherList";
            this.TeacherList.Size = new System.Drawing.Size(264, 180);
            this.TeacherList.TabIndex = 26;
            // 
            // ShowOnClick2
            // 
            this.ShowOnClick2.Location = new System.Drawing.Point(884, 354);
            this.ShowOnClick2.Name = "ShowOnClick2";
            this.ShowOnClick2.Size = new System.Drawing.Size(75, 23);
            this.ShowOnClick2.TabIndex = 27;
            this.ShowOnClick2.Text = "Show";
            this.ShowOnClick2.UseVisualStyleBackColor = true;
            this.ShowOnClick2.Click += new System.EventHandler(this.ShowOnClick2_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(1071, 13);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(186, 25);
            this.linkLabel3.TabIndex = 28;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Admin Information";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1076, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1076, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1076, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Designation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1076, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "Salary";
            // 
            // AdminDesignBox
            // 
            this.AdminDesignBox.Location = new System.Drawing.Point(1171, 153);
            this.AdminDesignBox.Name = "AdminDesignBox";
            this.AdminDesignBox.Size = new System.Drawing.Size(144, 22);
            this.AdminDesignBox.TabIndex = 34;
            // 
            // AdminSalaryBox
            // 
            this.AdminSalaryBox.Location = new System.Drawing.Point(1171, 191);
            this.AdminSalaryBox.Name = "AdminSalaryBox";
            this.AdminSalaryBox.Size = new System.Drawing.Size(144, 22);
            this.AdminSalaryBox.TabIndex = 35;
            // 
            // AdminIDBox
            // 
            this.AdminIDBox.Location = new System.Drawing.Point(1171, 112);
            this.AdminIDBox.Name = "AdminIDBox";
            this.AdminIDBox.Size = new System.Drawing.Size(144, 22);
            this.AdminIDBox.TabIndex = 36;
            // 
            // AdminNameBox
            // 
            this.AdminNameBox.Location = new System.Drawing.Point(1171, 65);
            this.AdminNameBox.Name = "AdminNameBox";
            this.AdminNameBox.Size = new System.Drawing.Size(144, 22);
            this.AdminNameBox.TabIndex = 37;
            // 
            // ClearOnClick3
            // 
            this.ClearOnClick3.Location = new System.Drawing.Point(1110, 354);
            this.ClearOnClick3.Name = "ClearOnClick3";
            this.ClearOnClick3.Size = new System.Drawing.Size(75, 23);
            this.ClearOnClick3.TabIndex = 38;
            this.ClearOnClick3.Text = "Clear";
            this.ClearOnClick3.UseVisualStyleBackColor = true;
            this.ClearOnClick3.Click += new System.EventHandler(this.ClearOnClick3_Click);
            // 
            // SaveOnClick3
            // 
            this.SaveOnClick3.Location = new System.Drawing.Point(1209, 354);
            this.SaveOnClick3.Name = "SaveOnClick3";
            this.SaveOnClick3.Size = new System.Drawing.Size(75, 23);
            this.SaveOnClick3.TabIndex = 39;
            this.SaveOnClick3.Text = "Save";
            this.SaveOnClick3.UseVisualStyleBackColor = true;
            this.SaveOnClick3.Click += new System.EventHandler(this.SaveOnClick3_Click);
            // 
            // ShowOnClick3
            // 
            this.ShowOnClick3.Location = new System.Drawing.Point(1445, 353);
            this.ShowOnClick3.Name = "ShowOnClick3";
            this.ShowOnClick3.Size = new System.Drawing.Size(75, 23);
            this.ShowOnClick3.TabIndex = 40;
            this.ShowOnClick3.Text = "Show";
            this.ShowOnClick3.UseVisualStyleBackColor = true;
            this.ShowOnClick3.Click += new System.EventHandler(this.ShowOnClick3_Click);
            // 
            // AdminList
            // 
            this.AdminList.FormattingEnabled = true;
            this.AdminList.ItemHeight = 16;
            this.AdminList.Location = new System.Drawing.Point(1334, 51);
            this.AdminList.Name = "AdminList";
            this.AdminList.Size = new System.Drawing.Size(244, 180);
            this.AdminList.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 450);
            this.Controls.Add(this.AdminList);
            this.Controls.Add(this.ShowOnClick3);
            this.Controls.Add(this.SaveOnClick3);
            this.Controls.Add(this.ClearOnClick3);
            this.Controls.Add(this.AdminNameBox);
            this.Controls.Add(this.AdminIDBox);
            this.Controls.Add(this.AdminSalaryBox);
            this.Controls.Add(this.AdminDesignBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.ShowOnClick2);
            this.Controls.Add(this.TeacherList);
            this.Controls.Add(this.SaveOnClick2);
            this.Controls.Add(this.ClearOnClick2);
            this.Controls.Add(this.TeacherSalaryBox);
            this.Controls.Add(this.TeacherNameBox);
            this.Controls.Add(this.TeacherIDBox);
            this.Controls.Add(this.TeacherDeptBox);
            this.Controls.Add(this.TeacherDesignBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ShowStudentListOnClick);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.SaveOnClick);
            this.Controls.Add(this.ClearOnClick);
            this.Controls.Add(this.SemesterBox);
            this.Controls.Add(this.StudentDeptBox);
            this.Controls.Add(this.StudentIDBox);
            this.Controls.Add(this.StudentNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentNameBox;
        private System.Windows.Forms.TextBox StudentIDBox;
        private System.Windows.Forms.TextBox StudentDeptBox;
        private System.Windows.Forms.TextBox SemesterBox;
        private System.Windows.Forms.Button ClearOnClick;
        private System.Windows.Forms.Button SaveOnClick;
        private System.Windows.Forms.ListBox StudentList;
        private System.Windows.Forms.Button ShowStudentListOnClick;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TeacherDesignBox;
        private System.Windows.Forms.TextBox TeacherDeptBox;
        private System.Windows.Forms.TextBox TeacherIDBox;
        private System.Windows.Forms.TextBox TeacherNameBox;
        private System.Windows.Forms.TextBox TeacherSalaryBox;
        private System.Windows.Forms.Button ClearOnClick2;
        private System.Windows.Forms.Button SaveOnClick2;
        private System.Windows.Forms.ListBox TeacherList;
        private System.Windows.Forms.Button ShowOnClick2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AdminDesignBox;
        private System.Windows.Forms.TextBox AdminSalaryBox;
        private System.Windows.Forms.TextBox AdminIDBox;
        private System.Windows.Forms.TextBox AdminNameBox;
        private System.Windows.Forms.Button ClearOnClick3;
        private System.Windows.Forms.Button SaveOnClick3;
        private System.Windows.Forms.Button ShowOnClick3;
        private System.Windows.Forms.ListBox AdminList;
    }
}

