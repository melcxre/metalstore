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

namespace kursovaya
{
    public partial class change_in_catalog : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = storedb.accdb";
        private OleDbConnection dbConnection;
        public string id = "";

        public change_in_catalog()
        {
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            InitializeComponent();
        }

        private void change_catalog_button_Click(object sender, EventArgs e)
        {
            string name = change_catalog_name_tb.Text;
            string category = change_catalog_category_cb.Text;
            string manufacturer = change_catalog_manufacturer_tb.Text;
            string country = change_catalog_country_cb.Text;
            string year = change_catalog_year_tb.Text;
            string description = change_catalog_description_tb.Text;
            string availability = change_catalog_availability_cb.Text;
            string price = change_catalog_price_tb.Text;
            string quantity = change_catalog_quantity_tb.Text;

            if (name == String.Empty || category == String.Empty || manufacturer == String.Empty || country == String.Empty || year == String.Empty || description == String.Empty || availability == String.Empty || price == String.Empty || quantity == String.Empty)
            {
                MessageBox.Show("Заполните пустые поля");
                return;
            }
            else
            {
                string query = "UPDATE Каталог SET Название = '" + name + "', Категория = '" + category + "', Производитель = '" + manufacturer + "', Страна = '" + country + "', Год = " + year + ", Описание = '" + description + "', Наличие = '" + availability + "', Стоимость = " + price + ", Количество = " + quantity + " WHERE Код = " + id;
                OleDbCommand command = new OleDbCommand(query, dbConnection);
                command.ExecuteNonQuery();
                this.Close();
            }
        }

        private void change_catalog_name_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }

        private void change_catalog_manufacturer_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }

        private void change_catalog_year_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsSymbol(e.KeyChar)) || (Char.IsSeparator(e.KeyChar)) || (Char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void change_catalog_description_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }

        private void change_catalog_price_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsSymbol(e.KeyChar)) || (Char.IsSeparator(e.KeyChar)) || (Char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void change_catalog_quantity_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsSymbol(e.KeyChar)) || (Char.IsSeparator(e.KeyChar)) || (Char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}