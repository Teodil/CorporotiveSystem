using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(loginText.Text) && !String.IsNullOrEmpty(PasswordText.Text) && !String.IsNullOrEmpty(APMStat.Text))
            {


                string stat = "";
                switch (APMStat.Text)
                {
                    case "Склад":
                        stat = "2";
                        break;
                    case "Статистика":
                        stat = "5";
                        break;
                    case "Закупка":
                        stat = "3";
                        break;
                    case "Продажа":
                        stat = "4";
                        break;
                    default:
                        break;
                }
                DB.LoadData($"insert into users(Login,Password,Status) values({loginText.Text},{PasswordText.Text},{stat});");
            }
            else
            {

            }
        }
    }
}
