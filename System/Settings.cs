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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ServerText.Text !=null && ServerText.Text != "")
            {
                Settings1.Default.Server = ServerText.Text;
            }
            if(LoginText.Text != null && LoginText.Text != "")
            {
                Settings1.Default.UserID = LoginText.Text;
            }
            if(PasswordText.Text != null && PasswordText.Text != "")
            {
                Settings1.Default.Password = PasswordText.Text;
            }
            if(DataBaseText.Text != null && DataBaseText.Text != "")
            {
                Settings1.Default.Database = DataBaseText.Text;
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
