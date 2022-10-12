namespace Trevago_project
{
    partial class admin_form
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
            this.search_button_admin = new System.Windows.Forms.Button();
            this.cancel_reservation_button_admin = new System.Windows.Forms.Button();
            this.reservation_button_admin = new System.Windows.Forms.Button();
            this.manage_room_button = new System.Windows.Forms.Button();
            this.manage_hotel_button = new System.Windows.Forms.Button();
            this.hotel_report_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.X_label);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 94);
            this.panel1.TabIndex = 6;
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Font = new System.Drawing.Font("Akhbar MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.X_label.Location = new System.Drawing.Point(700, 14);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(36, 39);
            this.X_label.TabIndex = 33;
            this.X_label.Text = "X";
            this.X_label.Click += new System.EventHandler(this.X_label_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Chocolate;
            this.back_button.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.Black;
            this.back_button.Location = new System.Drawing.Point(10, 14);
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
            this.label2.Location = new System.Drawing.Point(226, -17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 111);
            this.label2.TabIndex = 1;
            this.label2.Text = "trivago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // search_button_admin
            // 
            this.search_button_admin.BackColor = System.Drawing.Color.Chocolate;
            this.search_button_admin.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button_admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_button_admin.Location = new System.Drawing.Point(246, 140);
            this.search_button_admin.Name = "search_button_admin";
            this.search_button_admin.Size = new System.Drawing.Size(237, 42);
            this.search_button_admin.TabIndex = 11;
            this.search_button_admin.Text = "Search";
            this.search_button_admin.UseVisualStyleBackColor = false;
            this.search_button_admin.Click += new System.EventHandler(this.search_button_admin_Click);
            // 
            // cancel_reservation_button_admin
            // 
            this.cancel_reservation_button_admin.BackColor = System.Drawing.Color.Chocolate;
            this.cancel_reservation_button_admin.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_reservation_button_admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_reservation_button_admin.Location = new System.Drawing.Point(246, 240);
            this.cancel_reservation_button_admin.Name = "cancel_reservation_button_admin";
            this.cancel_reservation_button_admin.Size = new System.Drawing.Size(237, 44);
            this.cancel_reservation_button_admin.TabIndex = 10;
            this.cancel_reservation_button_admin.Text = "cancel Reservation";
            this.cancel_reservation_button_admin.UseVisualStyleBackColor = false;
            this.cancel_reservation_button_admin.Click += new System.EventHandler(this.cancel_reservation_button_admin_Click);
            // 
            // reservation_button_admin
            // 
            this.reservation_button_admin.BackColor = System.Drawing.Color.Chocolate;
            this.reservation_button_admin.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_button_admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservation_button_admin.Location = new System.Drawing.Point(246, 188);
            this.reservation_button_admin.Name = "reservation_button_admin";
            this.reservation_button_admin.Size = new System.Drawing.Size(237, 46);
            this.reservation_button_admin.TabIndex = 9;
            this.reservation_button_admin.Text = "Reservation";
            this.reservation_button_admin.UseVisualStyleBackColor = false;
            this.reservation_button_admin.Click += new System.EventHandler(this.reservation_button_admin_Click);
            // 
            // manage_room_button
            // 
            this.manage_room_button.BackColor = System.Drawing.Color.Chocolate;
            this.manage_room_button.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_room_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manage_room_button.Location = new System.Drawing.Point(246, 290);
            this.manage_room_button.Name = "manage_room_button";
            this.manage_room_button.Size = new System.Drawing.Size(237, 43);
            this.manage_room_button.TabIndex = 12;
            this.manage_room_button.Text = "manage Room";
            this.manage_room_button.UseVisualStyleBackColor = false;
            this.manage_room_button.Click += new System.EventHandler(this.manage_room_button_Click);
            // 
            // manage_hotel_button
            // 
            this.manage_hotel_button.BackColor = System.Drawing.Color.Chocolate;
            this.manage_hotel_button.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_hotel_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manage_hotel_button.Location = new System.Drawing.Point(246, 339);
            this.manage_hotel_button.Name = "manage_hotel_button";
            this.manage_hotel_button.Size = new System.Drawing.Size(237, 41);
            this.manage_hotel_button.TabIndex = 13;
            this.manage_hotel_button.Text = "manage hotel";
            this.manage_hotel_button.UseVisualStyleBackColor = false;
            this.manage_hotel_button.Click += new System.EventHandler(this.manage_hotel_button_Click);
            // 
            // hotel_report_button
            // 
            this.hotel_report_button.BackColor = System.Drawing.Color.Chocolate;
            this.hotel_report_button.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotel_report_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hotel_report_button.Location = new System.Drawing.Point(246, 386);
            this.hotel_report_button.Name = "hotel_report_button";
            this.hotel_report_button.Size = new System.Drawing.Size(237, 37);
            this.hotel_report_button.TabIndex = 14;
            this.hotel_report_button.Text = "Report";
            this.hotel_report_button.UseVisualStyleBackColor = false;
            this.hotel_report_button.Click += new System.EventHandler(this.hotel_report_button_Click);
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.hotel_report_button);
            this.Controls.Add(this.manage_hotel_button);
            this.Controls.Add(this.manage_room_button);
            this.Controls.Add(this.search_button_admin);
            this.Controls.Add(this.cancel_reservation_button_admin);
            this.Controls.Add(this.reservation_button_admin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_form";
            this.Load += new System.EventHandler(this.admin_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search_button_admin;
        private System.Windows.Forms.Button cancel_reservation_button_admin;
        private System.Windows.Forms.Button reservation_button_admin;
        private System.Windows.Forms.Button manage_room_button;
        private System.Windows.Forms.Button manage_hotel_button;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.Button hotel_report_button;
    }
}