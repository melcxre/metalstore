namespace kursovaya
{
    partial class change_in_country
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_in_country));
            this.change_country_button = new System.Windows.Forms.Button();
            this.change_country_tb = new System.Windows.Forms.TextBox();
            this.change_country_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // change_country_button
            // 
            this.change_country_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.change_country_button.Location = new System.Drawing.Point(91, 80);
            this.change_country_button.Name = "change_country_button";
            this.change_country_button.Size = new System.Drawing.Size(105, 23);
            this.change_country_button.TabIndex = 5;
            this.change_country_button.Text = "Изменить";
            this.change_country_button.UseVisualStyleBackColor = true;
            this.change_country_button.Click += new System.EventHandler(this.change_country_button_Click);
            // 
            // change_country_tb
            // 
            this.change_country_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_country_tb.Location = new System.Drawing.Point(12, 32);
            this.change_country_tb.Name = "change_country_tb";
            this.change_country_tb.Size = new System.Drawing.Size(260, 20);
            this.change_country_tb.TabIndex = 4;
            this.change_country_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.change_country_tb_KeyPress);
            // 
            // change_country_label
            // 
            this.change_country_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_country_label.Location = new System.Drawing.Point(12, 9);
            this.change_country_label.Name = "change_country_label";
            this.change_country_label.Size = new System.Drawing.Size(260, 20);
            this.change_country_label.TabIndex = 3;
            this.change_country_label.Text = "Новое значение";
            this.change_country_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_in_country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.change_country_button);
            this.Controls.Add(this.change_country_tb);
            this.Controls.Add(this.change_country_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "change_in_country";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change_country_button;
        private System.Windows.Forms.Label change_country_label;
        public System.Windows.Forms.TextBox change_country_tb;
    }
}