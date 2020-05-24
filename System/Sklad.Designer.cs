namespace System
{
    partial class Sklad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sklad));
            this.ClientBox = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PrihodButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ProductsBox = new System.Windows.Forms.ComboBox();
            this.WarehouseBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SupplierBox = new System.Windows.Forms.ComboBox();
            this.OrderNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SkladFilter = new System.Windows.Forms.ComboBox();
            this.ComingOrders = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.WarehouseBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.SalesProd = new System.Windows.Forms.ComboBox();
            this.Kotyshka = new System.Windows.Forms.ComboBox();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SalesAmount = new System.Windows.Forms.TextBox();
            this.SalesPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RashodNum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CurentFilter = new System.Windows.Forms.ComboBox();
            this.CurentProd = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.SalesOrders = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateNamotka = new System.Windows.Forms.Button();
            this.NamotkaAmount2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.NamotkaIndex2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNamotka = new System.Windows.Forms.Button();
            this.NamotkaProduct = new System.Windows.Forms.ComboBox();
            this.NamotkaAmount1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NamotkaIndex1 = new System.Windows.Forms.TextBox();
            this.WarehouseBox3 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CurentFilter2 = new System.Windows.Forms.ComboBox();
            this.CurentProd2 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ClientBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComingOrders)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurentProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurentProd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientBox
            // 
            this.ClientBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientBox.Controls.Add(this.tabPage1);
            this.ClientBox.Controls.Add(this.tabPage2);
            this.ClientBox.Controls.Add(this.tabPage3);
            this.ClientBox.Location = new System.Drawing.Point(5, 3);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.SelectedIndex = 0;
            this.ClientBox.Size = new System.Drawing.Size(1057, 507);
            this.ClientBox.TabIndex = 0;
            this.ClientBox.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.Refresh);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.SkladFilter);
            this.tabPage1.Controls.Add(this.ComingOrders);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1049, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Приход";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PrihodButton);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.ProductsBox);
            this.groupBox3.Controls.Add(this.WarehouseBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.SupplierBox);
            this.groupBox3.Controls.Add(this.OrderNum);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.AmountBox);
            this.groupBox3.Controls.Add(this.PriceBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(10, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 357);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оформление накладной прихода";
            // 
            // PrihodButton
            // 
            this.PrihodButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PrihodButton.Location = new System.Drawing.Point(9, 260);
            this.PrihodButton.Name = "PrihodButton";
            this.PrihodButton.Size = new System.Drawing.Size(333, 73);
            this.PrihodButton.TabIndex = 11;
            this.PrihodButton.Text = "Оформить";
            this.PrihodButton.UseVisualStyleBackColor = true;
            this.PrihodButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // ProductsBox
            // 
            this.ProductsBox.FormattingEnabled = true;
            this.ProductsBox.Location = new System.Drawing.Point(9, 89);
            this.ProductsBox.Name = "ProductsBox";
            this.ProductsBox.Size = new System.Drawing.Size(121, 21);
            this.ProductsBox.TabIndex = 1;
            this.ProductsBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // WarehouseBox
            // 
            this.WarehouseBox.FormattingEnabled = true;
            this.WarehouseBox.Location = new System.Drawing.Point(9, 132);
            this.WarehouseBox.Name = "WarehouseBox";
            this.WarehouseBox.Size = new System.Drawing.Size(121, 21);
            this.WarehouseBox.TabIndex = 2;
            this.WarehouseBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Номер заказа";
            this.label14.Click += new System.EventHandler(this.label14_Click_1);
            // 
            // SupplierBox
            // 
            this.SupplierBox.FormattingEnabled = true;
            this.SupplierBox.Location = new System.Drawing.Point(9, 177);
            this.SupplierBox.Name = "SupplierBox";
            this.SupplierBox.Size = new System.Drawing.Size(121, 21);
            this.SupplierBox.TabIndex = 3;
            // 
            // OrderNum
            // 
            this.OrderNum.FormattingEnabled = true;
            this.OrderNum.Location = new System.Drawing.Point(9, 49);
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.Size = new System.Drawing.Size(121, 21);
            this.OrderNum.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Товар";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(136, 89);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(100, 20);
            this.AmountBox.TabIndex = 5;
            this.AmountBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(242, 89);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 6;
            this.PriceBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Поставщик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Склад";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Refresh.Location = new System.Drawing.Point(1001, 19);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(34, 34);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Refresh.TabIndex = 29;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(646, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Заказы прихода";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // SkladFilter
            // 
            this.SkladFilter.FormattingEnabled = true;
            this.SkladFilter.Items.AddRange(new object[] {
            "Все"});
            this.SkladFilter.Location = new System.Drawing.Point(365, 32);
            this.SkladFilter.Name = "SkladFilter";
            this.SkladFilter.Size = new System.Drawing.Size(121, 21);
            this.SkladFilter.TabIndex = 27;
            this.SkladFilter.SelectedIndexChanged += new System.EventHandler(this.SkladFilter_SelectedIndexChanged);
            this.SkladFilter.TextUpdate += new System.EventHandler(this.SkladFilter_TextUpdate);
            // 
            // ComingOrders
            // 
            this.ComingOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComingOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ComingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComingOrders.Location = new System.Drawing.Point(365, 59);
            this.ComingOrders.Name = "ComingOrders";
            this.ComingOrders.Size = new System.Drawing.Size(670, 412);
            this.ComingOrders.TabIndex = 12;
            this.ComingOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComingOrders_CellContentClick);
            this.ComingOrders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComingOrders_CellContentDoubleClick);
            this.ComingOrders.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.ComingOrders_RowStateChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1049, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расход";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.WarehouseBox2);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.SalesProd);
            this.groupBox4.Controls.Add(this.Kotyshka);
            this.groupBox4.Controls.Add(this.ClientComboBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.SalesAmount);
            this.groupBox4.Controls.Add(this.SalesPrice);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.RashodNum);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(12, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 351);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Оформление накладной расхода";
            // 
            // WarehouseBox2
            // 
            this.WarehouseBox2.FormattingEnabled = true;
            this.WarehouseBox2.Location = new System.Drawing.Point(14, 129);
            this.WarehouseBox2.Name = "WarehouseBox2";
            this.WarehouseBox2.Size = new System.Drawing.Size(121, 21);
            this.WarehouseBox2.TabIndex = 13;
            this.WarehouseBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(14, 220);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(138, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Номер катушки";
            // 
            // SalesProd
            // 
            this.SalesProd.FormattingEnabled = true;
            this.SalesProd.Location = new System.Drawing.Point(14, 86);
            this.SalesProd.Name = "SalesProd";
            this.SalesProd.Size = new System.Drawing.Size(121, 21);
            this.SalesProd.TabIndex = 12;
            // 
            // Kotyshka
            // 
            this.Kotyshka.FormattingEnabled = true;
            this.Kotyshka.Location = new System.Drawing.Point(141, 46);
            this.Kotyshka.Name = "Kotyshka";
            this.Kotyshka.Size = new System.Drawing.Size(121, 21);
            this.Kotyshka.TabIndex = 36;
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(14, 174);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClientComboBox.TabIndex = 14;
            this.ClientComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Товар";
            // 
            // SalesAmount
            // 
            this.SalesAmount.Location = new System.Drawing.Point(141, 86);
            this.SalesAmount.Name = "SalesAmount";
            this.SalesAmount.Size = new System.Drawing.Size(100, 20);
            this.SalesAmount.TabIndex = 16;
            // 
            // SalesPrice
            // 
            this.SalesPrice.Location = new System.Drawing.Point(141, 130);
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.Size = new System.Drawing.Size(100, 20);
            this.SalesPrice.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Кол-во";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Цена";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Номер заказа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Склад";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // RashodNum
            // 
            this.RashodNum.FormattingEnabled = true;
            this.RashodNum.Location = new System.Drawing.Point(14, 46);
            this.RashodNum.Name = "RashodNum";
            this.RashodNum.Size = new System.Drawing.Size(121, 21);
            this.RashodNum.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Клиент";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 73);
            this.button2.TabIndex = 22;
            this.button2.Text = "Оформить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CurentFilter
            // 
            this.CurentFilter.FormattingEnabled = true;
            this.CurentFilter.Items.AddRange(new object[] {
            "Все"});
            this.CurentFilter.Location = new System.Drawing.Point(576, 15);
            this.CurentFilter.Name = "CurentFilter";
            this.CurentFilter.Size = new System.Drawing.Size(121, 21);
            this.CurentFilter.TabIndex = 35;
            this.CurentFilter.SelectedIndexChanged += new System.EventHandler(this.CurentFilter_SelectedIndexChanged);
            // 
            // CurentProd
            // 
            this.CurentProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurentProd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.CurentProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurentProd.Location = new System.Drawing.Point(7, 42);
            this.CurentProd.Name = "CurentProd";
            this.CurentProd.Size = new System.Drawing.Size(690, 187);
            this.CurentProd.TabIndex = 34;
            this.CurentProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CurentProd_CellDoubleClick);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(654, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Заказы расход";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalesOrders
            // 
            this.SalesOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.SalesOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesOrders.Location = new System.Drawing.Point(7, 58);
            this.SalesOrders.Name = "SalesOrders";
            this.SalesOrders.Size = new System.Drawing.Size(690, 158);
            this.SalesOrders.TabIndex = 30;
            this.SalesOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesOrders_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.CurentFilter2);
            this.tabPage3.Controls.Add(this.CurentProd2);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1049, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Намотка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateNamotka);
            this.groupBox2.Controls.Add(this.NamotkaAmount2);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.NamotkaIndex2);
            this.groupBox2.Location = new System.Drawing.Point(16, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 211);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обновить намотку";
            // 
            // UpdateNamotka
            // 
            this.UpdateNamotka.Location = new System.Drawing.Point(25, 109);
            this.UpdateNamotka.Name = "UpdateNamotka";
            this.UpdateNamotka.Size = new System.Drawing.Size(248, 60);
            this.UpdateNamotka.TabIndex = 0;
            this.UpdateNamotka.Text = "Обновить";
            this.UpdateNamotka.UseVisualStyleBackColor = true;
            this.UpdateNamotka.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NamotkaAmount2
            // 
            this.NamotkaAmount2.Location = new System.Drawing.Point(152, 52);
            this.NamotkaAmount2.Name = "NamotkaAmount2";
            this.NamotkaAmount2.Size = new System.Drawing.Size(121, 20);
            this.NamotkaAmount2.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Индекс намотки";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(149, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Длинна";
            // 
            // NamotkaIndex2
            // 
            this.NamotkaIndex2.Location = new System.Drawing.Point(25, 52);
            this.NamotkaIndex2.Name = "NamotkaIndex2";
            this.NamotkaIndex2.Size = new System.Drawing.Size(121, 20);
            this.NamotkaIndex2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNamotka);
            this.groupBox1.Controls.Add(this.NamotkaProduct);
            this.groupBox1.Controls.Add(this.NamotkaAmount1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.NamotkaIndex1);
            this.groupBox1.Controls.Add(this.WarehouseBox3);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(16, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 211);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить намотку";
            // 
            // AddNamotka
            // 
            this.AddNamotka.Location = new System.Drawing.Point(25, 131);
            this.AddNamotka.Name = "AddNamotka";
            this.AddNamotka.Size = new System.Drawing.Size(248, 60);
            this.AddNamotka.TabIndex = 0;
            this.AddNamotka.Text = "Добавить";
            this.AddNamotka.UseVisualStyleBackColor = true;
            this.AddNamotka.Click += new System.EventHandler(this.button3_Click);
            // 
            // NamotkaProduct
            // 
            this.NamotkaProduct.FormattingEnabled = true;
            this.NamotkaProduct.Location = new System.Drawing.Point(25, 55);
            this.NamotkaProduct.Name = "NamotkaProduct";
            this.NamotkaProduct.Size = new System.Drawing.Size(121, 21);
            this.NamotkaProduct.TabIndex = 1;
            this.NamotkaProduct.SelectedIndexChanged += new System.EventHandler(this.NamotkaProduct_SelectedIndexChanged);
            // 
            // NamotkaAmount1
            // 
            this.NamotkaAmount1.Location = new System.Drawing.Point(25, 105);
            this.NamotkaAmount1.Name = "NamotkaAmount1";
            this.NamotkaAmount1.Size = new System.Drawing.Size(121, 20);
            this.NamotkaAmount1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Тип кабеля";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(149, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Индекс намотки";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Длинна";
            // 
            // NamotkaIndex1
            // 
            this.NamotkaIndex1.Location = new System.Drawing.Point(152, 105);
            this.NamotkaIndex1.Name = "NamotkaIndex1";
            this.NamotkaIndex1.Size = new System.Drawing.Size(121, 20);
            this.NamotkaIndex1.TabIndex = 7;
            // 
            // WarehouseBox3
            // 
            this.WarehouseBox3.FormattingEnabled = true;
            this.WarehouseBox3.Location = new System.Drawing.Point(152, 55);
            this.WarehouseBox3.Name = "WarehouseBox3";
            this.WarehouseBox3.Size = new System.Drawing.Size(121, 21);
            this.WarehouseBox3.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(149, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Склад";
            // 
            // CurentFilter2
            // 
            this.CurentFilter2.FormattingEnabled = true;
            this.CurentFilter2.Items.AddRange(new object[] {
            "Все"});
            this.CurentFilter2.Location = new System.Drawing.Point(396, 24);
            this.CurentFilter2.Name = "CurentFilter2";
            this.CurentFilter2.Size = new System.Drawing.Size(115, 21);
            this.CurentFilter2.TabIndex = 37;
            this.CurentFilter2.SelectedIndexChanged += new System.EventHandler(this.CurentFilter2_SelectedIndexChanged);
            // 
            // CurentProd2
            // 
            this.CurentProd2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurentProd2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.CurentProd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurentProd2.Location = new System.Drawing.Point(396, 48);
            this.CurentProd2.Name = "CurentProd2";
            this.CurentProd2.Size = new System.Drawing.Size(646, 348);
            this.CurentProd2.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1008, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SalesOrders);
            this.groupBox5.Location = new System.Drawing.Point(339, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(703, 227);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Заказа на расход";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CurentFilter);
            this.groupBox6.Controls.Add(this.CurentProd);
            this.groupBox6.Location = new System.Drawing.Point(339, 240);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(703, 235);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Наличе на складе";
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 506);
            this.Controls.Add(this.ClientBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sklad";
            this.Text = "Склад";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sklad_FormClosed);
            this.Load += new System.EventHandler(this.Sklad_Load);
            this.ResizeBegin += new System.EventHandler(this.Sklad_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Sklad_ResizeEnd);
            this.ClientBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComingOrders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurentProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurentProd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.TabControl ClientBox;
        private Windows.Forms.TabPage tabPage1;
        private Windows.Forms.Label label1;
        private Windows.Forms.ComboBox SupplierBox;
        private Windows.Forms.ComboBox WarehouseBox;
        private Windows.Forms.ComboBox ProductsBox;
        private Windows.Forms.DateTimePicker dateTimePicker1;
        private Windows.Forms.TabPage tabPage2;
        private Windows.Forms.TextBox PriceBox;
        private Windows.Forms.TextBox AmountBox;
        private Windows.Forms.Label label5;
        private Windows.Forms.Label label4;
        private Windows.Forms.Label label3;
        private Windows.Forms.Label label2;
        private Windows.Forms.Button PrihodButton;
        private Windows.Forms.Button button2;
        private Windows.Forms.Label label6;
        private Windows.Forms.Label label7;
        private Windows.Forms.Label label8;
        private Windows.Forms.Label label9;
        private Windows.Forms.TextBox SalesPrice;
        private Windows.Forms.TextBox SalesAmount;
        private Windows.Forms.Label label10;
        private Windows.Forms.ComboBox ClientComboBox;
        private Windows.Forms.ComboBox WarehouseBox2;
        private Windows.Forms.ComboBox SalesProd;
        private Windows.Forms.DateTimePicker dateTimePicker2;
        private Windows.Forms.Label label13;
        private Windows.Forms.ComboBox RashodNum;
        private Windows.Forms.DataGridView ComingOrders;
        private Windows.Forms.Label label14;
        private Windows.Forms.ComboBox OrderNum;
        private Windows.Forms.ComboBox SkladFilter;
        private Windows.Forms.Label label15;
        private Windows.Forms.PictureBox Refresh;
        private Windows.Forms.Label label16;
        private Windows.Forms.DataGridView SalesOrders;
        private Windows.Forms.ComboBox CurentFilter;
        private Windows.Forms.DataGridView CurentProd;
        private Windows.Forms.Label label17;
        private Windows.Forms.ComboBox Kotyshka;
        private Windows.Forms.TabPage tabPage3;
        private Windows.Forms.Label label19;
        private Windows.Forms.TextBox NamotkaIndex1;
        private Windows.Forms.Label label18;
        private Windows.Forms.ComboBox WarehouseBox3;
        private Windows.Forms.Label label12;
        private Windows.Forms.Label label11;
        private Windows.Forms.TextBox NamotkaAmount1;
        private Windows.Forms.ComboBox NamotkaProduct;
        private Windows.Forms.Button AddNamotka;
        private Windows.Forms.ComboBox CurentFilter2;
        private Windows.Forms.DataGridView CurentProd2;
        private Windows.Forms.PictureBox pictureBox2;
        private Windows.Forms.GroupBox groupBox3;
        private Windows.Forms.GroupBox groupBox2;
        private Windows.Forms.Button UpdateNamotka;
        private Windows.Forms.TextBox NamotkaAmount2;
        private Windows.Forms.Label label21;
        private Windows.Forms.Label label22;
        private Windows.Forms.TextBox NamotkaIndex2;
        private Windows.Forms.GroupBox groupBox1;
        private Windows.Forms.GroupBox groupBox4;
        private Windows.Forms.GroupBox groupBox6;
        private Windows.Forms.GroupBox groupBox5;
    }
}