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
    public partial class FullSizeGreed : Form
    {
        public DataTable Table;
        public ComboBox Filter;
        public FullSizeGreed()
        {
            InitializeComponent();
        }

        private void FullSizeGreed_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Table;
            if (Filter.Items.Count > 0)
            {
                comboBox1 = Filter;
            }
            else
            {
                comboBox1.Hide();
            }
        }
    }
}
