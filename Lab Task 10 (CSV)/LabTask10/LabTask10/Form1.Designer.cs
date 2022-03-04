namespace LabTask10
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
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.SearchIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.HireDateLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.ItemHeight = 16;
            this.EmployeeListBox.Location = new System.Drawing.Point(23, 31);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(426, 532);
            this.EmployeeListBox.TabIndex = 0;
            // 
            // SearchIDBox
            // 
            this.SearchIDBox.Location = new System.Drawing.Point(619, 87);
            this.SearchIDBox.Name = "SearchIDBox";
            this.SearchIDBox.Size = new System.Drawing.Size(183, 22);
            this.SearchIDBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(672, 143);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(557, 295);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(26, 16);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "ID: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(557, 263);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(50, 16);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name: ";
            // 
            // HireDateLabel
            // 
            this.HireDateLabel.AutoSize = true;
            this.HireDateLabel.Location = new System.Drawing.Point(557, 331);
            this.HireDateLabel.Name = "HireDateLabel";
            this.HireDateLabel.Size = new System.Drawing.Size(77, 16);
            this.HireDateLabel.TabIndex = 4;
            this.HireDateLabel.Text = "Hiring Date:";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(557, 365);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(49, 16);
            this.SalaryLabel.TabIndex = 4;
            this.SalaryLabel.Text = "Salary:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 607);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.HireDateLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchIDBox);
            this.Controls.Add(this.EmployeeListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.TextBox SearchIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label HireDateLabel;
        private System.Windows.Forms.Label SalaryLabel;
    }
}

