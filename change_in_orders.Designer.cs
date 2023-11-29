namespace kursovaya
{
    partial class change_in_orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_in_orders));
            this.change_orders_adress_tb = new System.Windows.Forms.TextBox();
            this.change_orders_date_dtp = new System.Windows.Forms.DateTimePicker();
            this.change_orders_inst_clb = new System.Windows.Forms.CheckedListBox();
            this.change_orders_status_label = new System.Windows.Forms.Label();
            this.change_orders_adress_label = new System.Windows.Forms.Label();
            this.change_orders_date_label = new System.Windows.Forms.Label();
            this.change_orders_inst_label = new System.Windows.Forms.Label();
            this.change_orders_client_label = new System.Windows.Forms.Label();
            this.change_orders_status_cb = new System.Windows.Forms.ComboBox();
            this.change_orders_client_cb = new System.Windows.Forms.ComboBox();
            this.change_orders_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // change_orders_adress_tb
            // 
            this.change_orders_adress_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_orders_adress_tb.Location = new System.Drawing.Point(12, 305);
            this.change_orders_adress_tb.Name = "change_orders_adress_tb";
            this.change_orders_adress_tb.Size = new System.Drawing.Size(560, 20);
            this.change_orders_adress_tb.TabIndex = 38;
            this.change_orders_adress_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.change_orders_adress_tb_KeyPress);
            // 
            // change_orders_date_dtp
            // 
            this.change_orders_date_dtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_orders_date_dtp.Location = new System.Drawing.Point(12, 259);
            this.change_orders_date_dtp.Name = "change_orders_date_dtp";
            this.change_orders_date_dtp.Size = new System.Drawing.Size(560, 20);
            this.change_orders_date_dtp.TabIndex = 37;
            this.change_orders_date_dtp.Value = new System.DateTime(2023, 11, 26, 23, 21, 19, 0);
            // 
            // change_orders_inst_clb
            // 
            this.change_orders_inst_clb.FormattingEnabled = true;
            this.change_orders_inst_clb.HorizontalScrollbar = true;
            this.change_orders_inst_clb.Location = new System.Drawing.Point(12, 79);
            this.change_orders_inst_clb.Name = "change_orders_inst_clb";
            this.change_orders_inst_clb.Size = new System.Drawing.Size(560, 154);
            this.change_orders_inst_clb.TabIndex = 36;
            // 
            // change_orders_status_label
            // 
            this.change_orders_status_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_orders_status_label.Location = new System.Drawing.Point(12, 328);
            this.change_orders_status_label.Name = "change_orders_status_label";
            this.change_orders_status_label.Size = new System.Drawing.Size(560, 20);
            this.change_orders_status_label.TabIndex = 31;
            this.change_orders_status_label.Text = "Статус заказа";
            this.change_orders_status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_orders_adress_label
            // 
            this.change_orders_adress_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_orders_adress_label.Location = new System.Drawing.Point(12, 282);
            this.change_orders_adress_label.Name = "change_orders_adress_label";
            this.change_orders_adress_label.Size = new System.Drawing.Size(560, 20);
            this.change_orders_adress_label.TabIndex = 32;
            this.change_orders_adress_label.Text = "Адрес доставки";
            this.change_orders_adress_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_orders_date_label
            // 
            this.change_orders_date_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_orders_date_label.Location = new System.Drawing.Point(12, 236);
            this.change_orders_date_label.Name = "change_orders_date_label";
            this.change_orders_date_label.Size = new System.Drawing.Size(560, 20);
            this.change_orders_date_label.TabIndex = 33;
            this.change_orders_date_label.Text = "Дата оформления заказа";
            this.change_orders_date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_orders_inst_label
            // 
            this.change_orders_inst_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_orders_inst_label.Location = new System.Drawing.Point(12, 56);
            this.change_orders_inst_label.Name = "change_orders_inst_label";
            this.change_orders_inst_label.Size = new System.Drawing.Size(560, 20);
            this.change_orders_inst_label.TabIndex = 34;
            this.change_orders_inst_label.Text = "Инструменты в заказе";
            this.change_orders_inst_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_orders_client_label
            // 
            this.change_orders_client_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_orders_client_label.Location = new System.Drawing.Point(12, 9);
            this.change_orders_client_label.Name = "change_orders_client_label";
            this.change_orders_client_label.Size = new System.Drawing.Size(560, 20);
            this.change_orders_client_label.TabIndex = 35;
            this.change_orders_client_label.Text = "Клиент";
            this.change_orders_client_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_orders_status_cb
            // 
            this.change_orders_status_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_orders_status_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.change_orders_status_cb.FormattingEnabled = true;
            this.change_orders_status_cb.Items.AddRange(new object[] {
            "Создан",
            "Обрабатывается",
            "Передан в доставку",
            "В пути",
            "Доставлен"});
            this.change_orders_status_cb.Location = new System.Drawing.Point(12, 351);
            this.change_orders_status_cb.Name = "change_orders_status_cb";
            this.change_orders_status_cb.Size = new System.Drawing.Size(560, 21);
            this.change_orders_status_cb.TabIndex = 29;
            // 
            // change_orders_client_cb
            // 
            this.change_orders_client_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_orders_client_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.change_orders_client_cb.FormattingEnabled = true;
            this.change_orders_client_cb.Location = new System.Drawing.Point(12, 32);
            this.change_orders_client_cb.Name = "change_orders_client_cb";
            this.change_orders_client_cb.Size = new System.Drawing.Size(560, 21);
            this.change_orders_client_cb.TabIndex = 30;
            // 
            // change_orders_button
            // 
            this.change_orders_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.change_orders_button.Location = new System.Drawing.Point(241, 410);
            this.change_orders_button.Name = "change_orders_button";
            this.change_orders_button.Size = new System.Drawing.Size(105, 23);
            this.change_orders_button.TabIndex = 39;
            this.change_orders_button.Text = "Изменить";
            this.change_orders_button.UseVisualStyleBackColor = true;
            this.change_orders_button.Click += new System.EventHandler(this.change_orders_button_Click);
            // 
            // change_in_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.change_orders_button);
            this.Controls.Add(this.change_orders_adress_tb);
            this.Controls.Add(this.change_orders_date_dtp);
            this.Controls.Add(this.change_orders_inst_clb);
            this.Controls.Add(this.change_orders_status_label);
            this.Controls.Add(this.change_orders_adress_label);
            this.Controls.Add(this.change_orders_date_label);
            this.Controls.Add(this.change_orders_inst_label);
            this.Controls.Add(this.change_orders_client_label);
            this.Controls.Add(this.change_orders_status_cb);
            this.Controls.Add(this.change_orders_client_cb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "change_in_orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox change_orders_adress_tb;
        public System.Windows.Forms.DateTimePicker change_orders_date_dtp;
        public System.Windows.Forms.CheckedListBox change_orders_inst_clb;
        private System.Windows.Forms.Label change_orders_status_label;
        private System.Windows.Forms.Label change_orders_adress_label;
        private System.Windows.Forms.Label change_orders_date_label;
        private System.Windows.Forms.Label change_orders_inst_label;
        private System.Windows.Forms.Label change_orders_client_label;
        public System.Windows.Forms.ComboBox change_orders_status_cb;
        public System.Windows.Forms.ComboBox change_orders_client_cb;
        private System.Windows.Forms.Button change_orders_button;
    }
}