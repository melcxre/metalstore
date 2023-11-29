namespace kursovaya
{
    partial class change_in_category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_in_category));
            this.change_category_button = new System.Windows.Forms.Button();
            this.change_category_tb = new System.Windows.Forms.TextBox();
            this.change_category_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // change_category_button
            // 
            this.change_category_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.change_category_button.Location = new System.Drawing.Point(91, 80);
            this.change_category_button.Name = "change_category_button";
            this.change_category_button.Size = new System.Drawing.Size(105, 23);
            this.change_category_button.TabIndex = 15;
            this.change_category_button.Text = "Изменить";
            this.change_category_button.UseVisualStyleBackColor = true;
            this.change_category_button.Click += new System.EventHandler(this.change_category_button_Click);
            // 
            // change_category_tb
            // 
            this.change_category_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_category_tb.Location = new System.Drawing.Point(12, 32);
            this.change_category_tb.Name = "change_category_tb";
            this.change_category_tb.Size = new System.Drawing.Size(260, 20);
            this.change_category_tb.TabIndex = 14;
            this.change_category_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.change_category_tb_KeyPress);
            // 
            // change_category_label
            // 
            this.change_category_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_category_label.Location = new System.Drawing.Point(12, 9);
            this.change_category_label.Name = "change_category_label";
            this.change_category_label.Size = new System.Drawing.Size(260, 20);
            this.change_category_label.TabIndex = 12;
            this.change_category_label.Text = "Новое значение";
            this.change_category_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_in_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.change_category_button);
            this.Controls.Add(this.change_category_tb);
            this.Controls.Add(this.change_category_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "change_in_category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button change_category_button;
        private System.Windows.Forms.Label change_category_label;
        public System.Windows.Forms.TextBox change_category_tb;
    }
}