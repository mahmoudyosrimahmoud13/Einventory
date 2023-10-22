namespace inventory
{
    partial class stockin_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stockin_form));
            this.main_label = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.productname_txtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stockin_date = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.exp_chkbx = new System.Windows.Forms.CheckBox();
            this.exp_date = new System.Windows.Forms.DateTimePicker();
            this.stockin_data = new System.Windows.Forms.DataGridView();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.category_txtbox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_label_real = new System.Windows.Forms.Label();
            this.lastup_label_real = new System.Windows.Forms.Label();
            this.exp_label_real = new System.Windows.Forms.Label();
            this.Deposit_label_real = new System.Windows.Forms.Label();
            this.quantity_label_real = new System.Windows.Forms.Label();
            this.category_label_real = new System.Windows.Forms.Label();
            this.intiprice_label_real = new System.Windows.Forms.Label();
            this.name_label_real = new System.Windows.Forms.Label();
            this.id_label_real = new System.Windows.Forms.Label();
            this.admin_label = new System.Windows.Forms.Label();
            this.lastup_label = new System.Windows.Forms.Label();
            this.Deposit_label = new System.Windows.Forms.Label();
            this.exp_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.intiprice_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockin_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("House On Mars", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.main_label.ForeColor = System.Drawing.Color.Azure;
            this.main_label.Location = new System.Drawing.Point(12, 9);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(179, 39);
            this.main_label.TabIndex = 0;
            this.main_label.Text = "Stock in";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Orange;
            this.panel8.Location = new System.Drawing.Point(44, 129);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(526, 1);
            this.panel8.TabIndex = 20;
            // 
            // productname_txtbox
            // 
            this.productname_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.productname_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productname_txtbox.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productname_txtbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.productname_txtbox.Location = new System.Drawing.Point(44, 103);
            this.productname_txtbox.Name = "productname_txtbox";
            this.productname_txtbox.Size = new System.Drawing.Size(541, 24);
            this.productname_txtbox.TabIndex = 19;
            this.productname_txtbox.Text = "Enter product name";
            this.productname_txtbox.Click += new System.EventHandler(this.productname_txtbox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory.Properties.Resources.boxes;
            this.pictureBox1.Location = new System.Drawing.Point(13, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // stockin_date
            // 
            this.stockin_date.CalendarForeColor = System.Drawing.Color.Coral;
            this.stockin_date.CalendarMonthBackground = System.Drawing.Color.YellowGreen;
            this.stockin_date.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stockin_date.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.stockin_date.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.stockin_date.Location = new System.Drawing.Point(44, 184);
            this.stockin_date.Name = "stockin_date";
            this.stockin_date.Size = new System.Drawing.Size(202, 23);
            this.stockin_date.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(419, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 26);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(450, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 1);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 142);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 26);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(44, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 1);
            this.panel2.TabIndex = 28;
            // 
            // price_txtbox
            // 
            this.price_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.price_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price_txtbox.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_txtbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.price_txtbox.Location = new System.Drawing.Point(44, 144);
            this.price_txtbox.MaxLength = 10;
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(202, 24);
            this.price_txtbox.TabIndex = 27;
            this.price_txtbox.Text = "Enter product initial price";
            this.price_txtbox.Click += new System.EventHandler(this.price_txtbox_clicked);
            this.price_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txtbox_TextChanged);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Tomato;
            this.remove_btn.FlatAppearance.BorderSize = 0;
            this.remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_btn.Font = new System.Drawing.Font("House On Mars", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.remove_btn.ForeColor = System.Drawing.Color.White;
            this.remove_btn.Image = ((System.Drawing.Image)(resources.GetObject("remove_btn.Image")));
            this.remove_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_btn.Location = new System.Drawing.Point(591, 123);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(90, 37);
            this.remove_btn.TabIndex = 30;
            this.remove_btn.Text = "Remove";
            this.remove_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // exp_chkbx
            // 
            this.exp_chkbx.AutoSize = true;
            this.exp_chkbx.Location = new System.Drawing.Point(436, 184);
            this.exp_chkbx.Name = "exp_chkbx";
            this.exp_chkbx.Size = new System.Drawing.Size(119, 19);
            this.exp_chkbx.TabIndex = 31;
            this.exp_chkbx.Text = "Have expire date?";
            this.exp_chkbx.UseVisualStyleBackColor = true;
            // 
            // exp_date
            // 
            this.exp_date.CalendarForeColor = System.Drawing.Color.Coral;
            this.exp_date.CalendarMonthBackground = System.Drawing.Color.YellowGreen;
            this.exp_date.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exp_date.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.exp_date.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.exp_date.Location = new System.Drawing.Point(257, 184);
            this.exp_date.Name = "exp_date";
            this.exp_date.Size = new System.Drawing.Size(151, 23);
            this.exp_date.TabIndex = 32;
            // 
            // stockin_data
            // 
            this.stockin_data.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.stockin_data.AllowUserToAddRows = false;
            this.stockin_data.AllowUserToDeleteRows = false;
            this.stockin_data.BackgroundColor = System.Drawing.Color.White;
            this.stockin_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockin_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stockin_data.GridColor = System.Drawing.Color.Orange;
            this.stockin_data.Location = new System.Drawing.Point(20, 216);
            this.stockin_data.Name = "stockin_data";
            this.stockin_data.RowHeadersVisible = false;
            this.stockin_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.stockin_data.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.stockin_data.RowTemplate.Height = 25;
            this.stockin_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockin_data.Size = new System.Drawing.Size(891, 349);
            this.stockin_data.TabIndex = 33;
            this.stockin_data.SelectionChanged += new System.EventHandler(this.stockin_data_SelectionChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(253, 145);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 26);
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(284, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 1);
            this.panel3.TabIndex = 35;
            // 
            // category_txtbox
            // 
            this.category_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.category_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.category_txtbox.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.category_txtbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.category_txtbox.Location = new System.Drawing.Point(284, 147);
            this.category_txtbox.Name = "category_txtbox";
            this.category_txtbox.Size = new System.Drawing.Size(124, 24);
            this.category_txtbox.TabIndex = 34;
            this.category_txtbox.Text = "Category";
            this.category_txtbox.Click += new System.EventHandler(this.category_txtbox_clicked);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("House On Mars", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Image = global::inventory.Properties.Resources.add;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_btn.Location = new System.Drawing.Point(591, 166);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(90, 37);
            this.add_btn.TabIndex = 37;
            this.add_btn.Text = "Add";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.total_label);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.admin_label_real);
            this.groupBox2.Controls.Add(this.lastup_label_real);
            this.groupBox2.Controls.Add(this.exp_label_real);
            this.groupBox2.Controls.Add(this.Deposit_label_real);
            this.groupBox2.Controls.Add(this.quantity_label_real);
            this.groupBox2.Controls.Add(this.category_label_real);
            this.groupBox2.Controls.Add(this.intiprice_label_real);
            this.groupBox2.Controls.Add(this.name_label_real);
            this.groupBox2.Controls.Add(this.id_label_real);
            this.groupBox2.Controls.Add(this.admin_label);
            this.groupBox2.Controls.Add(this.lastup_label);
            this.groupBox2.Controls.Add(this.Deposit_label);
            this.groupBox2.Controls.Add(this.exp_label);
            this.groupBox2.Controls.Add(this.quantity_label);
            this.groupBox2.Controls.Add(this.category_label);
            this.groupBox2.Controls.Add(this.intiprice_label);
            this.groupBox2.Controls.Add(this.name_label);
            this.groupBox2.Controls.Add(this.id_label);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(687, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 191);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Item data";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.total_label.Location = new System.Drawing.Point(93, 102);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(12, 16);
            this.total_label.TabIndex = 102;
            this.total_label.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "Total price:";
            // 
            // admin_label_real
            // 
            this.admin_label_real.AutoSize = true;
            this.admin_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.admin_label_real.Location = new System.Drawing.Point(65, 169);
            this.admin_label_real.Name = "admin_label_real";
            this.admin_label_real.Size = new System.Drawing.Size(12, 16);
            this.admin_label_real.TabIndex = 96;
            this.admin_label_real.Text = " ";
            // 
            // lastup_label_real
            // 
            this.lastup_label_real.AutoSize = true;
            this.lastup_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lastup_label_real.Location = new System.Drawing.Point(96, 151);
            this.lastup_label_real.Name = "lastup_label_real";
            this.lastup_label_real.Size = new System.Drawing.Size(12, 16);
            this.lastup_label_real.TabIndex = 95;
            this.lastup_label_real.Text = " ";
            // 
            // exp_label_real
            // 
            this.exp_label_real.AutoSize = true;
            this.exp_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exp_label_real.Location = new System.Drawing.Point(96, 135);
            this.exp_label_real.Name = "exp_label_real";
            this.exp_label_real.Size = new System.Drawing.Size(12, 16);
            this.exp_label_real.TabIndex = 94;
            this.exp_label_real.Text = " ";
            // 
            // Deposit_label_real
            // 
            this.Deposit_label_real.AutoSize = true;
            this.Deposit_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Deposit_label_real.Location = new System.Drawing.Point(96, 118);
            this.Deposit_label_real.Name = "Deposit_label_real";
            this.Deposit_label_real.Size = new System.Drawing.Size(12, 16);
            this.Deposit_label_real.TabIndex = 93;
            this.Deposit_label_real.Text = " ";
            // 
            // quantity_label_real
            // 
            this.quantity_label_real.AutoSize = true;
            this.quantity_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.quantity_label_real.Location = new System.Drawing.Point(71, 83);
            this.quantity_label_real.Name = "quantity_label_real";
            this.quantity_label_real.Size = new System.Drawing.Size(12, 16);
            this.quantity_label_real.TabIndex = 92;
            this.quantity_label_real.Text = " ";
            // 
            // category_label_real
            // 
            this.category_label_real.AutoSize = true;
            this.category_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.category_label_real.Location = new System.Drawing.Point(79, 67);
            this.category_label_real.Name = "category_label_real";
            this.category_label_real.Size = new System.Drawing.Size(12, 16);
            this.category_label_real.TabIndex = 91;
            this.category_label_real.Text = " ";
            // 
            // intiprice_label_real
            // 
            this.intiprice_label_real.AutoSize = true;
            this.intiprice_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.intiprice_label_real.Location = new System.Drawing.Point(96, 51);
            this.intiprice_label_real.Name = "intiprice_label_real";
            this.intiprice_label_real.Size = new System.Drawing.Size(12, 16);
            this.intiprice_label_real.TabIndex = 90;
            this.intiprice_label_real.Text = " ";
            // 
            // name_label_real
            // 
            this.name_label_real.AutoSize = true;
            this.name_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.name_label_real.Location = new System.Drawing.Point(61, 35);
            this.name_label_real.Name = "name_label_real";
            this.name_label_real.Size = new System.Drawing.Size(12, 16);
            this.name_label_real.TabIndex = 89;
            this.name_label_real.Text = " ";
            // 
            // id_label_real
            // 
            this.id_label_real.AutoSize = true;
            this.id_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.id_label_real.Location = new System.Drawing.Point(35, 19);
            this.id_label_real.Name = "id_label_real";
            this.id_label_real.Size = new System.Drawing.Size(12, 16);
            this.id_label_real.TabIndex = 88;
            this.id_label_real.Text = " ";
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.admin_label.Location = new System.Drawing.Point(6, 169);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(54, 16);
            this.admin_label.TabIndex = 87;
            this.admin_label.Text = "Admin:";
            // 
            // lastup_label
            // 
            this.lastup_label.AutoSize = true;
            this.lastup_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lastup_label.Location = new System.Drawing.Point(6, 150);
            this.lastup_label.Name = "lastup_label";
            this.lastup_label.Size = new System.Drawing.Size(91, 16);
            this.lastup_label.TabIndex = 86;
            this.lastup_label.Text = "Last update:";
            // 
            // Deposit_label
            // 
            this.Deposit_label.AutoSize = true;
            this.Deposit_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Deposit_label.Location = new System.Drawing.Point(6, 118);
            this.Deposit_label.Name = "Deposit_label";
            this.Deposit_label.Size = new System.Drawing.Size(90, 16);
            this.Deposit_label.TabIndex = 85;
            this.Deposit_label.Text = "Dposit date:";
            // 
            // exp_label
            // 
            this.exp_label.AutoSize = true;
            this.exp_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exp_label.Location = new System.Drawing.Point(6, 134);
            this.exp_label.Name = "exp_label";
            this.exp_label.Size = new System.Drawing.Size(90, 16);
            this.exp_label.TabIndex = 84;
            this.exp_label.Text = "Expire date:";
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.quantity_label.Location = new System.Drawing.Point(6, 83);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(67, 16);
            this.quantity_label.TabIndex = 83;
            this.quantity_label.Text = "Quantity:";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.category_label.Location = new System.Drawing.Point(6, 67);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(69, 16);
            this.category_label.TabIndex = 82;
            this.category_label.Text = "category:";
            // 
            // intiprice_label
            // 
            this.intiprice_label.AutoSize = true;
            this.intiprice_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.intiprice_label.Location = new System.Drawing.Point(6, 51);
            this.intiprice_label.Name = "intiprice_label";
            this.intiprice_label.Size = new System.Drawing.Size(84, 16);
            this.intiprice_label.TabIndex = 81;
            this.intiprice_label.Text = "Intial price:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.name_label.Location = new System.Drawing.Point(6, 35);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(50, 16);
            this.name_label.TabIndex = 80;
            this.name_label.Text = "Name:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.id_label.Location = new System.Drawing.Point(6, 19);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(25, 16);
            this.id_label.TabIndex = 79;
            this.id_label.Text = "id:";
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantity.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.quantity.Location = new System.Drawing.Point(448, 145);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(105, 27);
            this.quantity.TabIndex = 80;
            // 
            // stockin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(923, 577);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.category_txtbox);
            this.Controls.Add(this.stockin_data);
            this.Controls.Add(this.exp_date);
            this.Controls.Add(this.exp_chkbx);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.price_txtbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.stockin_date);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.productname_txtbox);
            this.Controls.Add(this.main_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stockin_form";
            this.Text = "stockin_form";
            this.Load += new System.EventHandler(this.stockin_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockin_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox productname_txtbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker stockin_date;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.CheckBox exp_chkbx;
        private System.Windows.Forms.DateTimePicker exp_date;
        private System.Windows.Forms.DataGridView stockin_data;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox category_txtbox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label admin_label_real;
        private System.Windows.Forms.Label lastup_label_real;
        private System.Windows.Forms.Label exp_label_real;
        private System.Windows.Forms.Label Deposit_label_real;
        private System.Windows.Forms.Label quantity_label_real;
        private System.Windows.Forms.Label category_label_real;
        private System.Windows.Forms.Label intiprice_label_real;
        private System.Windows.Forms.Label name_label_real;
        private System.Windows.Forms.Label id_label_real;
        private System.Windows.Forms.Label admin_label;
        private System.Windows.Forms.Label lastup_label;
        private System.Windows.Forms.Label Deposit_label;
        private System.Windows.Forms.Label exp_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label intiprice_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label label2;
    }
}