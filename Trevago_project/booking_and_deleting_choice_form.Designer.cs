namespace Trevago_project
{
    partial class booking_and_deleting_choice_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.reservation_button = new System.Windows.Forms.Button();
            this.cancel_reservation_button_bookinganddeleting = new System.Windows.Forms.Button();
            this.search_button_bokinganddeletingform = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.X_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 88);
            this.panel1.TabIndex = 5;
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Font = new System.Drawing.Font("Akhbar MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.X_label.Location = new System.Drawing.Point(586, 13);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(36, 39);
            this.X_label.TabIndex = 33;
            this.X_label.Text = "X";
            this.X_label.Click += new System.EventHandler(this.X_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(192, -23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 111);
            this.label2.TabIndex = 1;
            this.label2.Text = "trivago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reservation_button
            // 
            this.reservation_button.BackColor = System.Drawing.Color.Chocolate;
            this.reservation_button.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservation_button.Location = new System.Drawing.Point(223, 204);
            this.reservation_button.Name = "reservation_button";
            this.reservation_button.Size = new System.Drawing.Size(156, 77);
            this.reservation_button.TabIndex = 6;
            this.reservation_button.Text = "Reservation";
            this.reservation_button.UseVisualStyleBackColor = false;
            this.reservation_button.Click += new System.EventHandler(this.reservation_button_Click);
            // 
            // cancel_reservation_button_bookinganddeleting
            // 
            this.cancel_reservation_button_bookinganddeleting.BackColor = System.Drawing.Color.Chocolate;
            this.cancel_reservation_button_bookinganddeleting.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_reservation_button_bookinganddeleting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_reservation_button_bookinganddeleting.Location = new System.Drawing.Point(223, 298);
            this.cancel_reservation_button_bookinganddeleting.Name = "cancel_reservation_button_bookinganddeleting";
            this.cancel_reservation_button_bookinganddeleting.Size = new System.Drawing.Size(156, 81);
            this.cancel_reservation_button_bookinganddeleting.TabIndex = 7;
            this.cancel_reservation_button_bookinganddeleting.Text = "cancel Reservation";
            this.cancel_reservation_button_bookinganddeleting.UseVisualStyleBackColor = false;
            this.cancel_reservation_button_bookinganddeleting.Click += new System.EventHandler(this.cancel_reservation_button_bookinganddeleting_Click);
            // 
            // search_button_bokinganddeletingform
            // 
            this.search_button_bokinganddeletingform.BackColor = System.Drawing.Color.Chocolate;
            this.search_button_bokinganddeletingform.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button_bokinganddeletingform.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_button_bokinganddeletingform.Location = new System.Drawing.Point(223, 115);
            this.search_button_bokinganddeletingform.Name = "search_button_bokinganddeletingform";
            this.search_button_bokinganddeletingform.Size = new System.Drawing.Size(156, 73);
            this.search_button_bokinganddeletingform.TabIndex = 8;
            this.search_button_bokinganddeletingform.Text = "Search";
            this.search_button_bokinganddeletingform.UseVisualStyleBackColor = false;
            this.search_button_bokinganddeletingform.Click += new System.EventHandler(this.search_button_bokinganddeletingform_Click);
            // 
            // booking_and_deleting_choice_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(631, 419);
            this.Controls.Add(this.search_button_bokinganddeletingform);
            this.Controls.Add(this.cancel_reservation_button_bookinganddeleting);
            this.Controls.Add(this.reservation_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "booking_and_deleting_choice_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "booking_and_deleting_choice_form";
            this.Load += new System.EventHandler(this.booking_and_deleting_choice_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reservation_button;
        private System.Windows.Forms.Button cancel_reservation_button_bookinganddeleting;
        private System.Windows.Forms.Button search_button_bokinganddeletingform;
        private System.Windows.Forms.Label X_label;
    }
}