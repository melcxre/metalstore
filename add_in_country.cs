using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;

namespace kursovaya
{
    public partial class add_in_country : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = storedb.accdb";
        private OleDbConnection dbConnection;

        public add_in_country()
        {
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            InitializeComponent();
        }

        private void add_country_button_Click(object sender, EventArgs e)
        {
            string value = add_country_tb.Text;

            if (value == String.Empty)
            {
                MessageBox.Show("Заполните пустые поля");
                return;
            }
            else
            {
                string query = "INSERT INTO Страна VALUES ('" + value + "')";
                OleDbCommand command = new OleDbCommand(query, dbConnection);
                command.ExecuteNonQuery();
                this.Close();
            }
        }

        private void add_country_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }
    }
}
