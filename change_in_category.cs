using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class change_in_category : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = storedb.accdb";
        private OleDbConnection dbConnection;

        public change_in_category()
        {
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            InitializeComponent();
        }

        private void change_category_button_Click(object sender, EventArgs e)
        {
            string value = change_category_tb.Text;
            string id = change_category_tb.Name;
            if (value == String.Empty)
            {
                MessageBox.Show("Заполните пустые поля");
                return;
            }
            else
            {
                string query = "UPDATE Категория SET Категория = '" + value + "' WHERE Категория = '" + id + "'";
                Console.WriteLine(query);
                OleDbCommand command = new OleDbCommand(query, dbConnection);
                command.ExecuteNonQuery();
                this.Close();
            }
        }

        private void change_category_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }
    }
}
