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
    public partial class Sell : Form
    {
        public Form ReturnForm;

        private int SelectedRow;

        private DataTable Products = new DataTable();
        private DataTable Clients = new DataTable();
        private DataTable Warehouses = new DataTable();
        private DataTable TableCurentProd = new DataTable();
        private DataTable TablePriceList = new DataTable();


        public Sell()
        {
            InitializeComponent();
        }

        private void TablesLoad()
        {
            TableCurentProd = DB.LoadData(CD.CurentProd);
            TablePriceList = DB.LoadData(CD.PriceList);
            CurentPord.DataSource = TableCurentProd;
            PriceList.DataSource = TablePriceList;
        }

        private void LoadData()
        {
            Products = DB.LoadData("select id,name from product");
            Clients = DB.LoadData("select * from client");
            Warehouses = DB.LoadData("select * from warehouse");

            TablesLoad();


            for (int i = 0; i < Products.Rows.Count; i++)
            {
                ProductBox.Items.Add(Products.Rows[i].Field<string>("name"));
            }
            for (int i = 0; i < Clients.Rows.Count; i++)
            {
                ClientComboBox.Items.Add(Clients.Rows[i].Field<string>("Name"));
            }
            for (int i = 0; i < Warehouses.Rows.Count; i++)
            {
                CurentFilter.Items.Add(Warehouses.Rows[i].Field<string>("Naim"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ClientComboBox.Text) && !String.IsNullOrEmpty(ProductBox.Text) && !String.IsNullOrEmpty(Amount.Text) && !String.IsNullOrEmpty(Price.Text))
            {
                int ClientId = DB.LoadData(CD.GetOneRow("client", "id", "Name", ClientComboBox.Text)).Rows[0].Field<Int32>("id");
                DB.LoadData(CD.SalesOrderInsertPart1(dateTimePicker1, ClientId.ToString(), "Ожидает отгрузки"));
                int Max = DB.LoadData(CD.GetOneRow("sales_order", "MAX(id) as 'id'")).Rows[0].Field<Int32>("id");
                int ProductID = DB.LoadData(CD.GetOneRow("product", "id", "Name", ProductBox.Text)).Rows[0].Field<Int32>("id");
                DB.LoadData(CD.SalesOrderInsertPart2(Max.ToString(), ProductID.ToString(), Amount.Text, Price.Text));
            }
            else
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Sell_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReturnForm.Show();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CurentPord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PriceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurentFilter.Text == "Все")
            {
                (CurentPord.DataSource as DataTable).DefaultView.RowFilter = null;

            }
            else
            {
                (CurentPord.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Склад like '{0}%'", CurentFilter.Text);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.DarkGray; 
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }
    }
}
