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
    public partial class change_in_clients : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = storedb.accdb";
        private OleDbConnection dbConnection;
        public string id = "";

        public change_in_clients()
        {
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            InitializeComponent();
        }

        private void change_clients_face_cb_TextChanged(object sender, EventArgs e)
        {
            if (change_clients_face_cb.Text == "Физическое")
            {
                change_clients_inn_label.Enabled = false;
                change_clients_inn_tb.Enabled = false;
                change_clients_inn_tb.Mask = String.Empty;
            }
            else
            {
                change_clients_inn_label.Enabled = true;
                change_clients_inn_tb.Enabled = true;
                change_clients_inn_tb.Mask = "0000000000";
            }
        }

        private void change_clients_phoneormail_cb_TextChanged(object sender, EventArgs e)
        {
            if (change_clients_phoneormail_cb.Text == "Телефон")
            {
                change_clients_contact_tb.ReadOnly = false;
                change_clients_contact_tb.Mask = "+7 (000) 000-00-00";
            }
            else
            {
                change_clients_contact_tb.ReadOnly = false;
                change_clients_contact_tb.Mask = String.Empty;
            }
        }

        private void change_clients_button_Click(object sender, EventArgs e)
        {
            string face = change_clients_face_cb.Text;
            string name = change_clients_name_tb.Text;
            string contact = change_clients_contact_tb.Text;
            string inn = change_clients_inn_tb.Text;
            if (face == String.Empty)
            {
                MessageBox.Show("Заполните пустые поля");
                return;
            }
            if (face == "Физическое")
            {
                if (name == String.Empty || contact == String.Empty)
                {
                    MessageBox.Show("Заполните пустые поля");
                    return;
                }
                else if (change_clients_phoneormail_cb.Text == "Телефон" && contact.Length != 18)
                {
                    MessageBox.Show("Телефонный номер введен не до конца");
                    return;
                }
                else
                {
                    string query = "UPDATE Клиенты SET Лицо = '" + face + "', [ФИО или название фирмы] = '" + name + "', [Контактный номер или почта] = '" + contact + "', ИНН = '-' WHERE Код = " + id;
                    OleDbCommand command = new OleDbCommand(query, dbConnection);
                    command.ExecuteNonQuery();
                    this.Close();
                }
            }
            else
            {
                if (name == String.Empty || contact == String.Empty || inn == String.Empty)
                {
                    MessageBox.Show("Заполните пустые поля");
                    return;
                }
                else if (change_clients_phoneormail_cb.Text == "Телефон" && contact.Length != 18)
                {
                    MessageBox.Show("Телефонный номер введен не до конца");
                    return;
                }
                else if (inn.Length != 10)
                {
                    MessageBox.Show("Номер ИНН введен не до конца");
                    return;
                }
                else
                {
                    string query = "UPDATE Клиенты SET Лицо = '" + face + "', [ФИО или название фирмы] = '" + name + "', [Контактный номер или почта] = '" + contact + "', ИНН = '" + inn + "' WHERE Код = " + id;
                    OleDbCommand command = new OleDbCommand(query, dbConnection);
                    command.ExecuteNonQuery();
                    this.Close();
                }
            }
        }

        private void change_clients_name_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }

        private void change_clients_contact_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }
    }
}