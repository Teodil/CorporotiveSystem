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
    public partial class Buy : Form
    {
        public Form ReturnForm;
        //private DataTable TablePriceList = new DataTable();
        private DataTable TableOrders = new DataTable();
        private DataTable TablePlan = new DataTable();
        private DataTable Products;
        private DataTable Warehouses;
        private DataTable SupplierInfo;

        public Buy()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            this.Text += " " + Settings1.Default.Version;
            LoadData();
        }
        private void TablesLoad()
        {
            TablePlan = DB.LoadData(CD.Plan);
            TableOrders = DB.LoadData(CD.ComingOrders2);
            //TablePriceList = DB.LoadData(CD.PriceList);

            //PriceList.DataSource = TablePriceList;
            Orders.DataSource = TableOrders;
            BuyPlan.DataSource = TablePlan;

        }

        private void LoadData()
        {
            Products = DB.LoadData("select id,name from product");
            Warehouses = DB.LoadData("select * from warehouse");
            SupplierInfo = DB.LoadData("select * from supplier");
            TablesLoad();

            List<string> Check = new List<string>();
            for (int i = 0; i < TablePlan.Rows.Count; i++)
            {
                if (i == 0)
                {
                    ResponsibleFilter.Items.Add(TablePlan.Rows[i].Field<string>("Отвественный"));
                    Check.Add(TablePlan.Rows[i].Field<string>("Отвественный"));
                }
                else
                {
                    bool Same = false;
                    for (int j = 0; j < Check.Count; j++)
                    {
                        if (Check[j] == TablePlan.Rows[i].Field<string>("Отвественный"))
                        {
                            Same = true;
                        }
                    }
                    if (!Same)
                    {
                        ResponsibleFilter.Items.Add(TablePlan.Rows[i].Field<string>("Отвественный"));
                        Check.Add(TablePlan.Rows[i].Field<string>("Отвественный"));
                    }
                }

            }

            for (int i = 0; i < Warehouses.Rows.Count; i++)
            {
                WarehouseBox.Items.Add(Warehouses.Rows[i].Field<string>("Naim"));
            }

            for (int i = 0; i < Products.Rows.Count; i++)
            {
                ProductBox.Items.Add(Products.Rows[i].Field<string>("name"));
            }
            for (int i = 0; i < SupplierInfo.Rows.Count; i++)
            {
                SupplierBox.Items.Add(SupplierInfo.Rows[i].Field<string>("Name"));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(PriceBox.Text) && !String.IsNullOrEmpty(AmountBox.Text) && !String.IsNullOrEmpty(ProductBox.Text) && !String.IsNullOrEmpty(PlanIdBox.Text) && !String.IsNullOrEmpty(WarehouseBox.Text) && !String.IsNullOrEmpty(SupplierBox.Text))
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string WarehouseID = DB.LoadData(CD.GetOneRow("warehouse", "id", "Naim", WarehouseBox.Text)).Rows[0].Field<int>("id").ToString();
                string SupplierID = DB.LoadData(CD.GetOneRow("supplier", "id", "Name", SupplierBox.Text)).Rows[0].Field<int>("id").ToString();
                DB.LoadData(CD.ComingOrderInsertPart1(date, WarehouseID, SupplierID, "Ожидает прибытия"));

                string MaxId = DB.LoadData("select MAX(id) as 'id' from coming_order;").Rows[0].Field<Int32>("id").ToString();
                string ProductID = DB.LoadData(CD.GetOneRow("product", "id", "Name", ProductBox.Text)).Rows[0].Field<Int32>("id").ToString();
                DB.LoadData(CD.ComingOrderInsertPart2(MaxId, ProductID, AmountBox.Text, PriceBox.Text, PlanIdBox.Text));
                DB.LoadData(CD.UpdateOnePole("procurement_plan", "status", "Заказан", "id", PlanIdBox.Text));
                TablesLoad();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResponsibleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResponsibleFilter.Text == "Все")
            {
                (BuyPlan.DataSource as DataTable).DefaultView.RowFilter = null;

            }
            else
            {
                (BuyPlan.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Отвественный like '{0}%'", ResponsibleFilter.Text);
            }
        }

        private void Buy_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReturnForm.Show();
        }
    }
}
