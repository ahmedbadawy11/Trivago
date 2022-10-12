namespace Trevago_project
{
    partial class deleting_reservation_form
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
            this.cancel_res_username_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleting_res_dataGridView = new System.Windows.Forms.DataGridView();
            this.delete_reservation_button = new System.Windows.Forms.Button();
            this.show_res_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleting_res_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.X_label);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 99);
            this.panel1.TabIndex = 7;
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Font = new System.Drawing.Font("Akhbar MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.X_label.ForeColor = System.Drawing.Color.Black;
            this.X_label.Location = new System.Drawing.Point(654, 12);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(36, 39);
            this.X_label.TabIndex = 34;
            this.X_label.Text = "X";
            this.X_label.Click += new System.EventHandler(this.X_label_Click_1);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Chocolate;
            this.back_button.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.Black;
            this.back_button.Location = new System.Drawing.Point(22, 15);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(115, 40);
            this.back_button.TabIndex = 12;
            this.back_button.Text = "BacK";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(201, -12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 111);
            this.label2.TabIndex = 1;
            this.label2.Text = "trivago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel_res_username_textBox
            // 
            this.cancel_res_username_textBox.Location = new System.Drawing.Point(419, 138);
            this.cancel_res_username_textBox.Name = "cancel_res_username_textBox";
            this.cancel_res_username_textBox.Size = new System.Drawing.Size(224, 22);
            this.cancel_res_username_textBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "enter the username you reserved with:";
            // 
            // deleting_res_dataGridView
            // 
            this.deleting_res_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleting_res_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleting_res_dataGridView.Location = new System.Drawing.Point(28, 206);
            this.deleting_res_dataGridView.Name = "deleting_res_dataGridView";
            this.deleting_res_dataGridView.RowHeadersWidth = 51;
            this.deleting_res_dataGridView.RowTemplate.Height = 24;
            this.deleting_res_dataGridView.Size = new System.Drawing.Size(626, 88);
            this.deleting_res_dataGridView.TabIndex = 10;
            // 
            // delete_reservation_button
            // 
            this.delete_reservation_button.BackColor = System.Drawing.Color.Chocolate;
            this.delete_reservation_button.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_reservation_button.ForeColor = System.Drawing.Color.Snow;
            this.delete_reservation_button.Location = new System.Drawing.Point(258, 300);
            this.delete_reservation_button.Name = "delete_reservation_button";
            this.delete_reservation_button.Size = new System.Drawing.Size(182, 49);
            this.delete_reservation_button.TabIndex = 11;
            this.delete_reservation_button.Text = "delete Reservaion";
            this.delete_reservation_button.UseVisualStyleBackColor = false;
            this.delete_reservation_button.Click += new System.EventHandler(this.delete_reservation_button_Click);
            // 
            // show_res_button
            // 
            this.show_res_button.BackColor = System.Drawing.Color.Chocolate;
            this.show_res_button.Font = new System.Drawing.Font("Script MT Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_res_button.ForeColor = System.Drawing.Color.Snow;
            this.show_res_button.Location = new System.Drawing.Point(28, 179);
            this.show_res_button.Name = "show_res_button";
            this.show_res_button.Size = new System.Drawing.Size(233, 30);
            this.show_res_button.TabIndex = 12;
            this.show_res_button.Text = "show reservation";
            this.show_res_button.UseVisualStyleBackColor = false;
            this.show_res_button.Click += new System.EventHandler(this.show_res_button_Click);
            // 
            // deleting_reservation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(697, 389);
            this.Controls.Add(this.show_res_button);
            this.Controls.Add(this.delete_reservation_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleting_res_dataGridView);
            this.Controls.Add(this.cancel_res_username_textBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deleting_reservation_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deleting_reservation_form";
            this.Load += new System.EventHandler(this.deleting_reservation_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleting_res_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView deleting_res_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cancel_res_username_textBox;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button delete_reservation_button;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.Button show_res_button;
    }
}