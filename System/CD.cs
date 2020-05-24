using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    /// <summary>
    /// Класс для хроненения и инициализации команд для БД
    /// </summary>
    public static class CD
    {
        public static string ComingOrders = "select com.id as '№', prod.Name as 'Товар',str.Amount as 'Кол-во',str.Price as 'Цена',com.Date as 'Дата заказа', sup.Name as 'Поставщик', com.Status as 'Статус', W.Naim as 'Склад' from stroka_order_com as str join coming_order as com join product as prod join warehouse as W join supplier as sup where str.Coming_Order_id = com.id and com.Supplier_id = W.id and com.Supplier_id = sup.id and str.Product_id = prod.id;";
        public static string ComingOrders2 = "select com.id as '№', prod.Name as 'Товар',str.Amount as 'Кол-во',str.Price as 'Цена',com.Date as 'Дата заказа', sup.Name as 'Поставщик',str.Procurement_Plan_id as '№ заказа', com.Status as 'Статус', W.Naim as 'Склад' from stroka_order_com as str join coming_order as com join product as prod join warehouse as W join supplier as sup where str.Coming_Order_id = com.id and com.Supplier_id = W.id and com.Supplier_id = sup.id and str.Product_id = prod.id;";
        public static string CurentProd = "select P.Name as 'Товар', N.Length as 'Длина', P.Unit as 'ед. измер.', N.Number as 'Индекс', W.Naim as 'Склад' from namotka as N join katyshka as K join product as P join warehouse as W where N.Katyshka_Id = K.Id and N.Product_id = P.id and K.Warehouse_id = W.id;";
        public static string SalesOrders = "select ord.id as '№', P.Name as 'Товар', S.Price as 'Цена', S.Amount as 'Кол-во', C.Name as 'Клиент', ord.Status as 'Статус', ord.Date 'Дата' from sales as S join sales_order as ord join client as C join product as P where S.Sales_Order_id = ord.id and S.Product_id = P.id and ord.Client_id = C.id;";
        public static string PriceList = "select prod.Name as 'Товар',Price as 'Цена руб.',prod.Unit as 'Ед. изм.', PL.Max_Discount as 'Макс. Скидка %', PL.Date as 'Дата' from price_list as PL join product as prod where PL.Product_id = prod.id;";
        public static string Plan = "select Plan.id, Pr.name as 'Товар', Plan.Amount_For_Plane as 'Кол-во',Plan.status as 'Статус' , Plan.Responsible as 'Отвественный', Plan.Execution_Date as 'Дата заказа' from procurement_plan as Plan join product as Pr where Plan.Product_id = Pr.id;";
        public static string Invoice_Coming = "select P.Name as 'Товар', IC.Amount as 'Кол-во', IC.Price as 'Цена', C.СomingDate 'Дата прихода', W.Naim as 'Склад' from invoice_coming as IC join сoming as C join product as P join warehouse as W  where IC.Сoming_id = C.id and IC.Product_id = P.id and W.id=C.Warehouse_id;";
        public static string Invoice_Consuption = "select  P.name as 'Товар', IC.Amount as 'Кол-во', IC.Price as 'Цена', C.Date as 'Дата расхода', client.name as 'Клиент', W.Naim as 'Склад' from invoice_сonsumption as IC join сonsumption as C join warehouse as W join product as P join client where IC.Product_id=P.id and IC.Сonsumption_id = C.id and C.Warehouse_id = W.id and C.Client_id = client.id;";

        /// <summary>
        /// Функция для получения команды для загрузки в БД информации о приходе в таблицу сoming
        /// </summary>
        /// <param name="Supplier">id поставщика</param>
        /// <param name="Warehouse">id Склада</param>
        /// <param name="date">date time picker из которого брать дату</param>
        /// <returns>команда</returns>
        public static string ComingInsertPart1(int Supplier, int Warehouse, DateTimePicker date)
        {
            date.CustomFormat = "yyyy-MM-dd";
            date.Format = DateTimePickerFormat.Custom;
            string command = "insert into сoming(СomingDate,Supplier_id,Warehouse_id) values ('" + date.Text + "'," + Supplier + "," + Warehouse + ");";
            return command;
        }
        /// <summary>
        /// Функция для получения команды для загрузки в БД информации о приходе в таблицу invoice_coming
        /// </summary>
        /// <param name="id">id coming</param>
        /// <param name="product">id Продукта</param>
        /// <param name="amount">Кол-во</param>
        /// <param name="price">Цена</param>
        /// <returns>Команда</returns>
        public static string ComingInsertPart2(int id, int product, double amount, double price)
        {
            string command = "insert into invoice_coming(Сoming_id,Product_id,Amount,Price) values (" + id + "," + product + "," + amount + "," + price + ");";
            return command;
        }
        /// <summary>
        /// Функция для получения команды для загрузки в БД информации о расходе в таблицу сonsumption
        /// </summary>
        /// <param name="Warehouse">id Склада</param>
        /// <param name="Client_id">id Клиента</param>
        /// <param name="date">Дата</param>
        /// <returns>Команда</returns>
        public static string ConsumptionInsertPart1(int Warehouse, int Client_id, DateTimePicker date)
        {
            date.CustomFormat = "yyyy-MM-dd";
            date.Format = DateTimePickerFormat.Custom;
            string command = "insert into сonsumption(Date, Warehouse_id, Client_id) values ('" + date.Text + "'," + Warehouse + "," + Client_id + ");";
            return command;
        }
        /// <summary>
        /// Функция для получения команды для загрузки в БД информации о расходе в таблицу invoice_сonsumption
        /// </summary>
        /// <param name="id">Сonsumption id</param>
        /// <param name="product">id Продукта</param>
        /// <param name="amount">Кол-ва</param>
        /// <param name="price">Цена</param>
        /// <returns>Команда</returns>
        public static string ConsumptionInsertPart2(int id, int product, double amount, double price)
        {
            string command = "insert into invoice_сonsumption(Сonsumption_id, Product_id,Amount,Price) values(" + id + "," + product + "," + amount + "," + price + ");";
            return command;
        }

        public static string RashodKatyshki(string Index, double amount)
        {
            int id = DB.LoadData("select id from namotka where Number='" + Index + "';").Rows[0].Field<int>("id");
            double DBamount = DB.LoadData("select Length from namotka where Number='" + Index + "';").Rows[0].Field<double>("Length");
            string command;
            if (amount < DBamount)
            {
                double num = DBamount - amount;
                command = "update namotka set Length="+num+" where id="+id+";";
            }
            else
            {
                command = "delete from namotka where id=" + id + ";";
            }
            return command;
        }
        public static string UpdateOnePole(string Table, string Pole, string Change, string ConditionPole, string Condition)
        {
            string command = $"update {Table} set {Pole}='{Change}' where {ConditionPole}='{Condition}';";
            return command;
        }

        public static string DeleteRowFromTable(string Table, string ConditionPole, string Condition)
        {
            string command="delete from "+Table+" where "+ConditionPole+"='"+Condition+"';";
            return command;
        }
        public static string GetOneRow(string Table, string Pole, string ConditionPole, string Condition)
        {
            string command = "select "+Pole+" from "+Table+" where "+ConditionPole+"='"+Condition+"';";
            return command;
        }
        public static string GetOneRow(string Table, string Pole)
        {
            string command = "select " + Pole + " from " + Table +";";
            return command;
        }
        public static string KatyshkaInsert(string Length, string Number, int Katyshka_Id, int Product_id)
        {
            string command = "insert into namotka(Length,Number,Katyshka_Id,Product_id) values(" + Length + ",'" + Number + "'," + Katyshka_Id + "," + Product_id + ");";
            return command;
        }

        public static string SalesOrderInsertPart1(DateTimePicker date,string ClientId, string Status)
        {
            date.CustomFormat = "yyyy-MM-dd";
            date.Format = DateTimePickerFormat.Custom;
            string command = $"insert into sales_order(Date,Client_id,Status) values('{date.Text}',{ClientId},'{Status}');";
            return command;
        }
        public static string SalesOrderInsertPart2(string SalesID, string PoductId, string Amount, string Price)
        {
            string command = $"insert into sales(Sales_Order_id,Product_id,Amount,Price) values({SalesID},{PoductId},{Amount},{Price});";
            return command;
        }
        public static string PlanInsert(string ProductId, string Amount, string Responsible, DateTimePicker date)
        {
            date.CustomFormat = "yyyy-MM-dd";
            date.Format = DateTimePickerFormat.Custom;
            string command = $"insert into procurement_plan(Product_id,Amount_For_Plane,Responsible,Execution_Date,status) values('{ProductId}','{Amount}','{Responsible}','{date.Text}','Не заказан');";
            return command;
        }
        public static string ComingOrderInsertPart1(string date, string Warehouse_id, string Supplier_id, string Status)
        {
            //date.CustomFormat = "yyyy-MM-dd";
            //date.Format = DateTimePickerFormat.Custom;
            string command = $"insert into coming_order(Date,Warehouse_id,Supplier_id, Status) values('{date}','{Warehouse_id}','{Supplier_id}','{Status}');";
            return command;
        }
        public static string ComingOrderInsertPart2(string Coming_Order_id,string Product_id, string Amount, string Price,string Procurement_Plan_id)
        {
            string command = $"insert into stroka_order_com(Coming_Order_id,Product_id,Amount, Price,Procurement_Plan_id) values('{Coming_Order_id}','{Product_id}','{Amount}','{Price}','{Procurement_Plan_id}');";
            return command;
        }

    }
}
