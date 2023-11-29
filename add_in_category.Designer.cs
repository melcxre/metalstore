namespace kursovaya
{
    partial class add_in_category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_in_category));
            this.add_category_button = new System.Windows.Forms.Button();
            this.add_category_tb = new System.Windows.Forms.TextBox();
            this.add_category_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_category_button
            // 
            this.add_category_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_category_button.Location = new System.Drawing.Point(91, 80);
            this.add_category_button.Name = "add_category_button";
            this.add_category_button.Size = new System.Drawing.Size(105, 23);
            this.add_category_button.TabIndex = 5;
            this.add_category_button.Text = "Добавить";
            this.add_category_button.UseVisualStyleBackColor = true;
            this.add_category_button.Click += new System.EventHandler(this.add_category_button_Click);
            // 
            // add_category_tb
            // 
            this.add_category_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_category_tb.Location = new System.Drawing.Point(12, 32);
            this.add_category_tb.Name = "add_category_tb";
            this.add_category_tb.Size = new System.Drawing.Size(260, 20);
            this.add_category_tb.TabIndex = 4;
            this.add_category_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_category_tb_KeyPress);
            // 
            // add_category_label
            // 
            this.add_category_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_category_label.Location = new System.Drawing.Point(12, 9);
            this.add_category_label.Name = "add_category_label";
            this.add_category_label.Size = new System.Drawing.Size(260, 20);
            this.add_category_label.TabIndex = 3;
            this.add_category_label.Text = "Категория";
            this.add_category_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_in_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.add_category_button);
            this.Controls.Add(this.add_category_tb);
            this.Controls.Add(this.add_category_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_in_category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_category_button;
        private System.Windows.Forms.TextBox add_category_tb;
        private System.Windows.Forms.Label add_category_label;
    }
}