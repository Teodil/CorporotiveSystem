namespace System
{
    partial class Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Orders = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResponsibleFilter = new System.Windows.Forms.ComboBox();
            this.BuyPlan = new System.Windows.Forms.DataGridView();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.ProductBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WarehouseBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PlanIdBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Orders);
            this.groupBox1.Location = new System.Drawing.Point(12, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказы";
            // 
            // Orders
            // 
            this.Orders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders.Location = new System.Drawing.Point(6, 22);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(1000, 192);
            this.Orders.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResponsibleFilter);
            this.groupBox2.Controls.Add(this.BuyPlan);
            this.groupBox2.Location = new System.Drawing.Point(333, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "План закупок";
            // 
            // ResponsibleFilter
            // 
            this.ResponsibleFilter.FormattingEnabled = true;
            this.ResponsibleFilter.Items.AddRange(new object[] {
            "Все"});
            this.ResponsibleFilter.Location = new System.Drawing.Point(564, 24);
            this.ResponsibleFilter.Name = "ResponsibleFilter";
            this.ResponsibleFilter.Size = new System.Drawing.Size(121, 21);
            this.ResponsibleFilter.TabIndex = 1;
            this.ResponsibleFilter.SelectedIndexChanged += new System.EventHandler(this.ResponsibleFilter_SelectedIndexChanged);
            // 
            // BuyPlan
            // 
            this.BuyPlan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.BuyPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuyPlan.Location = new System.Drawing.Point(6, 55);
            this.BuyPlan.Name = "BuyPlan";
            this.BuyPlan.Size = new System.Drawing.Size(679, 177);
            this.BuyPlan.TabIndex = 0;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(3, 90);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(135, 20);
            this.AmountBox.TabIndex = 3;
            // 
            // ProductBox
            // 
            this.ProductBox.FormattingEnabled = true;
            this.ProductBox.Location = new System.Drawing.Point(3, 36);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(135, 21);
            this.ProductBox.TabIndex = 4;
            this.ProductBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Товар";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поставщик";
            // 
            // SupplierBox
            // 
            this.SupplierBox.FormattingEnabled = true;
            this.SupplierBox.Location = new System.Drawing.Point(159, 36);
            this.SupplierBox.Name = "SupplierBox";
            this.SupplierBox.Size = new System.Drawing.Size(135, 21);
            this.SupplierBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Цена";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(159, 90);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(135, 20);
            this.PriceBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Склад";
            // 
            // WarehouseBox
            // 
            this.WarehouseBox.FormattingEnabled = true;
            this.WarehouseBox.Location = new System.Drawing.Point(3, 140);
            this.WarehouseBox.Name = "WarehouseBox";
            this.WarehouseBox.Size = new System.Drawing.Size(135, 21);
            this.WarehouseBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Номер плана";
            // 
            // PlanIdBox
            // 
            this.PlanIdBox.Location = new System.Drawing.Point(159, 140);
            this.PlanIdBox.Name = "PlanIdBox";
            this.PlanIdBox.Size = new System.Drawing.Size(135, 20);
            this.PlanIdBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 56);
            this.button1.TabIndex = 15;
            this.button1.Text = "Оформить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::System.Properties.Resources.plus_PNG113;
            this.pictureBox1.Location = new System.Drawing.Point(300, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PlanIdBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WarehouseBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SupplierBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buy";
            this.Text = "Закупка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Buy_FormClosed);
            this.Load += new System.EventHandler(this.Buy_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuyPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.GroupBox groupBox1;
        private Windows.Forms.DataGridView Orders;
        private Windows.Forms.GroupBox groupBox2;
        private Windows.Forms.DataGridView BuyPlan;
        private Windows.Forms.TextBox AmountBox;
        private Windows.Forms.ComboBox ProductBox;
        private Windows.Forms.Label label1;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label label3;
        private Windows.Forms.ComboBox SupplierBox;
        private Windows.Forms.Label label4;
        private Windows.Forms.TextBox PriceBox;
        private Windows.Forms.Label label5;
        private Windows.Forms.ComboBox WarehouseBox;
        private Windows.Forms.Label label6;
        private Windows.Forms.TextBox PlanIdBox;
        private Windows.Forms.Button button1;
        private Windows.Forms.PictureBox pictureBox1;
        private Windows.Forms.ComboBox ResponsibleFilter;
    }
}