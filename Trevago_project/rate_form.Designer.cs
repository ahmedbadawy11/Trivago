namespace Trevago_project
{
    partial class rate_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.X_label = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rate_dataGridView = new System.Windows.Forms.DataGridView();
            this.rate_cb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rate_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.X_label);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 97);
            this.panel1.TabIndex = 9;
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Font = new System.Drawing.Font("Akhbar MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.X_label.Location = new System.Drawing.Point(698, 15);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(36, 39);
            this.X_label.TabIndex = 34;
            this.X_label.Text = "X";
            this.X_label.Click += new System.EventHandler(this.X_label_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Chocolate;
            this.back_button.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.Black;
            this.back_button.Location = new System.Drawing.Point(14, 18);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(115, 40);
            this.back_button.TabIndex = 13;
            this.back_button.Text = "BacK";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(204, -14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 111);
            this.label2.TabIndex = 1;
            this.label2.Text = "trivago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rate_dataGridView
            // 
            this.rate_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rate_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rate_dataGridView.Location = new System.Drawing.Point(28, 155);
            this.rate_dataGridView.Name = "rate_dataGridView";
            this.rate_dataGridView.RowHeadersWidth = 51;
            this.rate_dataGridView.RowTemplate.Height = 24;
            this.rate_dataGridView.Size = new System.Drawing.Size(688, 262);
            this.rate_dataGridView.TabIndex = 10;
            // 
            // rate_cb
            // 
            this.rate_cb.FormattingEnabled = true;
            this.rate_cb.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.rate_cb.Location = new System.Drawing.Point(28, 108);
            this.rate_cb.Name = "rate_cb";
            this.rate_cb.Size = new System.Drawing.Size(184, 24);
            this.rate_cb.TabIndex = 11;
            this.rate_cb.SelectedIndexChanged += new System.EventHandler(this.rate_cb_SelectedIndexChanged);
            // 
            // rate_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.rate_cb);
            this.Controls.Add(this.rate_dataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rate_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rate_form";
            this.Load += new System.EventHandler(this.rate_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rate_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView rate_dataGridView;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.ComboBox rate_cb;
    }
}