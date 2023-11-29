using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kursovaya
{
    public partial class change_in_orders : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = storedb.accdb";
        private OleDbConnection dbConnection;
        public string id = "";
        public List<decimal> prices_list = new List<decimal>();
        decimal summa = 0;

        public change_in_orders()
        {
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            InitializeComponent();
        }

        private void change_orders_button_Click(object sender, EventArgs e)
        {
            string client = change_orders_client_cb.Text;
            string inst = String.Empty;
            foreach (object selecteditem in change_orders_inst_clb.CheckedItems)
            {
                string item = selecteditem.ToString();
                inst += item + "\n";
            }
            foreach (int index in change_orders_inst_clb.CheckedIndices)
            {
                summa += prices_list[index];
            }
            inst = inst.TrimEnd('\n');
            string date = change_orders_date_dtp.Value.Date.ToString();
            string adress = change_orders_adress_tb.Text;
            string status = change_orders_status_cb.Text;
            string sum = summa.ToString();
            if (client == String.Empty || inst == String.Empty || date == String.Empty || adress == String.Empty || status == String.Empty)
            {
                MessageBox.Show("Заполните пустые поля");
                return;
            }
            else
            {
                string query = "UPDATE Заказы SET Клиент = '" + client + "', [Инструменты в заказе] = '" + inst + "', [Дата оформления заказа] = '" + date + "', [Адрес доставки] = '" + adress + "', [Статус заказа] = '" + status + "', [Общая сумма заказа] = " + sum + " WHERE Код = " + id;
                OleDbCommand command = new OleDbCommand(query, dbConnection);
                command.ExecuteNonQuery();
                this.Close();
            }
        }

        private void change_orders_adress_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }
    }
}
