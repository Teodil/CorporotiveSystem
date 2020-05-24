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
    public partial class Sklad : Form
    {
        public Form ReturnForm;

        private int SelectedRow;

        private DataTable SupplierInfo = new DataTable();
        private DataTable Products = new DataTable();
        private DataTable Warehouses = new DataTable();
        private DataTable Clients = new DataTable();
        private DataTable TableComingOrders = new DataTable();
        private DataTable TableCurentProd = new DataTable();
        private DataTable TableSalesOrders = new DataTable();

        public Sklad()
        {
            InitializeComponent();
        }

        private void Sklad_Load(object sender, EventArgs e)
        {
            this.Text += " " + Settings1.Default.Version;
            LoadData();
        }

        private void TablesLoad()
        {
            TableComingOrders = DB.LoadData(CD.ComingOrders);
            TableCurentProd = DB.LoadData(CD.CurentProd);
            TableSalesOrders = DB.LoadData(CD.SalesOrders);

            ComingOrders.DataSource = TableComingOrders;
            CurentProd.DataSource = TableCurentProd;
            CurentProd2.DataSource = TableCurentProd;
            SalesOrders.DataSource = TableSalesOrders;
        }

        private void LoadData()
        {
            Products = DB.LoadData("select id,name from product");
            Warehouses = DB.LoadData("select * from warehouse");
            SupplierInfo = DB.LoadData("select * from supplier");
            Clients = DB.LoadData("select * from client");

            TablesLoad();
           

            for (int i = 0; i < Products.Rows.Count; i++)
            {
                ProductsBox.Items.Add(Products.Rows[i].Field<string>("name"));
                SalesProd.Items.Add(Products.Rows[i].Field<string>("name"));
                NamotkaProduct.Items.Add(Products.Rows[i].Field<string>("name"));
            }
            for (int i = 0; i < Warehouses.Rows.Count; i++)
            {
                WarehouseBox.Items.Add(Warehouses.Rows[i].Field<string>("Naim"));
                WarehouseBox2.Items.Add(Warehouses.Rows[i].Field<string>("Naim"));
                WarehouseBox3.Items.Add(Warehouses.Rows[i].Field<string>("Naim"));
                SkladFilter.Items.Add(Warehouses.Rows[i].Field<string>("Naim"));
                CurentFilter.Items.Add(Warehouses.Rows[i].Field<string>("Naim"));
                CurentFilter2.Items.Add(Warehouses.Rows[i].Field<string>("Naim"));
            }
            for (int i = 0; i < SupplierInfo.Rows.Count; i++)
            {
                SupplierBox.Items.Add(SupplierInfo.Rows[i].Field<string>("name"));
            }
            for (int i = 0; i < Clients.Rows.Count; i++)
            {
                ClientComboBox.Items.Add(Clients.Rows[i].Field<string>("Name"));
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(WarehouseBox2.Text) && !string.IsNullOrEmpty(ClientComboBox.Text) && !string.IsNullOrEmpty(SalesProd.Text) && !string.IsNullOrEmpty(RashodNum.Text) && !string.IsNullOrEmpty(Kotyshka.Text) && !string.IsNullOrEmpty(SalesAmount.Text) && !string.IsNullOrEmpty(SalesPrice.Text))
            {
                int warehouseID = DB.LoadData("select id from warehouse where Naim='" + WarehouseBox2.Text + "';").Rows[0].Field<Int32>("id");
                int ClientID = DB.LoadData("select id from client where Name='" + ClientComboBox.Text + "';").Rows[0].Field<Int32>("id");
                int prodId = DB.LoadData("select id from product where Name='" + SalesProd.Text + "';").Rows[0].Field<Int32>("id");
                DB.LoadData(CD.ConsumptionInsertPart1(warehouseID, ClientID, dateTimePicker2));
                int MaxId = DB.LoadData("select MAX(id) as 'id' from сonsumption;").Rows[0].Field<Int32>("id");
                DB.LoadData(CD.ConsumptionInsertPart2(MaxId, prodId, Convert.ToDouble(SalesAmount.Text), Convert.ToDouble(SalesPrice.Text)));
                DB.LoadData(CD.UpdateOnePole("sales_order", "Status", "Отгружен", "id", RashodNum.Text));
                int idKat = DB.LoadData("select Katyshka_Id from namotka where Number='" + Kotyshka.Text + "';").Rows[0].Field<int>("Katyshka_Id");
                DB.LoadData(CD.RashodKatyshki(Kotyshka.Text, Convert.ToDouble(SalesAmount.Text)));
                try
                {
                    idKat = DB.LoadData("select Katyshka_Id from namotka where Number='" + Kotyshka.Text + "';").Rows[0].Field<int>("Katyshka_Id");
                }
                catch
                {
                    DB.LoadData(CD.DeleteRowFromTable("katyshka", "Id", idKat.ToString()));
                }

                TablesLoad();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(WarehouseBox.Text) && !String.IsNullOrEmpty(SupplierBox.Text) && !String.IsNullOrEmpty(ProductsBox.Text) && !String.IsNullOrEmpty(AmountBox.Text) && !String.IsNullOrEmpty(OrderNum.Text) && !String.IsNullOrEmpty(PriceBox.Text))
            {
                int warehouseID = DB.LoadData("select id from warehouse where Naim='" + WarehouseBox.Text + "';").Rows[0].Field<Int32>("id");
                int supplierID = DB.LoadData("select id from supplier where Name='" + SupplierBox.Text + "';").Rows[0].Field<Int32>("id");
                int prodId = DB.LoadData("select id from product where Name='" + ProductsBox.Text + "';").Rows[0].Field<Int32>("id");
                DB.LoadData(CD.ComingInsertPart1(supplierID, warehouseID, dateTimePicker1));
                int MaxId = DB.LoadData("select MAX(id) as 'id' from сoming;").Rows[0].Field<Int32>("id");
                DB.LoadData(CD.ComingInsertPart2(MaxId, prodId, Convert.ToDouble(AmountBox.Text), Convert.ToDouble(PriceBox.Text)));
                DB.LoadData("Update coming_order set Status='Принят' where id=" + OrderNum.Text + ";");

                TablesLoad();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void Sklad_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReturnForm.Show();
        }

        private void SkladFilter_TextUpdate(object sender, EventArgs e)
        {

        }

        private void SkladFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SkladFilter.Text == "Все")
            {
                (ComingOrders.DataSource as DataTable).DefaultView.RowFilter = null;
                
            }
            else
            {
                (ComingOrders.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Склад like '{0}%'", SkladFilter.Text);
            }
        }

        private void Sklad_ResizeBegin(object sender, EventArgs e)
        {
        }

        private void Sklad_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void ComingOrders_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void ComingOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = ComingOrders.SelectedCells[0].RowIndex;
            OrderNum.Text = ComingOrders.Rows[SelectedRow].Cells[0].Value.ToString();
            ProductsBox.Text = ComingOrders.Rows[SelectedRow].Cells[1].Value.ToString();
            AmountBox.Text = ComingOrders.Rows[SelectedRow].Cells[2].Value.ToString();
            PriceBox.Text = ComingOrders.Rows[SelectedRow].Cells[3].Value.ToString();
            WarehouseBox.Text = ComingOrders.Rows[SelectedRow].Cells[7].Value.ToString();
            SupplierBox.Text = ComingOrders.Rows[SelectedRow].Cells[5].Value.ToString();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            TablesLoad();
        }

        private void ComingOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void SalesOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = SalesOrders.SelectedCells[0].RowIndex;
            RashodNum.Text = SalesOrders.Rows[SelectedRow].Cells[0].Value.ToString();
            SalesProd.Text = SalesOrders.Rows[SelectedRow].Cells[1].Value.ToString();
            SalesAmount.Text = SalesOrders.Rows[SelectedRow].Cells[3].Value.ToString();
            SalesPrice.Text = SalesOrders.Rows[SelectedRow].Cells[2].Value.ToString();
            //WarehouseBox2.Text = SalesOrders.Rows[SelectedRow].Cells[7].Value.ToString();
            ClientComboBox.Text = SalesOrders.Rows[SelectedRow].Cells[4].Value.ToString();
        }

        private void CurentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurentFilter.Text == "Все")
            {
                (CurentProd.DataSource as DataTable).DefaultView.RowFilter = null;

            }
            else
            {
                (CurentProd.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Склад like '{0}%'", CurentFilter.Text);
            }
        }

        private void CurentProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = CurentProd.SelectedCells[0].RowIndex;
            Kotyshka.Text = TableCurentProd.Rows[SelectedRow].Field<string>("Индекс");
            WarehouseBox2.Text = CurentProd.Rows[SelectedRow].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(WarehouseBox3.Text) && !String.IsNullOrEmpty(NamotkaProduct.Text) && !String.IsNullOrEmpty(NamotkaAmount1.Text) && !String.IsNullOrEmpty(NamotkaIndex1.Text))
            {
                int WarehouseId = DB.LoadData(CD.GetOneRow("warehouse", "id", "Naim", WarehouseBox3.Text)).Rows[0].Field<int>("id");
                DB.LoadData("insert into katyshka(Warehouse_id) values(" + WarehouseId + ");");
                int KatyshkaId = DB.LoadData(CD.GetOneRow("katyshka", "MAX(id) as 'id'")).Rows[0].Field<int>("id");
                int prodId = DB.LoadData(CD.GetOneRow("product", "id", "Name", NamotkaProduct.Text)).Rows[0].Field<int>("id");
                DB.LoadData(CD.KatyshkaInsert(NamotkaAmount1.Text, NamotkaIndex1.Text, KatyshkaId, prodId));
                TablesLoad();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CurentFilter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurentFilter2.Text == "Все")
            {
                (CurentProd2.DataSource as DataTable).DefaultView.RowFilter = null;

            }
            else
            {
                (CurentProd.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Склад like '{0}%'", CurentFilter2.Text);
            }
        }

        private void RefreshSales_Click(object sender, EventArgs e)
        {
            TablesLoad();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TablesLoad();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TablesLoad();
        }

        private void NamotkaProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(NamotkaIndex2.Text) && !String.IsNullOrEmpty(NamotkaAmount2.Text))
            {
                double DBamount = DB.LoadData("select Length from namotka where Number='" + NamotkaIndex2.Text + "';").Rows[0].Field<double>("Length");
                double UpdateAmount = Convert.ToDouble(NamotkaAmount2.Text);
                if (UpdateAmount < 0)
                {
                    if (DBamount > (UpdateAmount * GetSign(UpdateAmount)))
                    {
                        DBamount += Convert.ToDouble(NamotkaAmount2.Text);
                        DB.LoadData(CD.UpdateOnePole("namotka", "Length", DBamount.ToString(), "Number", NamotkaIndex2.Text));

                    }
                    else
                    {
                        DB.LoadData(CD.DeleteRowFromTable("namotka", "Number", NamotkaIndex2.Text));
                    }
                }
                else
                {
                    DBamount += Convert.ToDouble(NamotkaAmount2.Text);
                    DB.LoadData(CD.UpdateOnePole("namotka", "Length", DBamount.ToString(), "Number", NamotkaIndex2.Text));
                }
                TablesLoad();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int GetSign(int x)
        {
            if (x > 0)
            {
                return x / x;
            }
            else
            {
                return x / x * -1;
            }
        }
        private double GetSign(double x)
        {
            if (x > 0)
            {
                return x / x;
            }
            else
            {
                return (x / x) * -1;
            }
        }

        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
