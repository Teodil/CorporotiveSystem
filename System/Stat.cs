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
    public partial class Stat : Form
    {

        public Form ReturnForm;

        private int SelectedRow;

        public DataTable TableCurenProd = new DataTable();
        public DataTable TablePlan = new DataTable();
        public DataTable TablePiceList = new DataTable();
        public DataTable Warehouses = new DataTable();
        private DataTable TablesComingOrders = new DataTable();
        private DataTable Products = new DataTable();
        private DataTable TableInvoice_Coming = new DataTable();
        private DataTable TableInvoice_Consuption = new DataTable();

        private void TablesLoad()
        {
            /*TableComingOrders = DB.LoadData(CD.ComingOrders);
            TableCurentProd = DB.LoadData(CD.CurentProd);
            TableSalesOrders = DB.LoadData(CD.SalesOrders);

            ComingOrders.DataSource = TableComingOrders;
            CurentProd.DataSource = TableCurentProd;
            CurentProd2.DataSource = TableCurentProd;
            SalesOrders.DataSource = TableSalesOrders;*/
            TableInvoice_Consuption = DB.LoadData(CD.Invoice_Consuption);
            TableInvoice_Coming = DB.LoadData(CD.Invoice_Coming);
            TableCurenProd = DB.LoadData(CD.CurentProd);
            TablePiceList = DB.LoadData(CD.PriceList);
            TablePlan = DB.LoadData(CD.Plan);
            Warehouses = DB.LoadData("select * from warehouse");
            TablesComingOrders = DB.LoadData(CD.ComingOrders2);

            CurrentProd.DataSource = TableCurenProd;
            BuyPlan.DataSource = TablePlan;
            ComingOrders.DataSource = TablesComingOrders;
            PriceListGrid.DataSource = TablePiceList;
            Invoice_Coming.DataSource = TableInvoice_Coming;
            Consuption.DataSource = TableInvoice_Consuption;

        }

        private void LoadData()
        {
            Products = DB.LoadData("select id,name from product");
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
                    for(int j=0; j < Check.Count; j++)
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
                SkladFilter.Items.Add(Warehouses.Rows[i].Field<string>("Naim"));
            }
            
            for (int i = 0; i < Products.Rows.Count; i++)
            {
                PlanProductBox.Items.Add(Products.Rows[i].Field<string>("name"));
                ProductBox2.Items.Add(Products.Rows[i].Field<string>("name"));
            }
            /*for (int i = 0; i < Clients.Rows.Count; i++)
            {
                ClientComboBox.Items.Add(Clients.Rows[i].Field<string>("Name"));
            }*/
        }

        public Stat()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Stat_Load(object sender, EventArgs e)
        {
            this.Text += " " + Settings1.Default.Version;
            LoadData();
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

        private void SkladFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SkladFilter.Text == "Все")
            {
                (CurrentProd.DataSource as DataTable).DefaultView.RowFilter = null;

            }
            else
            {
                (CurrentProd.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Склад like '{0}%'", SkladFilter.Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AmountForPlan.Text) && !string.IsNullOrEmpty(ResponsibleBox.Text) && !string.IsNullOrEmpty(PlanProductBox.Text))
            {
                int prodId = DB.LoadData("select id from product where Name='" + PlanProductBox.Text + "';").Rows[0].Field<Int32>("id");
                DB.LoadData(CD.PlanInsert(prodId.ToString(), AmountForPlan.Text, ResponsibleBox.Text, dateForPlan));
                TablesLoad();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PriceForList.Text) && !string.IsNullOrEmpty(MaxDiscount.Text) && !string.IsNullOrEmpty(ProductBox2.Text))
            {
                int prodId = DB.LoadData("select id from product where Name='" + ProductBox2.Text + "';").Rows[0].Field<Int32>("id");
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                DB.LoadData(CD.UpdateOnePole("price_list", "Price", PriceForList.Text, "Product_id", prodId.ToString()));
                DB.LoadData(CD.UpdateOnePole("price_list", "Max_Discount", MaxDiscount.Text, "Product_id", prodId.ToString()));
                DB.LoadData(CD.UpdateOnePole("price_list", "Date", date, "Product_id", prodId.ToString()));
                TablesLoad();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            FullSizeGreed fullSizeGreed = new FullSizeGreed() { Table = TablePlan };
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            FullSizeGreed fullSizeGreed = new FullSizeGreed() { Table = TablePlan };
        }

        private void Stat_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReturnForm.Show();
        }
    }
}
