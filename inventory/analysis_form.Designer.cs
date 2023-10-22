namespace inventory
{
    partial class analysis_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(analysis_form));
            this.main_label = new System.Windows.Forms.Label();
            this.stockin_data = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stockreturn_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.ratio = new CircularProgressBar_NET5.CircularProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_ratio = new CircularProgressBar_NET5.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.incoming = new System.Windows.Forms.Label();
            this.outcoming = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.total_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.stockin_data)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("House On Mars", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.main_label.ForeColor = System.Drawing.Color.Azure;
            this.main_label.Location = new System.Drawing.Point(12, 9);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(194, 39);
            this.main_label.TabIndex = 1;
            this.main_label.Text = "Analysis";
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
            this.stockin_data.Location = new System.Drawing.Point(12, 184);
            this.stockin_data.Name = "stockin_data";
            this.stockin_data.RowHeadersVisible = false;
            this.stockin_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.stockin_data.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.stockin_data.RowTemplate.Height = 25;
            this.stockin_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockin_data.Size = new System.Drawing.Size(518, 381);
            this.stockin_data.TabIndex = 104;
            this.stockin_data.SelectionChanged += new System.EventHandler(this.stockin_data_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.total_label);
            this.groupBox2.Controls.Add(this.label5);
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
            this.groupBox2.Location = new System.Drawing.Point(536, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 191);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Item data";
            // 
            // stockreturn_btn
            // 
            this.stockreturn_btn.BackColor = System.Drawing.Color.Orange;
            this.stockreturn_btn.FlatAppearance.BorderSize = 0;
            this.stockreturn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockreturn_btn.Font = new System.Drawing.Font("House On Mars", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.stockreturn_btn.ForeColor = System.Drawing.Color.White;
            this.stockreturn_btn.Image = ((System.Drawing.Image)(resources.GetObject("stockreturn_btn.Image")));
            this.stockreturn_btn.Location = new System.Drawing.Point(312, 122);
            this.stockreturn_btn.Name = "stockreturn_btn";
            this.stockreturn_btn.Size = new System.Drawing.Size(218, 49);
            this.stockreturn_btn.TabIndex = 102;
            this.stockreturn_btn.Text = "Analyze";
            this.stockreturn_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stockreturn_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stockreturn_btn.UseVisualStyleBackColor = false;
            this.stockreturn_btn.Click += new System.EventHandler(this.stockreturn_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("House On Mars", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_btn.Location = new System.Drawing.Point(494, 64);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(36, 32);
            this.search_btn.TabIndex = 99;
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Location = new System.Drawing.Point(16, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 1);
            this.panel4.TabIndex = 101;
            // 
            // search_txtbox
            // 
            this.search_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.search_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_txtbox.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_txtbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.search_txtbox.Location = new System.Drawing.Point(16, 64);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(472, 24);
            this.search_txtbox.TabIndex = 100;
            this.search_txtbox.Text = "Search for product";
            this.search_txtbox.Click += new System.EventHandler(this.search_txtbox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(43, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 1);
            this.panel1.TabIndex = 106;
            // 
            // price_txtbox
            // 
            this.price_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.price_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price_txtbox.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_txtbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.price_txtbox.Location = new System.Drawing.Point(43, 136);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(251, 24);
            this.price_txtbox.TabIndex = 105;
            this.price_txtbox.Text = "current price";
            this.price_txtbox.Click += new System.EventHandler(this.price_txtbox_clicked1);
            this.price_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txtbox_TextChanged);
            // 
            // ratio
            // 
            this.ratio.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            this.ratio.AnimationSpeed = 500;
            this.ratio.BackColor = System.Drawing.Color.Transparent;
            this.ratio.Font = new System.Drawing.Font("House On Mars", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ratio.ForeColor = System.Drawing.Color.Gainsboro;
            this.ratio.InnerColor = System.Drawing.Color.Transparent;
            this.ratio.InnerMargin = 33;
            this.ratio.InnerWidth = -1;
            this.ratio.Location = new System.Drawing.Point(740, 221);
            this.ratio.MarqueeAnimationSpeed = 5000;
            this.ratio.Name = "ratio";
            this.ratio.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ratio.OuterMargin = -50;
            this.ratio.OuterWidth = 50;
            this.ratio.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.ratio.ProgressWidth = 15;
            this.ratio.SecondaryFont = new System.Drawing.Font("House On Mars", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ratio.Size = new System.Drawing.Size(162, 152);
            this.ratio.StartAngle = 270;
            this.ratio.Step = 5;
            this.ratio.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ratio.SubscriptColor = System.Drawing.Color.Orange;
            this.ratio.SubscriptMargin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.ratio.SubscriptText = "0";
            this.ratio.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ratio.SuperscriptMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ratio.SuperscriptText = "%";
            this.ratio.TabIndex = 107;
            this.ratio.Text = "Price";
            this.ratio.TextMargin = new System.Windows.Forms.Padding(10);
            this.ratio.Value = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory.Properties.Resources.price_tag;
            this.pictureBox1.Location = new System.Drawing.Point(12, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 33);
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // main_ratio
            // 
            this.main_ratio.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            this.main_ratio.AnimationSpeed = 500;
            this.main_ratio.BackColor = System.Drawing.Color.Transparent;
            this.main_ratio.Font = new System.Drawing.Font("House On Mars", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.main_ratio.ForeColor = System.Drawing.Color.Gainsboro;
            this.main_ratio.InnerColor = System.Drawing.Color.Transparent;
            this.main_ratio.InnerMargin = 33;
            this.main_ratio.InnerWidth = -1;
            this.main_ratio.Location = new System.Drawing.Point(740, 379);
            this.main_ratio.MarqueeAnimationSpeed = 5000;
            this.main_ratio.Name = "main_ratio";
            this.main_ratio.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.main_ratio.OuterMargin = -50;
            this.main_ratio.OuterWidth = 50;
            this.main_ratio.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.main_ratio.ProgressWidth = 15;
            this.main_ratio.SecondaryFont = new System.Drawing.Font("House On Mars", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.main_ratio.Size = new System.Drawing.Size(162, 152);
            this.main_ratio.StartAngle = 270;
            this.main_ratio.Step = 5;
            this.main_ratio.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.main_ratio.SubscriptColor = System.Drawing.Color.Orange;
            this.main_ratio.SubscriptMargin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.main_ratio.SubscriptText = "0";
            this.main_ratio.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.main_ratio.SuperscriptMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.main_ratio.SuperscriptText = " %";
            this.main_ratio.TabIndex = 109;
            this.main_ratio.Text = "Main ratio";
            this.main_ratio.TextMargin = new System.Windows.Forms.Padding(10);
            this.main_ratio.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(571, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 97;
            this.label1.Text = "price inflatin rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(560, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 40);
            this.label2.TabIndex = 110;
            this.label2.Text = "The ratio between the\r\n incoming and outcoming.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(560, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Outcoming:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(563, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 112;
            this.label4.Text = "Incoming:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // incoming
            // 
            this.incoming.AutoSize = true;
            this.incoming.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incoming.ForeColor = System.Drawing.SystemColors.Highlight;
            this.incoming.Location = new System.Drawing.Point(639, 497);
            this.incoming.Name = "incoming";
            this.incoming.Size = new System.Drawing.Size(0, 20);
            this.incoming.TabIndex = 114;
            this.incoming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incoming.Click += new System.EventHandler(this.label5_Click);
            // 
            // outcoming
            // 
            this.outcoming.AutoSize = true;
            this.outcoming.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outcoming.ForeColor = System.Drawing.SystemColors.Highlight;
            this.outcoming.Location = new System.Drawing.Point(636, 470);
            this.outcoming.Name = "outcoming";
            this.outcoming.Size = new System.Drawing.Size(0, 20);
            this.outcoming.TabIndex = 113;
            this.outcoming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outcoming.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(565, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 102;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(568, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 1);
            this.panel3.TabIndex = 103;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.total_label.Location = new System.Drawing.Point(92, 104);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(12, 16);
            this.total_label.TabIndex = 124;
            this.total_label.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(5, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 123;
            this.label5.Text = "Total price:";
            // 
            // admin_label_real
            // 
            this.admin_label_real.AutoSize = true;
            this.admin_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.admin_label_real.Location = new System.Drawing.Point(65, 171);
            this.admin_label_real.Name = "admin_label_real";
            this.admin_label_real.Size = new System.Drawing.Size(12, 16);
            this.admin_label_real.TabIndex = 122;
            this.admin_label_real.Text = " ";
            // 
            // lastup_label_real
            // 
            this.lastup_label_real.AutoSize = true;
            this.lastup_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lastup_label_real.Location = new System.Drawing.Point(96, 153);
            this.lastup_label_real.Name = "lastup_label_real";
            this.lastup_label_real.Size = new System.Drawing.Size(12, 16);
            this.lastup_label_real.TabIndex = 121;
            this.lastup_label_real.Text = " ";
            // 
            // exp_label_real
            // 
            this.exp_label_real.AutoSize = true;
            this.exp_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exp_label_real.Location = new System.Drawing.Point(96, 137);
            this.exp_label_real.Name = "exp_label_real";
            this.exp_label_real.Size = new System.Drawing.Size(12, 16);
            this.exp_label_real.TabIndex = 120;
            this.exp_label_real.Text = " ";
            // 
            // Deposit_label_real
            // 
            this.Deposit_label_real.AutoSize = true;
            this.Deposit_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Deposit_label_real.Location = new System.Drawing.Point(96, 120);
            this.Deposit_label_real.Name = "Deposit_label_real";
            this.Deposit_label_real.Size = new System.Drawing.Size(12, 16);
            this.Deposit_label_real.TabIndex = 119;
            this.Deposit_label_real.Text = " ";
            // 
            // quantity_label_real
            // 
            this.quantity_label_real.AutoSize = true;
            this.quantity_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.quantity_label_real.Location = new System.Drawing.Point(71, 87);
            this.quantity_label_real.Name = "quantity_label_real";
            this.quantity_label_real.Size = new System.Drawing.Size(12, 16);
            this.quantity_label_real.TabIndex = 118;
            this.quantity_label_real.Text = " ";
            // 
            // category_label_real
            // 
            this.category_label_real.AutoSize = true;
            this.category_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.category_label_real.Location = new System.Drawing.Point(79, 71);
            this.category_label_real.Name = "category_label_real";
            this.category_label_real.Size = new System.Drawing.Size(12, 16);
            this.category_label_real.TabIndex = 117;
            this.category_label_real.Text = " ";
            // 
            // intiprice_label_real
            // 
            this.intiprice_label_real.AutoSize = true;
            this.intiprice_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.intiprice_label_real.Location = new System.Drawing.Point(96, 55);
            this.intiprice_label_real.Name = "intiprice_label_real";
            this.intiprice_label_real.Size = new System.Drawing.Size(12, 16);
            this.intiprice_label_real.TabIndex = 116;
            this.intiprice_label_real.Text = " ";
            // 
            // name_label_real
            // 
            this.name_label_real.AutoSize = true;
            this.name_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.name_label_real.Location = new System.Drawing.Point(117, 39);
            this.name_label_real.Name = "name_label_real";
            this.name_label_real.Size = new System.Drawing.Size(12, 16);
            this.name_label_real.TabIndex = 115;
            this.name_label_real.Text = " ";
            // 
            // id_label_real
            // 
            this.id_label_real.AutoSize = true;
            this.id_label_real.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.id_label_real.Location = new System.Drawing.Point(35, 23);
            this.id_label_real.Name = "id_label_real";
            this.id_label_real.Size = new System.Drawing.Size(12, 16);
            this.id_label_real.TabIndex = 114;
            this.id_label_real.Text = " ";
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.admin_label.Location = new System.Drawing.Point(6, 171);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(54, 16);
            this.admin_label.TabIndex = 113;
            this.admin_label.Text = "Admin:";
            // 
            // lastup_label
            // 
            this.lastup_label.AutoSize = true;
            this.lastup_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lastup_label.Location = new System.Drawing.Point(6, 152);
            this.lastup_label.Name = "lastup_label";
            this.lastup_label.Size = new System.Drawing.Size(91, 16);
            this.lastup_label.TabIndex = 112;
            this.lastup_label.Text = "Last update:";
            // 
            // Deposit_label
            // 
            this.Deposit_label.AutoSize = true;
            this.Deposit_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Deposit_label.Location = new System.Drawing.Point(6, 120);
            this.Deposit_label.Name = "Deposit_label";
            this.Deposit_label.Size = new System.Drawing.Size(90, 16);
            this.Deposit_label.TabIndex = 111;
            this.Deposit_label.Text = "Dposit date:";
            // 
            // exp_label
            // 
            this.exp_label.AutoSize = true;
            this.exp_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exp_label.Location = new System.Drawing.Point(6, 136);
            this.exp_label.Name = "exp_label";
            this.exp_label.Size = new System.Drawing.Size(90, 16);
            this.exp_label.TabIndex = 110;
            this.exp_label.Text = "Expire date:";
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.quantity_label.Location = new System.Drawing.Point(6, 87);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(67, 16);
            this.quantity_label.TabIndex = 109;
            this.quantity_label.Text = "Quantity:";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.category_label.Location = new System.Drawing.Point(6, 71);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(69, 16);
            this.category_label.TabIndex = 108;
            this.category_label.Text = "category:";
            // 
            // intiprice_label
            // 
            this.intiprice_label.AutoSize = true;
            this.intiprice_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.intiprice_label.Location = new System.Drawing.Point(6, 55);
            this.intiprice_label.Name = "intiprice_label";
            this.intiprice_label.Size = new System.Drawing.Size(84, 16);
            this.intiprice_label.TabIndex = 107;
            this.intiprice_label.Text = "Intial price:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.name_label.Location = new System.Drawing.Point(6, 39);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(105, 16);
            this.name_label.TabIndex = 106;
            this.name_label.Text = "product name:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.id_label.Location = new System.Drawing.Point(6, 23);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(25, 16);
            this.id_label.TabIndex = 105;
            this.id_label.Text = "id:";
            // 
            // analysis_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(923, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.incoming);
            this.Controls.Add(this.outcoming);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_ratio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ratio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.price_txtbox);
            this.Controls.Add(this.stockin_data);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stockreturn_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.search_txtbox);
            this.Controls.Add(this.main_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "analysis_form";
            this.Text = "analysis_form";
            this.Load += new System.EventHandler(this.analysis_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockin_data)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.DataGridView stockin_data;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button stockreturn_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox price_txtbox;
        private CircularProgressBar_NET5.CircularProgressBar ratio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar_NET5.CircularProgressBar main_ratio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label incoming;
        private System.Windows.Forms.Label outcoming;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label label5;
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
    }
}