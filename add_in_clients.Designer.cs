namespace kursovaya
{
    partial class add_in_clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_in_clients));
            this.add_clients_face_cb = new System.Windows.Forms.ComboBox();
            this.add_clients_name_tb = new System.Windows.Forms.TextBox();
            this.add_clients_inn_label = new System.Windows.Forms.Label();
            this.add_clients_contact_label = new System.Windows.Forms.Label();
            this.add_clients_name_label = new System.Windows.Forms.Label();
            this.add_clients_face_label = new System.Windows.Forms.Label();
            this.add_clients_button = new System.Windows.Forms.Button();
            this.add_clients_phoneormail_cb = new System.Windows.Forms.ComboBox();
            this.add_clients_contact_tb = new System.Windows.Forms.MaskedTextBox();
            this.add_clients_inn_tb = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // add_clients_face_cb
            // 
            this.add_clients_face_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_clients_face_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_clients_face_cb.FormattingEnabled = true;
            this.add_clients_face_cb.Items.AddRange(new object[] {
            "Физическое",
            "Юридическое"});
            this.add_clients_face_cb.Location = new System.Drawing.Point(12, 32);
            this.add_clients_face_cb.Name = "add_clients_face_cb";
            this.add_clients_face_cb.Size = new System.Drawing.Size(260, 21);
            this.add_clients_face_cb.TabIndex = 20;
            this.add_clients_face_cb.TextChanged += new System.EventHandler(this.add_clients_face_cb_TextChanged);
            // 
            // add_clients_name_tb
            // 
            this.add_clients_name_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_clients_name_tb.Location = new System.Drawing.Point(12, 80);
            this.add_clients_name_tb.Name = "add_clients_name_tb";
            this.add_clients_name_tb.Size = new System.Drawing.Size(260, 20);
            this.add_clients_name_tb.TabIndex = 17;
            this.add_clients_name_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_clients_name_tb_KeyPress);
            // 
            // add_clients_inn_label
            // 
            this.add_clients_inn_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_clients_inn_label.Enabled = false;
            this.add_clients_inn_label.Location = new System.Drawing.Point(12, 149);
            this.add_clients_inn_label.Name = "add_clients_inn_label";
            this.add_clients_inn_label.Size = new System.Drawing.Size(260, 20);
            this.add_clients_inn_label.TabIndex = 11;
            this.add_clients_inn_label.Text = "ИНН";
            this.add_clients_inn_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_clients_contact_label
            // 
            this.add_clients_contact_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_clients_contact_label.Location = new System.Drawing.Point(12, 103);
            this.add_clients_contact_label.Name = "add_clients_contact_label";
            this.add_clients_contact_label.Size = new System.Drawing.Size(260, 20);
            this.add_clients_contact_label.TabIndex = 12;
            this.add_clients_contact_label.Text = "Контактный номер или почта";
            this.add_clients_contact_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_clients_name_label
            // 
            this.add_clients_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_clients_name_label.Location = new System.Drawing.Point(12, 55);
            this.add_clients_name_label.Name = "add_clients_name_label";
            this.add_clients_name_label.Size = new System.Drawing.Size(260, 20);
            this.add_clients_name_label.TabIndex = 14;
            this.add_clients_name_label.Text = "ФИО или название фирмы";
            this.add_clients_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_clients_face_label
            // 
            this.add_clients_face_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_clients_face_label.Location = new System.Drawing.Point(12, 9);
            this.add_clients_face_label.Name = "add_clients_face_label";
            this.add_clients_face_label.Size = new System.Drawing.Size(260, 20);
            this.add_clients_face_label.TabIndex = 15;
            this.add_clients_face_label.Text = "Лицо";
            this.add_clients_face_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_clients_button
            // 
            this.add_clients_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_clients_button.Location = new System.Drawing.Point(91, 230);
            this.add_clients_button.Name = "add_clients_button";
            this.add_clients_button.Size = new System.Drawing.Size(105, 23);
            this.add_clients_button.TabIndex = 21;
            this.add_clients_button.Text = "Добавить";
            this.add_clients_button.UseVisualStyleBackColor = true;
            this.add_clients_button.Click += new System.EventHandler(this.add_clients_button_Click);
            // 
            // add_clients_phoneormail_cb
            // 
            this.add_clients_phoneormail_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_clients_phoneormail_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_clients_phoneormail_cb.FormattingEnabled = true;
            this.add_clients_phoneormail_cb.Items.AddRange(new object[] {
            "Телефон",
            "Почта"});
            this.add_clients_phoneormail_cb.Location = new System.Drawing.Point(12, 126);
            this.add_clients_phoneormail_cb.Name = "add_clients_phoneormail_cb";
            this.add_clients_phoneormail_cb.Size = new System.Drawing.Size(80, 21);
            this.add_clients_phoneormail_cb.TabIndex = 20;
            this.add_clients_phoneormail_cb.TextChanged += new System.EventHandler(this.add_clients_phoneormail_cb_TextChanged);
            // 
            // add_clients_contact_tb
            // 
            this.add_clients_contact_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_clients_contact_tb.BackColor = System.Drawing.SystemColors.Window;
            this.add_clients_contact_tb.Location = new System.Drawing.Point(99, 126);
            this.add_clients_contact_tb.Name = "add_clients_contact_tb";
            this.add_clients_contact_tb.ReadOnly = true;
            this.add_clients_contact_tb.Size = new System.Drawing.Size(173, 20);
            this.add_clients_contact_tb.TabIndex = 22;
            this.add_clients_contact_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_clients_contact_tb_KeyPress);
            // 
            // add_clients_inn_tb
            // 
            this.add_clients_inn_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_clients_inn_tb.BackColor = System.Drawing.SystemColors.Window;
            this.add_clients_inn_tb.Enabled = false;
            this.add_clients_inn_tb.Location = new System.Drawing.Point(12, 172);
            this.add_clients_inn_tb.Name = "add_clients_inn_tb";
            this.add_clients_inn_tb.Size = new System.Drawing.Size(260, 20);
            this.add_clients_inn_tb.TabIndex = 22;
            // 
            // add_in_clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.add_clients_inn_tb);
            this.Controls.Add(this.add_clients_contact_tb);
            this.Controls.Add(this.add_clients_button);
            this.Controls.Add(this.add_clients_phoneormail_cb);
            this.Controls.Add(this.add_clients_face_cb);
            this.Controls.Add(this.add_clients_name_tb);
            this.Controls.Add(this.add_clients_inn_label);
            this.Controls.Add(this.add_clients_contact_label);
            this.Controls.Add(this.add_clients_name_label);
            this.Controls.Add(this.add_clients_face_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_in_clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox add_clients_face_cb;
        public System.Windows.Forms.TextBox add_clients_name_tb;
        private System.Windows.Forms.Label add_clients_inn_label;
        private System.Windows.Forms.Label add_clients_contact_label;
        private System.Windows.Forms.Label add_clients_name_label;
        private System.Windows.Forms.Label add_clients_face_label;
        private System.Windows.Forms.Button add_clients_button;
        public System.Windows.Forms.ComboBox add_clients_phoneormail_cb;
        public System.Windows.Forms.MaskedTextBox add_clients_contact_tb;
        public System.Windows.Forms.MaskedTextBox add_clients_inn_tb;
    }
}