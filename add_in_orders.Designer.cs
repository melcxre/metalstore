namespace kursovaya
{
    partial class add_in_orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_in_orders));
            this.add_orders_button = new System.Windows.Forms.Button();
            this.add_orders_client_cb = new System.Windows.Forms.ComboBox();
            this.add_orders_client_label = new System.Windows.Forms.Label();
            this.add_orders_inst_label = new System.Windows.Forms.Label();
            this.storedbDataSet = new kursovaya.storedbDataSet();
            this.каталогBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталогTableAdapter = new kursovaya.storedbDataSetTableAdapters.КаталогTableAdapter();
            this.add_orders_inst_clb = new System.Windows.Forms.CheckedListBox();
            this.add_orders_date_label = new System.Windows.Forms.Label();
            this.add_orders_date_dtp = new System.Windows.Forms.DateTimePicker();
            this.add_orders_adress_label = new System.Windows.Forms.Label();
            this.add_orders_adress_tb = new System.Windows.Forms.TextBox();
            this.add_orders_status_label = new System.Windows.Forms.Label();
            this.add_orders_status_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.storedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // add_orders_button
            // 
            this.add_orders_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_orders_button.Location = new System.Drawing.Point(241, 410);
            this.add_orders_button.Name = "add_orders_button";
            this.add_orders_button.Size = new System.Drawing.Size(105, 23);
            this.add_orders_button.TabIndex = 22;
            this.add_orders_button.Text = "Добавить";
            this.add_orders_button.UseVisualStyleBackColor = true;
            this.add_orders_button.Click += new System.EventHandler(this.add_orders_button_Click);
            // 
            // add_orders_client_cb
            // 
            this.add_orders_client_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_orders_client_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_orders_client_cb.FormattingEnabled = true;
            this.add_orders_client_cb.Location = new System.Drawing.Point(12, 32);
            this.add_orders_client_cb.Name = "add_orders_client_cb";
            this.add_orders_client_cb.Size = new System.Drawing.Size(560, 21);
            this.add_orders_client_cb.TabIndex = 23;
            // 
            // add_orders_client_label
            // 
            this.add_orders_client_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_orders_client_label.Location = new System.Drawing.Point(12, 9);
            this.add_orders_client_label.Name = "add_orders_client_label";
            this.add_orders_client_label.Size = new System.Drawing.Size(560, 20);
            this.add_orders_client_label.TabIndex = 24;
            this.add_orders_client_label.Text = "Клиент";
            this.add_orders_client_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_orders_inst_label
            // 
            this.add_orders_inst_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_orders_inst_label.Location = new System.Drawing.Point(12, 56);
            this.add_orders_inst_label.Name = "add_orders_inst_label";
            this.add_orders_inst_label.Size = new System.Drawing.Size(560, 20);
            this.add_orders_inst_label.TabIndex = 24;
            this.add_orders_inst_label.Text = "Инструменты в заказе";
            this.add_orders_inst_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storedbDataSet
            // 
            this.storedbDataSet.DataSetName = "storedbDataSet";
            this.storedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каталогBindingSource
            // 
            this.каталогBindingSource.DataMember = "Каталог";
            this.каталогBindingSource.DataSource = this.storedbDataSet;
            // 
            // каталогTableAdapter
            // 
            this.каталогTableAdapter.ClearBeforeFill = true;
            // 
            // add_orders_inst_clb
            // 
            this.add_orders_inst_clb.FormattingEnabled = true;
            this.add_orders_inst_clb.HorizontalScrollbar = true;
            this.add_orders_inst_clb.Location = new System.Drawing.Point(12, 79);
            this.add_orders_inst_clb.Name = "add_orders_inst_clb";
            this.add_orders_inst_clb.Size = new System.Drawing.Size(560, 154);
            this.add_orders_inst_clb.TabIndex = 25;
            // 
            // add_orders_date_label
            // 
            this.add_orders_date_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_orders_date_label.Location = new System.Drawing.Point(12, 236);
            this.add_orders_date_label.Name = "add_orders_date_label";
            this.add_orders_date_label.Size = new System.Drawing.Size(560, 20);
            this.add_orders_date_label.TabIndex = 24;
            this.add_orders_date_label.Text = "Дата оформления заказа";
            this.add_orders_date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_orders_date_dtp
            // 
            this.add_orders_date_dtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_orders_date_dtp.Location = new System.Drawing.Point(12, 259);
            this.add_orders_date_dtp.Name = "add_orders_date_dtp";
            this.add_orders_date_dtp.Size = new System.Drawing.Size(560, 20);
            this.add_orders_date_dtp.TabIndex = 27;
            this.add_orders_date_dtp.Value = new System.DateTime(2023, 11, 26, 23, 21, 19, 0);
            // 
            // add_orders_adress_label
            // 
            this.add_orders_adress_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_orders_adress_label.Location = new System.Drawing.Point(12, 282);
            this.add_orders_adress_label.Name = "add_orders_adress_label";
            this.add_orders_adress_label.Size = new System.Drawing.Size(560, 20);
            this.add_orders_adress_label.TabIndex = 24;
            this.add_orders_adress_label.Text = "Адрес доставки";
            this.add_orders_adress_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_orders_adress_tb
            // 
            this.add_orders_adress_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_orders_adress_tb.Location = new System.Drawing.Point(12, 305);
            this.add_orders_adress_tb.Name = "add_orders_adress_tb";
            this.add_orders_adress_tb.Size = new System.Drawing.Size(560, 20);
            this.add_orders_adress_tb.TabIndex = 28;
            this.add_orders_adress_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_orders_adress_tb_KeyPress);
            // 
            // add_orders_status_label
            // 
            this.add_orders_status_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_orders_status_label.Location = new System.Drawing.Point(12, 328);
            this.add_orders_status_label.Name = "add_orders_status_label";
            this.add_orders_status_label.Size = new System.Drawing.Size(560, 20);
            this.add_orders_status_label.TabIndex = 24;
            this.add_orders_status_label.Text = "Статус заказа";
            this.add_orders_status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_orders_status_cb
            // 
            this.add_orders_status_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_orders_status_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_orders_status_cb.FormattingEnabled = true;
            this.add_orders_status_cb.Items.AddRange(new object[] {
            "Создан",
            "Обрабатывается",
            "Передан в доставку",
            "В пути",
            "Доставлен"});
            this.add_orders_status_cb.Location = new System.Drawing.Point(12, 351);
            this.add_orders_status_cb.Name = "add_orders_status_cb";
            this.add_orders_status_cb.Size = new System.Drawing.Size(560, 21);
            this.add_orders_status_cb.TabIndex = 23;
            // 
            // add_in_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.add_orders_adress_tb);
            this.Controls.Add(this.add_orders_date_dtp);
            this.Controls.Add(this.add_orders_inst_clb);
            this.Controls.Add(this.add_orders_status_label);
            this.Controls.Add(this.add_orders_adress_label);
            this.Controls.Add(this.add_orders_date_label);
            this.Controls.Add(this.add_orders_inst_label);
            this.Controls.Add(this.add_orders_client_label);
            this.Controls.Add(this.add_orders_status_cb);
            this.Controls.Add(this.add_orders_client_cb);
            this.Controls.Add(this.add_orders_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_in_orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            ((System.ComponentModel.ISupportInitialize)(this.storedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_orders_button;
        public System.Windows.Forms.ComboBox add_orders_client_cb;
        private System.Windows.Forms.Label add_orders_client_label;
        private System.Windows.Forms.Label add_orders_inst_label;
        private storedbDataSet storedbDataSet;
        private System.Windows.Forms.BindingSource каталогBindingSource;
        private storedbDataSetTableAdapters.КаталогTableAdapter каталогTableAdapter;
        public System.Windows.Forms.CheckedListBox add_orders_inst_clb;
        private System.Windows.Forms.Label add_orders_date_label;
        public System.Windows.Forms.DateTimePicker add_orders_date_dtp;
        private System.Windows.Forms.Label add_orders_adress_label;
        public System.Windows.Forms.TextBox add_orders_adress_tb;
        private System.Windows.Forms.Label add_orders_status_label;
        public System.Windows.Forms.ComboBox add_orders_status_cb;
    }
}