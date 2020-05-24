namespace System
{
    partial class Stat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stat));
            this.CurrentProd = new System.Windows.Forms.DataGridView();
            this.BuyPlan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResponsibleFilter = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SkladFilter = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComingOrders = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateForPlan = new System.Windows.Forms.DateTimePicker();
            this.ResponsibleBox = new System.Windows.Forms.TextBox();
            this.AmountForPlan = new System.Windows.Forms.TextBox();
            this.PlanProductBox = new System.Windows.Forms.ComboBox();
            this.Tabe = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceForList = new System.Windows.Forms.TextBox();
            this.ProductBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PriceListGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Consuption = new System.Windows.Forms.DataGridView();
            this.BuyGroupBox = new System.Windows.Forms.GroupBox();
            this.Invoice_Coming = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPlan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComingOrders)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.Tabe.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceListGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Consuption)).BeginInit();
            this.BuyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_Coming)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentProd
            // 
            this.CurrentProd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.CurrentProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentProd.Location = new System.Drawing.Point(6, 46);
            this.CurrentProd.Name = "CurrentProd";
            this.CurrentProd.Size = new System.Drawing.Size(485, 193);
            this.CurrentProd.TabIndex = 0;
            this.CurrentProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BuyPlan
            // 
            this.BuyPlan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.BuyPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuyPlan.Location = new System.Drawing.Point(6, 69);
            this.BuyPlan.Name = "BuyPlan";
            this.BuyPlan.Size = new System.Drawing.Size(578, 219);
            this.BuyPlan.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResponsibleFilter);
            this.groupBox1.Controls.Add(this.BuyPlan);
            this.groupBox1.Location = new System.Drawing.Point(377, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 300);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "План закупок";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // ResponsibleFilter
            // 
            this.ResponsibleFilter.AutoCompleteCustomSource.AddRange(new string[] {
            "Все"});
            this.ResponsibleFilter.FormattingEnabled = true;
            this.ResponsibleFilter.Items.AddRange(new object[] {
            "Все"});
            this.ResponsibleFilter.Location = new System.Drawing.Point(463, 42);
            this.ResponsibleFilter.Name = "ResponsibleFilter";
            this.ResponsibleFilter.Size = new System.Drawing.Size(121, 21);
            this.ResponsibleFilter.TabIndex = 5;
            this.ResponsibleFilter.SelectedIndexChanged += new System.EventHandler(this.ResponsibleFilter_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SkladFilter);
            this.groupBox2.Controls.Add(this.CurrentProd);
            this.groupBox2.Location = new System.Drawing.Point(476, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 242);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Наличие на складе";
            // 
            // SkladFilter
            // 
            this.SkladFilter.AutoCompleteCustomSource.AddRange(new string[] {
            "Все"});
            this.SkladFilter.FormattingEnabled = true;
            this.SkladFilter.Items.AddRange(new object[] {
            "Все"});
            this.SkladFilter.Location = new System.Drawing.Point(370, 19);
            this.SkladFilter.Name = "SkladFilter";
            this.SkladFilter.Size = new System.Drawing.Size(121, 21);
            this.SkladFilter.TabIndex = 1;
            this.SkladFilter.SelectedIndexChanged += new System.EventHandler(this.SkladFilter_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComingOrders);
            this.groupBox3.Location = new System.Drawing.Point(3, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 260);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заказы";
            // 
            // ComingOrders
            // 
            this.ComingOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ComingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComingOrders.Location = new System.Drawing.Point(6, 44);
            this.ComingOrders.Name = "ComingOrders";
            this.ComingOrders.Size = new System.Drawing.Size(455, 195);
            this.ComingOrders.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dateForPlan);
            this.groupBox4.Controls.Add(this.ResponsibleBox);
            this.groupBox4.Controls.Add(this.AmountForPlan);
            this.groupBox4.Controls.Add(this.PlanProductBox);
            this.groupBox4.Location = new System.Drawing.Point(15, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 300);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Добавить в план";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата для заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отвественный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кол-во";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Товар";
            // 
            // dateForPlan
            // 
            this.dateForPlan.Location = new System.Drawing.Point(6, 167);
            this.dateForPlan.Name = "dateForPlan";
            this.dateForPlan.Size = new System.Drawing.Size(200, 20);
            this.dateForPlan.TabIndex = 3;
            // 
            // ResponsibleBox
            // 
            this.ResponsibleBox.Location = new System.Drawing.Point(6, 123);
            this.ResponsibleBox.Name = "ResponsibleBox";
            this.ResponsibleBox.Size = new System.Drawing.Size(152, 20);
            this.ResponsibleBox.TabIndex = 2;
            // 
            // AmountForPlan
            // 
            this.AmountForPlan.Location = new System.Drawing.Point(6, 82);
            this.AmountForPlan.Name = "AmountForPlan";
            this.AmountForPlan.Size = new System.Drawing.Size(152, 20);
            this.AmountForPlan.TabIndex = 1;
            // 
            // PlanProductBox
            // 
            this.PlanProductBox.FormattingEnabled = true;
            this.PlanProductBox.Location = new System.Drawing.Point(6, 42);
            this.PlanProductBox.Name = "PlanProductBox";
            this.PlanProductBox.Size = new System.Drawing.Size(152, 21);
            this.PlanProductBox.TabIndex = 0;
            // 
            // Tabe
            // 
            this.Tabe.Controls.Add(this.tabPage1);
            this.Tabe.Controls.Add(this.tabPage2);
            this.Tabe.Controls.Add(this.tabPage3);
            this.Tabe.Location = new System.Drawing.Point(3, 2);
            this.Tabe.Name = "Tabe";
            this.Tabe.SelectedIndex = 0;
            this.Tabe.Size = new System.Drawing.Size(981, 583);
            this.Tabe.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "План";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Прайс-лист";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.MaxDiscount);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.PriceForList);
            this.groupBox6.Controls.Add(this.ProductBox2);
            this.groupBox6.Location = new System.Drawing.Point(6, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(300, 239);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Обновить данные";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Макс. скидка";
            // 
            // MaxDiscount
            // 
            this.MaxDiscount.Location = new System.Drawing.Point(6, 132);
            this.MaxDiscount.Name = "MaxDiscount";
            this.MaxDiscount.Size = new System.Drawing.Size(151, 20);
            this.MaxDiscount.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Товар";
            // 
            // PriceForList
            // 
            this.PriceForList.Location = new System.Drawing.Point(6, 84);
            this.PriceForList.Name = "PriceForList";
            this.PriceForList.Size = new System.Drawing.Size(151, 20);
            this.PriceForList.TabIndex = 1;
            // 
            // ProductBox2
            // 
            this.ProductBox2.FormattingEnabled = true;
            this.ProductBox2.Location = new System.Drawing.Point(6, 40);
            this.ProductBox2.Name = "ProductBox2";
            this.ProductBox2.Size = new System.Drawing.Size(151, 21);
            this.ProductBox2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PriceListGrid);
            this.groupBox5.Location = new System.Drawing.Point(312, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(516, 239);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Прайс-лист";
            // 
            // PriceListGrid
            // 
            this.PriceListGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PriceListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceListGrid.Location = new System.Drawing.Point(6, 34);
            this.PriceListGrid.Name = "PriceListGrid";
            this.PriceListGrid.Size = new System.Drawing.Size(504, 199);
            this.PriceListGrid.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.BuyGroupBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(973, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Накладные";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Consuption);
            this.groupBox8.Location = new System.Drawing.Point(499, 50);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(470, 374);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Продажи";
            // 
            // Consuption
            // 
            this.Consuption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Consuption.Location = new System.Drawing.Point(6, 46);
            this.Consuption.Name = "Consuption";
            this.Consuption.Size = new System.Drawing.Size(458, 322);
            this.Consuption.TabIndex = 1;
            // 
            // BuyGroupBox
            // 
            this.BuyGroupBox.Controls.Add(this.Invoice_Coming);
            this.BuyGroupBox.Location = new System.Drawing.Point(5, 50);
            this.BuyGroupBox.Name = "BuyGroupBox";
            this.BuyGroupBox.Size = new System.Drawing.Size(470, 374);
            this.BuyGroupBox.TabIndex = 0;
            this.BuyGroupBox.TabStop = false;
            this.BuyGroupBox.Text = "Покупка";
            // 
            // Invoice_Coming
            // 
            this.Invoice_Coming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoice_Coming.Location = new System.Drawing.Point(6, 46);
            this.Invoice_Coming.Name = "Invoice_Coming";
            this.Invoice_Coming.Size = new System.Drawing.Size(458, 322);
            this.Invoice_Coming.TabIndex = 0;
            // 
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 584);
            this.Controls.Add(this.Tabe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stat";
            this.Text = "Экономист";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stat_FormClosed);
            this.Load += new System.EventHandler(this.Stat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPlan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComingOrders)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Tabe.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PriceListGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Consuption)).EndInit();
            this.BuyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_Coming)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.DataGridView CurrentProd;
        private Windows.Forms.DataGridView BuyPlan;
        private Windows.Forms.GroupBox groupBox1;
        private Windows.Forms.GroupBox groupBox2;
        private Windows.Forms.ComboBox ResponsibleFilter;
        private Windows.Forms.ComboBox SkladFilter;
        private Windows.Forms.GroupBox groupBox3;
        private Windows.Forms.DataGridView ComingOrders;
        private Windows.Forms.GroupBox groupBox4;
        private Windows.Forms.Button button1;
        private Windows.Forms.Label label4;
        private Windows.Forms.Label label3;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label label1;
        private Windows.Forms.DateTimePicker dateForPlan;
        private Windows.Forms.TextBox ResponsibleBox;
        private Windows.Forms.TextBox AmountForPlan;
        private Windows.Forms.ComboBox PlanProductBox;
        private Windows.Forms.TabControl Tabe;
        private Windows.Forms.TabPage tabPage1;
        private Windows.Forms.TabPage tabPage2;
        private Windows.Forms.GroupBox groupBox5;
        private Windows.Forms.DataGridView PriceListGrid;
        private Windows.Forms.GroupBox groupBox6;
        private Windows.Forms.Button button2;
        private Windows.Forms.Label label7;
        private Windows.Forms.TextBox MaxDiscount;
        private Windows.Forms.Label label6;
        private Windows.Forms.Label label5;
        private Windows.Forms.TextBox PriceForList;
        private Windows.Forms.ComboBox ProductBox2;
        private Windows.Forms.TabPage tabPage3;
        private Windows.Forms.GroupBox groupBox8;
        private Windows.Forms.DataGridView Consuption;
        private Windows.Forms.GroupBox BuyGroupBox;
        private Windows.Forms.DataGridView Invoice_Coming;
    }
}