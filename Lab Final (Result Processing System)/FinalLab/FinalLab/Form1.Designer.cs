namespace FinalLab
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
            this.SearchResultTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AttendLabel = new System.Windows.Forms.Label();
            this.Quiz1Label = new System.Windows.Forms.Label();
            this.Quiz2Label = new System.Windows.Forms.Label();
            this.Quiz4Label = new System.Windows.Forms.Label();
            this.Quiz3Label = new System.Windows.Forms.Label();
            this.QuizTotal = new System.Windows.Forms.Label();
            this.MidLabel = new System.Windows.Forms.Label();
            this.FinalLabel = new System.Windows.Forms.Label();
            this.VivaLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchResultTB
            // 
            this.SearchResultTB.Location = new System.Drawing.Point(774, 55);
            this.SearchResultTB.Name = "SearchResultTB";
            this.SearchResultTB.Size = new System.Drawing.Size(100, 22);
            this.SearchResultTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(799, 97);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search by ID";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AttendLabel
            // 
            this.AttendLabel.AutoSize = true;
            this.AttendLabel.Location = new System.Drawing.Point(677, 154);
            this.AttendLabel.Name = "AttendLabel";
            this.AttendLabel.Size = new System.Drawing.Size(78, 16);
            this.AttendLabel.TabIndex = 3;
            this.AttendLabel.Text = "Attendance:";
            // 
            // Quiz1Label
            // 
            this.Quiz1Label.AutoSize = true;
            this.Quiz1Label.Location = new System.Drawing.Point(677, 183);
            this.Quiz1Label.Name = "Quiz1Label";
            this.Quiz1Label.Size = new System.Drawing.Size(46, 16);
            this.Quiz1Label.TabIndex = 3;
            this.Quiz1Label.Text = "Quiz 1:";
            // 
            // Quiz2Label
            // 
            this.Quiz2Label.AutoSize = true;
            this.Quiz2Label.Location = new System.Drawing.Point(677, 213);
            this.Quiz2Label.Name = "Quiz2Label";
            this.Quiz2Label.Size = new System.Drawing.Size(49, 16);
            this.Quiz2Label.TabIndex = 3;
            this.Quiz2Label.Text = "Quiz 2: ";
            // 
            // Quiz4Label
            // 
            this.Quiz4Label.AutoSize = true;
            this.Quiz4Label.Location = new System.Drawing.Point(677, 270);
            this.Quiz4Label.Name = "Quiz4Label";
            this.Quiz4Label.Size = new System.Drawing.Size(46, 16);
            this.Quiz4Label.TabIndex = 3;
            this.Quiz4Label.Text = "Quiz 4:";
            // 
            // Quiz3Label
            // 
            this.Quiz3Label.AutoSize = true;
            this.Quiz3Label.Location = new System.Drawing.Point(677, 241);
            this.Quiz3Label.Name = "Quiz3Label";
            this.Quiz3Label.Size = new System.Drawing.Size(46, 16);
            this.Quiz3Label.TabIndex = 3;
            this.Quiz3Label.Text = "Quiz 3:";
            // 
            // QuizTotal
            // 
            this.QuizTotal.AutoSize = true;
            this.QuizTotal.Location = new System.Drawing.Point(677, 298);
            this.QuizTotal.Name = "QuizTotal";
            this.QuizTotal.Size = new System.Drawing.Size(118, 16);
            this.QuizTotal.TabIndex = 3;
            this.QuizTotal.Text = "Quiz Total (Best 3):";
            // 
            // MidLabel
            // 
            this.MidLabel.AutoSize = true;
            this.MidLabel.Location = new System.Drawing.Point(677, 329);
            this.MidLabel.Name = "MidLabel";
            this.MidLabel.Size = new System.Drawing.Size(35, 16);
            this.MidLabel.TabIndex = 3;
            this.MidLabel.Text = "Mid: ";
            // 
            // FinalLabel
            // 
            this.FinalLabel.AutoSize = true;
            this.FinalLabel.Location = new System.Drawing.Point(677, 359);
            this.FinalLabel.Name = "FinalLabel";
            this.FinalLabel.Size = new System.Drawing.Size(42, 16);
            this.FinalLabel.TabIndex = 3;
            this.FinalLabel.Text = "Final: ";
            // 
            // VivaLabel
            // 
            this.VivaLabel.AutoSize = true;
            this.VivaLabel.Location = new System.Drawing.Point(677, 390);
            this.VivaLabel.Name = "VivaLabel";
            this.VivaLabel.Size = new System.Drawing.Size(40, 16);
            this.VivaLabel.TabIndex = 3;
            this.VivaLabel.Text = "Viva: ";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(677, 418);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(113, 16);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total (Out of 300): ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(754, 523);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Developed By: 200042143";
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(677, 448);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(59, 16);
            this.PercentLabel.TabIndex = 3;
            this.PercentLabel.Text = "Percent: ";
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.ItemHeight = 16;
            this.StudentListBox.Location = new System.Drawing.Point(41, 37);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(533, 516);
            this.StudentListBox.TabIndex = 4;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(677, 475);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(51, 16);
            this.GradeLabel.TabIndex = 3;
            this.GradeLabel.Text = "Grade: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 568);
            this.Controls.Add(this.StudentListBox);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.VivaLabel);
            this.Controls.Add(this.FinalLabel);
            this.Controls.Add(this.MidLabel);
            this.Controls.Add(this.QuizTotal);
            this.Controls.Add(this.Quiz3Label);
            this.Controls.Add(this.Quiz4Label);
            this.Controls.Add(this.Quiz2Label);
            this.Controls.Add(this.Quiz1Label);
            this.Controls.Add(this.AttendLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchResultTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchResultTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label AttendLabel;
        private System.Windows.Forms.Label Quiz1Label;
        private System.Windows.Forms.Label Quiz2Label;
        private System.Windows.Forms.Label Quiz4Label;
        private System.Windows.Forms.Label Quiz3Label;
        private System.Windows.Forms.Label QuizTotal;
        private System.Windows.Forms.Label MidLabel;
        private System.Windows.Forms.Label FinalLabel;
        private System.Windows.Forms.Label VivaLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.Label GradeLabel;
    }
}

