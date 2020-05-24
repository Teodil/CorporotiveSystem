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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += " "+Settings1.Default.Version;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DB.conectionString = "server=localhost;user id=root; password=root; database=corporativesystem";
            DB.SetConnectParam();
            DB.Connect();
            DataTable data = DB.LoadData("select * from users where login='"+textBox1.Text+"' and password='"+textBox2.Text+"'");
            if (data.Rows.Count > 0)
            {
                int status = data.Rows[0].Field <Int32>("status");
                switch (status)
                {
                    case 1:
                        Admin admin = new Admin();
                        admin.Show();
                        break;
                    case 2:
                        
                        Sklad sklad = new Sklad() { ReturnForm = this };
                        sklad.Show();
                        Hide();
                        break;
                    case 3:
                        Buy buy = new Buy() { ReturnForm = this};
                        buy.Show();
                        Hide();
                        break;
                    case 4:
                        Sell sell = new Sell() {ReturnForm = this};
                        sell.Show();
                        Hide();
                        break;
                    case 5:
                        Stat stat = new Stat() { ReturnForm = this};
                        stat.Show();
                        Hide();
                        break;
                    default:
                        MessageBox.Show("Не удаётся индефицировать пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();
            Settings.Show();
        }
    }
}
