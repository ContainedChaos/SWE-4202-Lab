namespace LabTask6
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
            this.OrderIDSSBox = new System.Windows.Forms.TextBox();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.SetStatusButton = new System.Windows.Forms.Button();
            this.CurrBalanceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserIDBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.UserAddressBox = new System.Windows.Forms.TextBox();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UserIDPOBox = new System.Windows.Forms.TextBox();
            this.ShirtQuantBox = new System.Windows.Forms.TextBox();
            this.PantQuantBox = new System.Windows.Forms.TextBox();
            this.SuitQuantBox = new System.Windows.Forms.TextBox();
            this.SheetQuantBox = new System.Windows.Forms.TextBox();
            this.ShirtOrderComboBox = new System.Windows.Forms.ComboBox();
            this.PantOrderComboBox = new System.Windows.Forms.ComboBox();
            this.SuitsOrderComboBox = new System.Windows.Forms.ComboBox();
            this.SheetOrderComboBox = new System.Windows.Forms.ComboBox();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.ShowStatusLabel = new System.Windows.Forms.Label();
            this.ShowAmountLabel = new System.Windows.Forms.Label();
            this.OrderIDSeeDeetsBox = new System.Windows.Forms.TextBox();
            this.ShowDetailsButton = new System.Windows.Forms.Button();
            this.OrderDetailsBox = new System.Windows.Forms.ListBox();
            this.ShowNameLabel = new System.Windows.Forms.Label();
            this.ShowAddressLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ShirtQuantityLabel = new System.Windows.Forms.Label();
            this.PantQuantityLabel = new System.Windows.Forms.Label();
            this.SuitQuantityLabel = new System.Windows.Forms.Label();
            this.SheetQuantityLabel = new System.Windows.Forms.Label();
            this.ShirtCondLabel = new System.Windows.Forms.Label();
            this.PantCondLabel = new System.Windows.Forms.Label();
            this.SuitCondLabel = new System.Windows.Forms.Label();
            this.SheetCondLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID";
            // 
            // OrderIDSSBox
            // 
            this.OrderIDSSBox.Location = new System.Drawing.Point(103, 83);
            this.OrderIDSSBox.Name = "OrderIDSSBox";
            this.OrderIDSSBox.Size = new System.Drawing.Size(136, 22);
            this.OrderIDSSBox.TabIndex = 1;
            // 
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Delivered"});
            this.OrderStatusComboBox.Location = new System.Drawing.Point(245, 83);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.OrderStatusComboBox.TabIndex = 2;
            // 
            // SetStatusButton
            // 
            this.SetStatusButton.Location = new System.Drawing.Point(372, 84);
            this.SetStatusButton.Name = "SetStatusButton";
            this.SetStatusButton.Size = new System.Drawing.Size(141, 23);
            this.SetStatusButton.TabIndex = 3;
            this.SetStatusButton.Text = "Set Status";
            this.SetStatusButton.UseVisualStyleBackColor = true;
            this.SetStatusButton.Click += new System.EventHandler(this.SetStatusButton_Click);
            // 
            // CurrBalanceLabel
            // 
            this.CurrBalanceLabel.AutoSize = true;
            this.CurrBalanceLabel.Location = new System.Drawing.Point(37, 124);
            this.CurrBalanceLabel.Name = "CurrBalanceLabel";
            this.CurrBalanceLabel.Size = new System.Drawing.Size(105, 16);
            this.CurrBalanceLabel.TabIndex = 4;
            this.CurrBalanceLabel.Text = "Current Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // UserIDBox
            // 
            this.UserIDBox.Location = new System.Drawing.Point(689, 80);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.Size = new System.Drawing.Size(123, 22);
            this.UserIDBox.TabIndex = 8;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(689, 114);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(123, 22);
            this.UserNameBox.TabIndex = 9;
            // 
            // UserAddressBox
            // 
            this.UserAddressBox.Location = new System.Drawing.Point(689, 146);
            this.UserAddressBox.Name = "UserAddressBox";
            this.UserAddressBox.Size = new System.Drawing.Size(123, 22);
            this.UserAddressBox.TabIndex = 10;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(840, 80);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(75, 82);
            this.CreateAccountButton.TabIndex = 11;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(948, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "User ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(948, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Shirts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(948, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pants";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(948, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Suits";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(948, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Bedsheets";
            // 
            // UserIDPOBox
            // 
            this.UserIDPOBox.Location = new System.Drawing.Point(1019, 82);
            this.UserIDPOBox.Name = "UserIDPOBox";
            this.UserIDPOBox.Size = new System.Drawing.Size(116, 22);
            this.UserIDPOBox.TabIndex = 17;
            // 
            // ShirtQuantBox
            // 
            this.ShirtQuantBox.Location = new System.Drawing.Point(1019, 111);
            this.ShirtQuantBox.Name = "ShirtQuantBox";
            this.ShirtQuantBox.Size = new System.Drawing.Size(116, 22);
            this.ShirtQuantBox.TabIndex = 18;
            // 
            // PantQuantBox
            // 
            this.PantQuantBox.Location = new System.Drawing.Point(1019, 143);
            this.PantQuantBox.Name = "PantQuantBox";
            this.PantQuantBox.Size = new System.Drawing.Size(116, 22);
            this.PantQuantBox.TabIndex = 19;
            // 
            // SuitQuantBox
            // 
            this.SuitQuantBox.Location = new System.Drawing.Point(1019, 173);
            this.SuitQuantBox.Name = "SuitQuantBox";
            this.SuitQuantBox.Size = new System.Drawing.Size(116, 22);
            this.SuitQuantBox.TabIndex = 20;
            // 
            // SheetQuantBox
            // 
            this.SheetQuantBox.Location = new System.Drawing.Point(1019, 204);
            this.SheetQuantBox.Name = "SheetQuantBox";
            this.SheetQuantBox.Size = new System.Drawing.Size(116, 22);
            this.SheetQuantBox.TabIndex = 21;
            // 
            // ShirtOrderComboBox
            // 
            this.ShirtOrderComboBox.FormattingEnabled = true;
            this.ShirtOrderComboBox.Items.AddRange(new object[] {
            "Wash",
            "Iron",
            "Both"});
            this.ShirtOrderComboBox.Location = new System.Drawing.Point(1141, 110);
            this.ShirtOrderComboBox.Name = "ShirtOrderComboBox";
            this.ShirtOrderComboBox.Size = new System.Drawing.Size(121, 24);
            this.ShirtOrderComboBox.TabIndex = 22;
            // 
            // PantOrderComboBox
            // 
            this.PantOrderComboBox.FormattingEnabled = true;
            this.PantOrderComboBox.Items.AddRange(new object[] {
            "Wash",
            "Iron",
            "Both"});
            this.PantOrderComboBox.Location = new System.Drawing.Point(1141, 140);
            this.PantOrderComboBox.Name = "PantOrderComboBox";
            this.PantOrderComboBox.Size = new System.Drawing.Size(121, 24);
            this.PantOrderComboBox.TabIndex = 23;
            // 
            // SuitsOrderComboBox
            // 
            this.SuitsOrderComboBox.FormattingEnabled = true;
            this.SuitsOrderComboBox.Items.AddRange(new object[] {
            "Wash",
            "Iron",
            "Both"});
            this.SuitsOrderComboBox.Location = new System.Drawing.Point(1142, 170);
            this.SuitsOrderComboBox.Name = "SuitsOrderComboBox";
            this.SuitsOrderComboBox.Size = new System.Drawing.Size(121, 24);
            this.SuitsOrderComboBox.TabIndex = 24;
            // 
            // SheetOrderComboBox
            // 
            this.SheetOrderComboBox.FormattingEnabled = true;
            this.SheetOrderComboBox.Items.AddRange(new object[] {
            "Wash",
            "Iron",
            "Both"});
            this.SheetOrderComboBox.Location = new System.Drawing.Point(1142, 201);
            this.SheetOrderComboBox.Name = "SheetOrderComboBox";
            this.SheetOrderComboBox.Size = new System.Drawing.Size(121, 24);
            this.SheetOrderComboBox.TabIndex = 25;
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Location = new System.Drawing.Point(1063, 242);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(150, 23);
            this.PlaceOrderButton.TabIndex = 26;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(315, 361);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 16);
            this.label.TabIndex = 27;
            this.label.Text = "Order ID";
            // 
            // ShowStatusLabel
            // 
            this.ShowStatusLabel.AutoSize = true;
            this.ShowStatusLabel.Location = new System.Drawing.Point(315, 405);
            this.ShowStatusLabel.Name = "ShowStatusLabel";
            this.ShowStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.ShowStatusLabel.TabIndex = 28;
            this.ShowStatusLabel.Text = "Status:";
            // 
            // ShowAmountLabel
            // 
            this.ShowAmountLabel.AutoSize = true;
            this.ShowAmountLabel.Location = new System.Drawing.Point(315, 433);
            this.ShowAmountLabel.Name = "ShowAmountLabel";
            this.ShowAmountLabel.Size = new System.Drawing.Size(55, 16);
            this.ShowAmountLabel.TabIndex = 29;
            this.ShowAmountLabel.Text = "Amount:";
            // 
            // OrderIDSeeDeetsBox
            // 
            this.OrderIDSeeDeetsBox.Location = new System.Drawing.Point(393, 358);
            this.OrderIDSeeDeetsBox.Name = "OrderIDSeeDeetsBox";
            this.OrderIDSeeDeetsBox.Size = new System.Drawing.Size(120, 22);
            this.OrderIDSeeDeetsBox.TabIndex = 30;
            // 
            // ShowDetailsButton
            // 
            this.ShowDetailsButton.Location = new System.Drawing.Point(318, 470);
            this.ShowDetailsButton.Name = "ShowDetailsButton";
            this.ShowDetailsButton.Size = new System.Drawing.Size(195, 89);
            this.ShowDetailsButton.TabIndex = 31;
            this.ShowDetailsButton.Text = "See Order Details";
            this.ShowDetailsButton.UseVisualStyleBackColor = true;
            this.ShowDetailsButton.Click += new System.EventHandler(this.ShowDetailsButton_Click);
            // 
            // OrderDetailsBox
            // 
            this.OrderDetailsBox.FormattingEnabled = true;
            this.OrderDetailsBox.ItemHeight = 16;
            this.OrderDetailsBox.Location = new System.Drawing.Point(533, 358);
            this.OrderDetailsBox.Name = "OrderDetailsBox";
            this.OrderDetailsBox.Size = new System.Drawing.Size(403, 196);
            this.OrderDetailsBox.TabIndex = 32;
            // 
            // ShowNameLabel
            // 
            this.ShowNameLabel.AutoSize = true;
            this.ShowNameLabel.Location = new System.Drawing.Point(951, 405);
            this.ShowNameLabel.Name = "ShowNameLabel";
            this.ShowNameLabel.Size = new System.Drawing.Size(47, 16);
            this.ShowNameLabel.TabIndex = 33;
            this.ShowNameLabel.Text = "Name:";
            // 
            // ShowAddressLabel
            // 
            this.ShowAddressLabel.AutoSize = true;
            this.ShowAddressLabel.Location = new System.Drawing.Point(951, 433);
            this.ShowAddressLabel.Name = "ShowAddressLabel";
            this.ShowAddressLabel.Size = new System.Drawing.Size(58, 16);
            this.ShowAddressLabel.TabIndex = 34;
            this.ShowAddressLabel.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(544, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Item";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(676, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(811, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "To Do";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(543, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Shirt";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(544, 470);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "Pant";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(544, 497);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 16);
            this.label15.TabIndex = 40;
            this.label15.Text = "Suit";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(544, 524);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Bedsheet";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(543, 408);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(283, 16);
            this.label17.TabIndex = 42;
            this.label17.Text = "................................................................................." +
    "...........";
            // 
            // ShirtQuantityLabel
            // 
            this.ShirtQuantityLabel.AutoSize = true;
            this.ShirtQuantityLabel.BackColor = System.Drawing.Color.White;
            this.ShirtQuantityLabel.Location = new System.Drawing.Point(679, 442);
            this.ShirtQuantityLabel.Name = "ShirtQuantityLabel";
            this.ShirtQuantityLabel.Size = new System.Drawing.Size(11, 16);
            this.ShirtQuantityLabel.TabIndex = 43;
            this.ShirtQuantityLabel.Text = "-";
            // 
            // PantQuantityLabel
            // 
            this.PantQuantityLabel.AutoSize = true;
            this.PantQuantityLabel.BackColor = System.Drawing.Color.White;
            this.PantQuantityLabel.Location = new System.Drawing.Point(679, 470);
            this.PantQuantityLabel.Name = "PantQuantityLabel";
            this.PantQuantityLabel.Size = new System.Drawing.Size(11, 16);
            this.PantQuantityLabel.TabIndex = 44;
            this.PantQuantityLabel.Text = "-";
            // 
            // SuitQuantityLabel
            // 
            this.SuitQuantityLabel.AutoSize = true;
            this.SuitQuantityLabel.BackColor = System.Drawing.Color.White;
            this.SuitQuantityLabel.Location = new System.Drawing.Point(679, 497);
            this.SuitQuantityLabel.Name = "SuitQuantityLabel";
            this.SuitQuantityLabel.Size = new System.Drawing.Size(11, 16);
            this.SuitQuantityLabel.TabIndex = 45;
            this.SuitQuantityLabel.Text = "-";
            // 
            // SheetQuantityLabel
            // 
            this.SheetQuantityLabel.AutoSize = true;
            this.SheetQuantityLabel.BackColor = System.Drawing.Color.White;
            this.SheetQuantityLabel.Location = new System.Drawing.Point(679, 524);
            this.SheetQuantityLabel.Name = "SheetQuantityLabel";
            this.SheetQuantityLabel.Size = new System.Drawing.Size(11, 16);
            this.SheetQuantityLabel.TabIndex = 46;
            this.SheetQuantityLabel.Text = "-";
            // 
            // ShirtCondLabel
            // 
            this.ShirtCondLabel.AutoSize = true;
            this.ShirtCondLabel.BackColor = System.Drawing.Color.White;
            this.ShirtCondLabel.Location = new System.Drawing.Point(811, 442);
            this.ShirtCondLabel.Name = "ShirtCondLabel";
            this.ShirtCondLabel.Size = new System.Drawing.Size(11, 16);
            this.ShirtCondLabel.TabIndex = 47;
            this.ShirtCondLabel.Text = "-";
            // 
            // PantCondLabel
            // 
            this.PantCondLabel.AutoSize = true;
            this.PantCondLabel.BackColor = System.Drawing.Color.White;
            this.PantCondLabel.Location = new System.Drawing.Point(811, 470);
            this.PantCondLabel.Name = "PantCondLabel";
            this.PantCondLabel.Size = new System.Drawing.Size(11, 16);
            this.PantCondLabel.TabIndex = 48;
            this.PantCondLabel.Text = "-";
            // 
            // SuitCondLabel
            // 
            this.SuitCondLabel.AutoSize = true;
            this.SuitCondLabel.BackColor = System.Drawing.Color.White;
            this.SuitCondLabel.Location = new System.Drawing.Point(811, 497);
            this.SuitCondLabel.Name = "SuitCondLabel";
            this.SuitCondLabel.Size = new System.Drawing.Size(11, 16);
            this.SuitCondLabel.TabIndex = 49;
            this.SuitCondLabel.Text = "-";
            // 
            // SheetCondLabel
            // 
            this.SheetCondLabel.AutoSize = true;
            this.SheetCondLabel.BackColor = System.Drawing.Color.White;
            this.SheetCondLabel.Location = new System.Drawing.Point(811, 524);
            this.SheetCondLabel.Name = "SheetCondLabel";
            this.SheetCondLabel.Size = new System.Drawing.Size(11, 16);
            this.SheetCondLabel.TabIndex = 50;
            this.SheetCondLabel.Text = "-";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(241, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 20);
            this.linkLabel1.TabIndex = 51;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Owner Section";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(882, 42);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(118, 20);
            this.linkLabel2.TabIndex = 52;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "User Section";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(528, 9);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(299, 25);
            this.linkLabel3.TabIndex = 53;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Laundry Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 697);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SheetCondLabel);
            this.Controls.Add(this.SuitCondLabel);
            this.Controls.Add(this.PantCondLabel);
            this.Controls.Add(this.ShirtCondLabel);
            this.Controls.Add(this.SheetQuantityLabel);
            this.Controls.Add(this.SuitQuantityLabel);
            this.Controls.Add(this.PantQuantityLabel);
            this.Controls.Add(this.ShirtQuantityLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowAddressLabel);
            this.Controls.Add(this.ShowNameLabel);
            this.Controls.Add(this.OrderDetailsBox);
            this.Controls.Add(this.ShowDetailsButton);
            this.Controls.Add(this.OrderIDSeeDeetsBox);
            this.Controls.Add(this.ShowAmountLabel);
            this.Controls.Add(this.ShowStatusLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(this.SheetOrderComboBox);
            this.Controls.Add(this.SuitsOrderComboBox);
            this.Controls.Add(this.PantOrderComboBox);
            this.Controls.Add(this.ShirtOrderComboBox);
            this.Controls.Add(this.SheetQuantBox);
            this.Controls.Add(this.SuitQuantBox);
            this.Controls.Add(this.PantQuantBox);
            this.Controls.Add(this.ShirtQuantBox);
            this.Controls.Add(this.UserIDPOBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.UserAddressBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.UserIDBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurrBalanceLabel);
            this.Controls.Add(this.SetStatusButton);
            this.Controls.Add(this.OrderStatusComboBox);
            this.Controls.Add(this.OrderIDSSBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderIDSSBox;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.Button SetStatusButton;
        private System.Windows.Forms.Label CurrBalanceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserIDBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox UserAddressBox;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UserIDPOBox;
        private System.Windows.Forms.TextBox ShirtQuantBox;
        private System.Windows.Forms.TextBox PantQuantBox;
        private System.Windows.Forms.TextBox SuitQuantBox;
        private System.Windows.Forms.TextBox SheetQuantBox;
        private System.Windows.Forms.ComboBox ShirtOrderComboBox;
        private System.Windows.Forms.ComboBox PantOrderComboBox;
        private System.Windows.Forms.ComboBox SuitsOrderComboBox;
        private System.Windows.Forms.ComboBox SheetOrderComboBox;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label ShowStatusLabel;
        private System.Windows.Forms.Label ShowAmountLabel;
        private System.Windows.Forms.TextBox OrderIDSeeDeetsBox;
        private System.Windows.Forms.Button ShowDetailsButton;
        private System.Windows.Forms.ListBox OrderDetailsBox;
        private System.Windows.Forms.Label ShowNameLabel;
        private System.Windows.Forms.Label ShowAddressLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label ShirtQuantityLabel;
        private System.Windows.Forms.Label PantQuantityLabel;
        private System.Windows.Forms.Label SuitQuantityLabel;
        private System.Windows.Forms.Label SheetQuantityLabel;
        private System.Windows.Forms.Label ShirtCondLabel;
        private System.Windows.Forms.Label PantCondLabel;
        private System.Windows.Forms.Label SuitCondLabel;
        private System.Windows.Forms.Label SheetCondLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}

