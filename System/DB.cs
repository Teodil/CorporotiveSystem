using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace System
{
    public static class DB //Класс для взоимодействия с БД
    { 
        private static MySqlConnection _con = new MySqlConnection();
        private static string ConectionString;
        private static bool Connected = false;
        public static string conectionString { private get { return ConectionString; } set { ConectionString = value; }}
        public static void SetConnectParam()
        {
            //"server=localhost;user id=root; password=root; database=corporativesystem"
            ConectionString = $"server={Settings1.Default.Server};user id={Settings1.Default.UserID}; password={Settings1.Default.Password}; database={Settings1.Default.Database}";
        }
        public static void Connect()
        {
            try {

                if (Connected == false)
                {
                    _con = new MySqlConnection(ConectionString);
                    _con.Open();
                    Connected = true;
                }
                else
                {
                    
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Connect(string ConectionString)
        {
            try
            {
                if (Connected == false)
                {
                    _con = new MySqlConnection(ConectionString);
                    _con.Open();
                    Connected = true;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Close()
        {
            _con.Close();
        }
        /// <summary>
        /// Функция для взаимодествия с БД с помощью текстовых команд 
        /// </summary>
        /// <param name="Command">Текст команды</param>
        /// <returns></returns>
        public static DataTable LoadData(string Command)
        {
            try
            {
                MySqlCommand _Command = _con.CreateCommand();
                _Command.CommandType = CommandType.Text;
                _Command.CommandText = Command;
                _Command.ExecuteNonQuery();
                DataTable data = new DataTable();
                if (Command.Contains("select"))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(_Command);
                    adapter.Fill(data);
                }
                return data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataTable data = new DataTable();
                return data;
            }
        }

    }
}
