namespace System
{
    partial class Admin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.APMStat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.APMStat);
            this.groupBox1.Controls.Add(this.PasswordText);
            this.groupBox1.Controls.Add(this.loginText);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить пользователя";
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(6, 44);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(166, 20);
            this.loginText.TabIndex = 0;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(6, 91);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(166, 20);
            this.PasswordText.TabIndex = 1;
            // 
            // APMStat
            // 
            this.APMStat.FormattingEnabled = true;
            this.APMStat.Items.AddRange(new object[] {
            "Склад",
            "Статистика",
            "Закупка",
            "Продажа"});
            this.APMStat.Location = new System.Drawing.Point(6, 142);
            this.APMStat.Name = "APMStat";
            this.APMStat.Size = new System.Drawing.Size(166, 21);
            this.APMStat.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "APM";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 335);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.GroupBox groupBox1;
        private Windows.Forms.Label label3;
        private Windows.Forms.Label label2;
        private Windows.Forms.Label label1;
        private Windows.Forms.Button button1;
        private Windows.Forms.ComboBox APMStat;
        private Windows.Forms.TextBox PasswordText;
        private Windows.Forms.TextBox loginText;
    }
}