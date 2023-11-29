using kursovaya.storedbDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursovaya
{
    public partial class Main : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = storedb.accdb";
        private OleDbConnection dbConnection;

        public Main()
        {
            dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.заказыTableAdapter.Fill(this.storedbDataSet.Заказы);
            dataGridViewOrders.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.клиентыTableAdapter.Fill(this.storedbDataSet.Клиенты);
            this.странаTableAdapter.Fill(this.storedbDataSet.Страна);
            this.наличиеTableAdapter.Fill(this.storedbDataSet.Наличие);
            this.категорияTableAdapter.Fill(this.storedbDataSet.Категория);
            this.каталогTableAdapter.Fill(this.storedbDataSet.Каталог);
            dataGridViewCatalog.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void add_button_catalog_Click(object sender, EventArgs e)
        {
            add_in_catalog addDialog = new add_in_catalog();
            foreach (DataGridViewRow row in dataGridViewCategory.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    addDialog.add_catalog_category_cb.Items.Add(cell.Value.ToString());
                }
            }
            foreach (DataGridViewRow row in dataGridViewAvailability.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    addDialog.add_catalog_availability_cb.Items.Add(cell.Value.ToString());
                }
            }
            foreach (DataGridViewRow row in dataGridViewCountry.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    addDialog.add_catalog_country_cb.Items.Add(cell.Value.ToString());
                }
            }
            addDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.каталогTableAdapter.Fill(this.storedbDataSet.Каталог);
        }

        private void delete_button_catalog_Click(object sender, EventArgs e)
        {
            if (dataGridViewCatalog.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберете строки для удаления");
                return;
            }
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            if (MessageBox.Show("Вы точно хотите удалить?", "Удалить", msb) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewCatalog.SelectedRows)
                {
                    int index = row.Index;
                    string id = dataGridViewCatalog.Rows[index].Cells[0].Value.ToString();
                    string query = "DELETE FROM Каталог WHERE Код = " + id;
                    OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                    dbCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Удалено");
                this.каталогTableAdapter.Fill(this.storedbDataSet.Каталог);
            }
            else { return; }
        }

        private void change_button_catalog_Click(object sender, EventArgs e)
        {
            if (dataGridViewCatalog.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберете строку для изменения");
                return;
            }
            int index = dataGridViewCatalog.SelectedRows[0].Index;
            change_in_catalog changeDialog = new change_in_catalog();
            foreach (DataGridViewRow row in dataGridViewCategory.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    changeDialog.change_catalog_category_cb.Items.Add(cell.Value.ToString());
                }
            }
            foreach (DataGridViewRow row in dataGridViewAvailability.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    changeDialog.change_catalog_availability_cb.Items.Add(cell.Value.ToString());
                }
            }
            foreach (DataGridViewRow row in dataGridViewCountry.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    changeDialog.change_catalog_country_cb.Items.Add(cell.Value.ToString());
                }
            }
            changeDialog.id = dataGridViewCatalog.Rows[index].Cells[0].Value.ToString();
            changeDialog.change_catalog_name_tb.Text = dataGridViewCatalog.Rows[index].Cells[1].Value.ToString();
            changeDialog.change_catalog_category_cb.Text = dataGridViewCatalog.Rows[index].Cells[2].Value.ToString();
            changeDialog.change_catalog_manufacturer_tb.Text = dataGridViewCatalog.Rows[index].Cells[3].Value.ToString();
            changeDialog.change_catalog_country_cb.Text = dataGridViewCatalog.Rows[index].Cells[4].Value.ToString();
            changeDialog.change_catalog_year_tb.Text = dataGridViewCatalog.Rows[index].Cells[5].Value.ToString();
            changeDialog.change_catalog_description_tb.Text = dataGridViewCatalog.Rows[index].Cells[6].Value.ToString();
            changeDialog.change_catalog_availability_cb.Text = dataGridViewCatalog.Rows[index].Cells[7].Value.ToString();
            changeDialog.change_catalog_price_tb.Text = dataGridViewCatalog.Rows[index].Cells[8].Value.ToString();
            changeDialog.change_catalog_quantity_tb.Text = dataGridViewCatalog.Rows[index].Cells[9].Value.ToString();
            changeDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.каталогTableAdapter.Fill(this.storedbDataSet.Каталог);
        }

        private void catalog_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
            if (String.IsNullOrEmpty(catalog_search.Text))
                каталогBindingSource.Filter = String.Empty;
            else
            {
                if (e.KeyChar == (char)13)
                    каталогBindingSource.Filter = String.Format("CONVERT(Код, 'System.String') LIKE '{0}%' OR Название LIKE '%{0}%' OR Категория LIKE '%{0}%' OR Производитель LIKE '%{0}%' OR Страна LIKE '%{0}%' OR CONVERT(Год, 'System.String') LIKE '{0}%' OR Описание LIKE '%{0}%' OR Наличие LIKE '%{0}%' OR CONVERT(Стоимость, 'System.String') LIKE '{0}%'", catalog_search.Text);
            }
        }

        private void add_button_category_Click(object sender, EventArgs e)
        {
            add_in_category addDialog = new add_in_category();
            addDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.категорияTableAdapter.Fill(this.storedbDataSet.Категория);
        }

        private void delete_button_category_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategory.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберете строки для удаления");
                return;
            }
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            if (MessageBox.Show("Вы точно хотите удалить?", "Удалить", msb) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewCategory.SelectedRows)
                {
                    int index = row.Index;
                    string id = dataGridViewCategory.Rows[index].Cells[0].Value.ToString();
                    string query = "DELETE FROM Категория WHERE Категория = '" + id + "'";
                    OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                    dbCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Удалено");
                this.категорияTableAdapter.Fill(this.storedbDataSet.Категория);
            }
            else { return; }
        }

        private void change_button_category_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategory.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберете строку для изменения");
                return;
            }
            int index = dataGridViewCategory.SelectedRows[0].Index;
            change_in_category changeDialog = new change_in_category();
            changeDialog.change_category_tb.Name = dataGridViewCategory.Rows[index].Cells[0].Value.ToString();
            changeDialog.change_category_tb.Text = dataGridViewCategory.Rows[index].Cells[0].Value.ToString();
            changeDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.категорияTableAdapter.Fill(this.storedbDataSet.Категория);
        }

        private void category_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
            if (String.IsNullOrEmpty(category_search.Text))
                категорияBindingSource.Filter = String.Empty;
            else
                if (e.KeyChar == (char)13)
                категорияBindingSource.Filter = String.Format("Категория LIKE '%{0}%'", category_search.Text);
        }

        private void add_button_availability_Click(object sender, EventArgs e)
        {
            add_in_availability addDialog = new add_in_availability();
            addDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.наличиеTableAdapter.Fill(this.storedbDataSet.Наличие);
        }

        private void delete_button_availability_Click(object sender, EventArgs e)
        {
            if (dataGridViewAvailability.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберете строки для удаления");
                return;
            }
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            if (MessageBox.Show("Вы точно хотите удалить?", "Удалить", msb) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewAvailability.SelectedRows)
                {
                    int index = row.Index;
                    string id = dataGridViewAvailability.Rows[index].Cells[0].Value.ToString();
                    string query = "DELETE FROM Наличие WHERE Наличие = '" + id + "'";
                    OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                    dbCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Удалено");
                this.наличиеTableAdapter.Fill(this.storedbDataSet.Наличие);
            }
            else { return; }
        }

        private void change_button_availability_Click(object sender, EventArgs e)
        {
            if (dataGridViewAvailability.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберете строку для изменения");
                return;
            }
            int index = dataGridViewAvailability.SelectedRows[0].Index;
            change_in_availability changeDialog = new change_in_availability();
            changeDialog.change_availability_tb.Name = dataGridViewAvailability.Rows[index].Cells[0].Value.ToString();
            changeDialog.change_availability_tb.Text = dataGridViewAvailability.Rows[index].Cells[0].Value.ToString();
            changeDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.наличиеTableAdapter.Fill(this.storedbDataSet.Наличие);
        }

        private void availability_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
            if (String.IsNullOrEmpty(availability_search.Text))
                наличиеBindingSource.Filter = String.Empty;
            else
                if (e.KeyChar == (char)13)
                наличиеBindingSource.Filter = String.Format("Наличие LIKE '%{0}%'", availability_search.Text);
        }

        private void add_button_country_Click(object sender, EventArgs e)
        {
            add_in_country addDialog = new add_in_country();
            addDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.странаTableAdapter.Fill(this.storedbDataSet.Страна);
        }

        private void delete_button_country_Click(object sender, EventArgs e)
        {
            if (dataGridViewCountry.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберете строки для удаления");
                return;
            }
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            if (MessageBox.Show("Вы точно хотите удалить?", "Удалить", msb) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewCountry.SelectedRows)
                {
                    int index = row.Index;
                    string id = dataGridViewCountry.Rows[index].Cells[0].Value.ToString();
                    string query = "DELETE FROM Страна WHERE Страна = '" + id + "'";
                    OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                    dbCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Удалено");
                this.странаTableAdapter.Fill(this.storedbDataSet.Страна);
            }
            else { return; }
        }

        private void change_button_country_Click(object sender, EventArgs e)
        {
            if (dataGridViewCountry.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберете строку для изменения");
                return;
            }
            int index = dataGridViewCountry.SelectedRows[0].Index;
            change_in_country changeDialog = new change_in_country();
            changeDialog.change_country_tb.Name = dataGridViewCountry.Rows[index].Cells[0].Value.ToString();
            changeDialog.change_country_tb.Text = dataGridViewCountry.Rows[index].Cells[0].Value.ToString();
            changeDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.странаTableAdapter.Fill(this.storedbDataSet.Страна);
        }

        private void country_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
            if (String.IsNullOrEmpty(country_search.Text))
                странаBindingSource.Filter = String.Empty;
            else
                if (e.KeyChar == (char)13)
                    странаBindingSource.Filter = String.Format("Страна LIKE '%{0}%'", country_search.Text);
        }

        private void add_button_clients_Click(object sender, EventArgs e)
        {
            add_in_clients addDialog = new add_in_clients();
            addDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.клиентыTableAdapter.Fill(this.storedbDataSet.Клиенты);
        }

        private void delete_button_clients_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберете строки для удаления");
                return;
            }
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            if (MessageBox.Show("Вы точно хотите удалить?", "Удалить", msb) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewClients.SelectedRows)
                {
                    int index = row.Index;
                    string id = dataGridViewClients.Rows[index].Cells[0].Value.ToString();
                    string query = "DELETE FROM Клиенты WHERE Код = " + id;
                    OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                    dbCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Удалено");
                this.клиентыTableAdapter.Fill(this.storedbDataSet.Клиенты);
            }
            else { return; }
        }

        private void change_button_clients_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберете строку для изменения");
                return;
            }
            int index = dataGridViewClients.SelectedRows[0].Index;
            change_in_clients changeDialog = new change_in_clients();
            changeDialog.id = dataGridViewClients.Rows[index].Cells[0].Value.ToString();
            changeDialog.change_clients_face_cb.Text = dataGridViewClients.Rows[index].Cells[1].Value.ToString();
            changeDialog.change_clients_name_tb.Text = dataGridViewClients.Rows[index].Cells[2].Value.ToString();
            changeDialog.change_clients_contact_tb.Text = dataGridViewClients.Rows[index].Cells[3].Value.ToString();
            changeDialog.change_clients_inn_tb.Text = dataGridViewClients.Rows[index].Cells[4].Value.ToString();
            changeDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.клиентыTableAdapter.Fill(this.storedbDataSet.Клиенты);
        }

        private void clients_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
            if (String.IsNullOrEmpty(clients_search.Text))
                клиентыBindingSource.Filter = String.Empty;
            else
            {
                if (e.KeyChar == (char)13)
                    клиентыBindingSource.Filter = String.Format("CONVERT(Код, 'System.String') LIKE '{0}%' OR Лицо LIKE '%{0}%' OR [ФИО или название фирмы] LIKE '%{0}%' OR [Контактный номер или почта] LIKE '%{0}%' OR ИНН LIKE '%{0}%'", clients_search.Text);
            }
        }

        private void add_button_orders_Click(object sender, EventArgs e)
        {
            add_in_orders addDialog = new add_in_orders();
            foreach (DataGridViewRow row in dataGridViewClients.Rows)
            {
                string client = String.Empty;
                client += row.Cells[0].Value.ToString() + " - ";
                client += row.Cells[2].Value.ToString() + " ";
                client += row.Cells[3].Value.ToString() + " ";
                if (row.Cells[1].Value.ToString() == "Юридическое")
                {
                    client += "ИНН " + row.Cells[4].Value.ToString();
                }
                addDialog.add_orders_client_cb.Items.Add(client);
            }
            foreach (DataGridViewRow row in dataGridViewCatalog.Rows)
            {
                string instrument = String.Empty;
                instrument += row.Cells[0].Value.ToString() + " - ";
                instrument += row.Cells[3].Value.ToString() + " ";
                instrument += row.Cells[1].Value.ToString() + " ";
                instrument += row.Cells[4].Value.ToString() + " ";
                instrument += row.Cells[5].Value.ToString() + " | ";
                instrument += row.Cells[2].Value.ToString() + " | ";
                if (row.Cells[7].Value.ToString() == "Нет в наличии") { continue; }
                else { instrument += row.Cells[7].Value.ToString() + " | "; }
                if (row.Cells[9].Value.ToString() == "0") { continue; }
                instrument += "Цена - " + row.Cells[8].Value.ToString();
                decimal price = (decimal)row.Cells[8].Value;
                addDialog.prices_list.Add(price);
                addDialog.add_orders_inst_clb.Items.Add(instrument);
            }
            addDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.заказыTableAdapter.Fill(this.storedbDataSet.Заказы);
        }

        private void delete_button_orders_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберете строки для удаления");
                return;
            }
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            if (MessageBox.Show("Вы точно хотите удалить?", "Удалить", msb) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewOrders.SelectedRows)
                {
                    int index = row.Index;
                    string id = dataGridViewOrders.Rows[index].Cells[0].Value.ToString();
                    string query = "DELETE FROM Заказы WHERE Код = " + id;
                    OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
                    dbCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Удалено");
                this.заказыTableAdapter.Fill(this.storedbDataSet.Заказы);
            }
            else { return; }
        }

        private void change_button_orders_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберете строку для изменения");
                return;
            }
            int index = dataGridViewOrders.SelectedRows[0].Index;
            change_in_orders changeDialog = new change_in_orders();
            foreach (DataGridViewRow row in dataGridViewClients.Rows)
            {
                string client = String.Empty;
                client += row.Cells[0].Value.ToString() + " - ";
                client += row.Cells[2].Value.ToString() + " ";
                client += row.Cells[3].Value.ToString() + " ";
                if (row.Cells[1].Value.ToString() == "Юридическое")
                {
                    client += "ИНН " + row.Cells[4].Value.ToString();
                }
                changeDialog.change_orders_client_cb.Items.Add(client);
            }
            string insts = dataGridViewOrders.Rows[index].Cells[2].Value.ToString();
            char newline = '\n';
            List<string> instruments = insts.Split(newline).ToList();
            foreach (DataGridViewRow row in dataGridViewCatalog.Rows)
            {
                string instrument = String.Empty;
                instrument += row.Cells[0].Value.ToString() + " - ";
                instrument += row.Cells[3].Value.ToString() + " ";
                instrument += row.Cells[1].Value.ToString() + " ";
                instrument += row.Cells[4].Value.ToString() + " ";
                instrument += row.Cells[5].Value.ToString() + " | ";
                instrument += row.Cells[2].Value.ToString() + " | ";
                if (row.Cells[7].Value.ToString() == "Нет в наличии") { continue; }
                else { instrument += row.Cells[7].Value.ToString() + " | "; }
                if (row.Cells[9].Value.ToString() == "0") { continue; }
                instrument += "Цена - " + row.Cells[8].Value.ToString();
                decimal price = (decimal)row.Cells[8].Value;
                changeDialog.prices_list.Add(price);
                changeDialog.change_orders_inst_clb.Items.Add(instrument);
                if (instruments.Contains(instrument))
                {
                    changeDialog.change_orders_inst_clb.SetItemChecked(changeDialog.change_orders_inst_clb.Items.IndexOf(instrument), true);
                }
            }
            changeDialog.id = dataGridViewOrders.Rows[index].Cells[0].Value.ToString();
            changeDialog.change_orders_client_cb.Text = dataGridViewOrders.Rows[index].Cells[1].Value.ToString();
            DateTime date = (DateTime)dataGridViewOrders.Rows[index].Cells[3].Value;
            changeDialog.change_orders_date_dtp.Value = date;
            changeDialog.change_orders_adress_tb.Text = dataGridViewOrders.Rows[index].Cells[4].Value.ToString();
            changeDialog.change_orders_status_cb.Text = dataGridViewOrders.Rows[index].Cells[5].Value.ToString();
            changeDialog.ShowDialog();
            MessageBox.Show("Обновлено");
            this.заказыTableAdapter.Fill(this.storedbDataSet.Заказы);
        }

        private void orders_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
            if (String.IsNullOrEmpty(orders_search.Text))
                заказыBindingSource.Filter = String.Empty;
            else
            {
                if (e.KeyChar == (char)13)
                    заказыBindingSource.Filter = String.Format("CONVERT(Код, 'System.String') LIKE '{0}%' OR Клиент LIKE '%{0}%' OR [Инструменты в заказе] LIKE '%{0}%' OR CONVERT([Дата оформления заказа], 'System.String') LIKE '%{0}%' OR [Адрес доставки] LIKE '%{0}%' OR [Статус заказа] LIKE '%{0}%' OR CONVERT([Общая сумма заказа], 'System.String') LIKE '{0}%'", orders_search.Text);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа Metal Store \nРазработал студент группы 20-13 \nМакаров Андрей", "О программе");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            string message = "Вы точно хотите выйти?";
            string caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}