namespace kursovaya
{
    partial class add_in_country
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_in_country));
            this.add_country_label = new System.Windows.Forms.Label();
            this.add_country_tb = new System.Windows.Forms.TextBox();
            this.add_country_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_country_label
            // 
            this.add_country_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_country_label.Location = new System.Drawing.Point(12, 9);
            this.add_country_label.Name = "add_country_label";
            this.add_country_label.Size = new System.Drawing.Size(260, 20);
            this.add_country_label.TabIndex = 0;
            this.add_country_label.Text = "Страна";
            this.add_country_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_country_tb
            // 
            this.add_country_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_country_tb.Location = new System.Drawing.Point(12, 32);
            this.add_country_tb.Name = "add_country_tb";
            this.add_country_tb.Size = new System.Drawing.Size(260, 20);
            this.add_country_tb.TabIndex = 1;
            this.add_country_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_country_tb_KeyPress);
            // 
            // add_country_button
            // 
            this.add_country_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_country_button.Location = new System.Drawing.Point(91, 80);
            this.add_country_button.Name = "add_country_button";
            this.add_country_button.Size = new System.Drawing.Size(105, 23);
            this.add_country_button.TabIndex = 2;
            this.add_country_button.Text = "Добавить";
            this.add_country_button.UseVisualStyleBackColor = true;
            this.add_country_button.Click += new System.EventHandler(this.add_country_button_Click);
            // 
            // add_in_country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.add_country_button);
            this.Controls.Add(this.add_country_tb);
            this.Controls.Add(this.add_country_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_in_country";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_country_label;
        private System.Windows.Forms.TextBox add_country_tb;
        private System.Windows.Forms.Button add_country_button;
    }
}