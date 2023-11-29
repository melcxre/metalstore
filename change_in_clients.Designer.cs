namespace kursovaya
{
    partial class change_in_clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_in_clients));
            this.change_clients_inn_tb = new System.Windows.Forms.MaskedTextBox();
            this.change_clients_contact_tb = new System.Windows.Forms.MaskedTextBox();
            this.change_clients_button = new System.Windows.Forms.Button();
            this.change_clients_phoneormail_cb = new System.Windows.Forms.ComboBox();
            this.change_clients_face_cb = new System.Windows.Forms.ComboBox();
            this.change_clients_name_tb = new System.Windows.Forms.TextBox();
            this.change_clients_inn_label = new System.Windows.Forms.Label();
            this.change_clients_contact_label = new System.Windows.Forms.Label();
            this.change_clients_name_label = new System.Windows.Forms.Label();
            this.change_clients_face_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // change_clients_inn_tb
            // 
            this.change_clients_inn_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_clients_inn_tb.BackColor = System.Drawing.SystemColors.Window;
            this.change_clients_inn_tb.Enabled = false;
            this.change_clients_inn_tb.Location = new System.Drawing.Point(12, 172);
            this.change_clients_inn_tb.Name = "change_clients_inn_tb";
            this.change_clients_inn_tb.Size = new System.Drawing.Size(260, 20);
            this.change_clients_inn_tb.TabIndex = 31;
            // 
            // change_clients_contact_tb
            // 
            this.change_clients_contact_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_clients_contact_tb.BackColor = System.Drawing.SystemColors.Window;
            this.change_clients_contact_tb.Location = new System.Drawing.Point(99, 126);
            this.change_clients_contact_tb.Name = "change_clients_contact_tb";
            this.change_clients_contact_tb.ReadOnly = true;
            this.change_clients_contact_tb.Size = new System.Drawing.Size(173, 20);
            this.change_clients_contact_tb.TabIndex = 32;
            this.change_clients_contact_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.change_clients_contact_tb_KeyPress);
            // 
            // change_clients_button
            // 
            this.change_clients_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.change_clients_button.Location = new System.Drawing.Point(91, 230);
            this.change_clients_button.Name = "change_clients_button";
            this.change_clients_button.Size = new System.Drawing.Size(105, 23);
            this.change_clients_button.TabIndex = 30;
            this.change_clients_button.Text = "Изменить";
            this.change_clients_button.UseVisualStyleBackColor = true;
            this.change_clients_button.Click += new System.EventHandler(this.change_clients_button_Click);
            // 
            // change_clients_phoneormail_cb
            // 
            this.change_clients_phoneormail_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_clients_phoneormail_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.change_clients_phoneormail_cb.FormattingEnabled = true;
            this.change_clients_phoneormail_cb.Items.AddRange(new object[] {
            "Телефон",
            "Почта"});
            this.change_clients_phoneormail_cb.Location = new System.Drawing.Point(12, 126);
            this.change_clients_phoneormail_cb.Name = "change_clients_phoneormail_cb";
            this.change_clients_phoneormail_cb.Size = new System.Drawing.Size(80, 21);
            this.change_clients_phoneormail_cb.TabIndex = 28;
            this.change_clients_phoneormail_cb.TextChanged += new System.EventHandler(this.change_clients_phoneormail_cb_TextChanged);
            // 
            // change_clients_face_cb
            // 
            this.change_clients_face_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_clients_face_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.change_clients_face_cb.FormattingEnabled = true;
            this.change_clients_face_cb.Items.AddRange(new object[] {
            "Физическое",
            "Юридическое"});
            this.change_clients_face_cb.Location = new System.Drawing.Point(12, 32);
            this.change_clients_face_cb.Name = "change_clients_face_cb";
            this.change_clients_face_cb.Size = new System.Drawing.Size(260, 21);
            this.change_clients_face_cb.TabIndex = 29;
            this.change_clients_face_cb.TextChanged += new System.EventHandler(this.change_clients_face_cb_TextChanged);
            // 
            // change_clients_name_tb
            // 
            this.change_clients_name_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_clients_name_tb.Location = new System.Drawing.Point(12, 80);
            this.change_clients_name_tb.Name = "change_clients_name_tb";
            this.change_clients_name_tb.Size = new System.Drawing.Size(260, 20);
            this.change_clients_name_tb.TabIndex = 27;
            this.change_clients_name_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.change_clients_name_tb_KeyPress);
            // 
            // change_clients_inn_label
            // 
            this.change_clients_inn_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_clients_inn_label.Enabled = false;
            this.change_clients_inn_label.Location = new System.Drawing.Point(12, 149);
            this.change_clients_inn_label.Name = "change_clients_inn_label";
            this.change_clients_inn_label.Size = new System.Drawing.Size(260, 20);
            this.change_clients_inn_label.TabIndex = 23;
            this.change_clients_inn_label.Text = "ИНН";
            this.change_clients_inn_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_clients_contact_label
            // 
            this.change_clients_contact_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_clients_contact_label.Location = new System.Drawing.Point(12, 103);
            this.change_clients_contact_label.Name = "change_clients_contact_label";
            this.change_clients_contact_label.Size = new System.Drawing.Size(260, 20);
            this.change_clients_contact_label.TabIndex = 24;
            this.change_clients_contact_label.Text = "Контактный номер или почта";
            this.change_clients_contact_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_clients_name_label
            // 
            this.change_clients_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_clients_name_label.Location = new System.Drawing.Point(12, 55);
            this.change_clients_name_label.Name = "change_clients_name_label";
            this.change_clients_name_label.Size = new System.Drawing.Size(260, 20);
            this.change_clients_name_label.TabIndex = 25;
            this.change_clients_name_label.Text = "ФИО или название фирмы";
            this.change_clients_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_clients_face_label
            // 
            this.change_clients_face_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_clients_face_label.Location = new System.Drawing.Point(12, 9);
            this.change_clients_face_label.Name = "change_clients_face_label";
            this.change_clients_face_label.Size = new System.Drawing.Size(260, 20);
            this.change_clients_face_label.TabIndex = 26;
            this.change_clients_face_label.Text = "Лицо";
            this.change_clients_face_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_in_clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.change_clients_inn_tb);
            this.Controls.Add(this.change_clients_contact_tb);
            this.Controls.Add(this.change_clients_button);
            this.Controls.Add(this.change_clients_phoneormail_cb);
            this.Controls.Add(this.change_clients_face_cb);
            this.Controls.Add(this.change_clients_name_tb);
            this.Controls.Add(this.change_clients_inn_label);
            this.Controls.Add(this.change_clients_contact_label);
            this.Controls.Add(this.change_clients_name_label);
            this.Controls.Add(this.change_clients_face_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "change_in_clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox change_clients_inn_tb;
        public System.Windows.Forms.MaskedTextBox change_clients_contact_tb;
        private System.Windows.Forms.Button change_clients_button;
        public System.Windows.Forms.ComboBox change_clients_phoneormail_cb;
        public System.Windows.Forms.ComboBox change_clients_face_cb;
        public System.Windows.Forms.TextBox change_clients_name_tb;
        private System.Windows.Forms.Label change_clients_inn_label;
        private System.Windows.Forms.Label change_clients_contact_label;
        private System.Windows.Forms.Label change_clients_name_label;
        private System.Windows.Forms.Label change_clients_face_label;
    }
}