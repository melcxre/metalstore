namespace kursovaya
{
    partial class change_in_availability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_in_availability));
            this.change_availability_button = new System.Windows.Forms.Button();
            this.change_availability_tb = new System.Windows.Forms.TextBox();
            this.change_availability_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // change_availability_button
            // 
            this.change_availability_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.change_availability_button.Location = new System.Drawing.Point(91, 80);
            this.change_availability_button.Name = "change_availability_button";
            this.change_availability_button.Size = new System.Drawing.Size(105, 23);
            this.change_availability_button.TabIndex = 10;
            this.change_availability_button.Text = "Изменить";
            this.change_availability_button.UseVisualStyleBackColor = true;
            this.change_availability_button.Click += new System.EventHandler(this.change_availability_button_Click);
            // 
            // change_availability_tb
            // 
            this.change_availability_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_availability_tb.Location = new System.Drawing.Point(12, 32);
            this.change_availability_tb.Name = "change_availability_tb";
            this.change_availability_tb.Size = new System.Drawing.Size(260, 20);
            this.change_availability_tb.TabIndex = 9;
            this.change_availability_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.change_availability_tb_KeyPress);
            // 
            // change_availability_label
            // 
            this.change_availability_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_availability_label.Location = new System.Drawing.Point(12, 9);
            this.change_availability_label.Name = "change_availability_label";
            this.change_availability_label.Size = new System.Drawing.Size(260, 20);
            this.change_availability_label.TabIndex = 7;
            this.change_availability_label.Text = "Новое значение";
            this.change_availability_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_in_availability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.change_availability_button);
            this.Controls.Add(this.change_availability_tb);
            this.Controls.Add(this.change_availability_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "change_in_availability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button change_availability_button;
        private System.Windows.Forms.Label change_availability_label;
        public System.Windows.Forms.TextBox change_availability_tb;
    }
}