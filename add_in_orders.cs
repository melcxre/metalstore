using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kursovaya
{
    public partial class add_in_orders : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = storedb.accdb";
        private OleDbConnection dbConnection;
        public List<decimal> prices_list = new List<decimal>();
        decimal summa = 0;

        public add_in_orders()
        {
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            InitializeComponent();
        }

        private void add_orders_button_Click(object sender, EventArgs e)
        {
            string client = add_orders_client_cb.Text;
            string inst = String.Empty;
            foreach (object selecteditem in add_orders_inst_clb.CheckedItems)
            {
                string item = selecteditem.ToString();
                inst += item + "\n";
            }
            foreach (int index in add_orders_inst_clb.CheckedIndices)
            {
                summa += prices_list[index];
            }
            inst = inst.TrimEnd('\n');
            string date = add_orders_date_dtp.Value.Date.ToString();
            string adress = add_orders_adress_tb.Text;
            string status = add_orders_status_cb.Text;
            string sum = summa.ToString();
            if (client == String.Empty || inst == String.Empty || date == String.Empty || adress == String.Empty || status == String.Empty)
            {
                MessageBox.Show("Заполните пустые поля");
                return;
            }
            else
            {
                string query = "INSERT INTO Заказы(Клиент, [Инструменты в заказе], [Дата оформления заказа], [Адрес доставки], [Статус заказа], [Общая сумма заказа]) VALUES ('" + client + "', '" + inst + "', '" + date + "', '" + adress + "', '" + status + "', " + sum + ")";
                OleDbCommand command = new OleDbCommand(query, dbConnection);
                command.ExecuteNonQuery();
                this.Close();
            }
        }

        private void add_orders_adress_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }
    }
}