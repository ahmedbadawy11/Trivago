namespace Trevago_project
{
    partial class room_form
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
            this.room_number_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_f_beds = new System.Windows.Forms.TextBox();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.room_number_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.type_combobox = new System.Windows.Forms.ComboBox();
            this.rate_combobox = new System.Windows.Forms.ComboBox();
            this.free_yes_rb = new System.Windows.Forms.RadioButton();
            this.free_no_rb = new System.Windows.Forms.RadioButton();
            this.deleteroom_button = new System.Windows.Forms.Button();
            this.updateroom_button = new System.Windows.Forms.Button();
            this.addroom_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.hote_id_txttbox = new System.Windows.Forms.TextBox();
            this.room_form_dataGridView = new System.Windows.Forms.DataGridView();
            this.display_room_button = new System.Windows.Forms.Button();
            this.last_room_button = new System.Windows.Forms.Button();
            this.display_room_details_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.select_room_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_form_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.X_label);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 80);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Font = new System.Drawing.Font("Akhbar MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.X_label.Location = new System.Drawing.Point(1091, 11);
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
            this.label2.Location = new System.Drawing.Point(333, -31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 111);
            this.label2.TabIndex = 1;
            this.label2.Text = "trivago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // room_number_label
            // 
            this.room_number_label.AutoSize = true;
            this.room_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_number_label.ForeColor = System.Drawing.Color.Chocolate;
            this.room_number_label.Location = new System.Drawing.Point(44, 127);
            this.room_number_label.Name = "room_number_label";
            this.room_number_label.Size = new System.Drawing.Size(138, 25);
            this.room_number_label.TabIndex = 2;
            this.room_number_label.Text = "room number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(44, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(44, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "number of beds";
            // 
            // num_f_beds
            // 
            this.num_f_beds.Location = new System.Drawing.Point(245, 198);
            this.num_f_beds.Name = "num_f_beds";
            this.num_f_beds.Size = new System.Drawing.Size(209, 22);
            this.num_f_beds.TabIndex = 5;
            // 
            // price_txtbox
            // 
            this.price_txtbox.Location = new System.Drawing.Point(245, 160);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(209, 22);
            this.price_txtbox.TabIndex = 6;
            this.price_txtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // room_number_txtbox
            // 
            this.room_number_txtbox.Location = new System.Drawing.Point(245, 127);
            this.room_number_txtbox.Name = "room_number_txtbox";
            this.room_number_txtbox.Size = new System.Drawing.Size(209, 22);
            this.room_number_txtbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(43, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(43, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Chocolate;
            this.label6.Location = new System.Drawing.Point(44, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "free";
            // 
            // type_combobox
            // 
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.Items.AddRange(new object[] {
            "double",
            "familiy",
            "single"});
            this.type_combobox.Location = new System.Drawing.Point(245, 239);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(121, 24);
            this.type_combobox.TabIndex = 11;
            // 
            // rate_combobox
            // 
            this.rate_combobox.FormattingEnabled = true;
            this.rate_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rate_combobox.Location = new System.Drawing.Point(245, 282);
            this.rate_combobox.Name = "rate_combobox";
            this.rate_combobox.Size = new System.Drawing.Size(121, 24);
            this.rate_combobox.TabIndex = 12;
            // 
            // free_yes_rb
            // 
            this.free_yes_rb.AutoSize = true;
            this.free_yes_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.free_yes_rb.ForeColor = System.Drawing.Color.Chocolate;
            this.free_yes_rb.Location = new System.Drawing.Point(245, 326);
            this.free_yes_rb.Name = "free_yes_rb";
            this.free_yes_rb.Size = new System.Drawing.Size(67, 29);
            this.free_yes_rb.TabIndex = 13;
            this.free_yes_rb.TabStop = true;
            this.free_yes_rb.Text = "yes";
            this.free_yes_rb.UseVisualStyleBackColor = true;
            // 
            // free_no_rb
            // 
            this.free_no_rb.AutoSize = true;
            this.free_no_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.free_no_rb.ForeColor = System.Drawing.Color.Chocolate;
            this.free_no_rb.Location = new System.Drawing.Point(318, 326);
            this.free_no_rb.Name = "free_no_rb";
            this.free_no_rb.Size = new System.Drawing.Size(57, 29);
            this.free_no_rb.TabIndex = 14;
            this.free_no_rb.TabStop = true;
            this.free_no_rb.Text = "no";
            this.free_no_rb.UseVisualStyleBackColor = true;
            // 
            // deleteroom_button
            // 
            this.deleteroom_button.BackColor = System.Drawing.Color.Chocolate;
            this.deleteroom_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteroom_button.Location = new System.Drawing.Point(354, 371);
            this.deleteroom_button.Name = "deleteroom_button";
            this.deleteroom_button.Size = new System.Drawing.Size(220, 49);
            this.deleteroom_button.TabIndex = 16;
            this.deleteroom_button.Text = "delete";
            this.deleteroom_button.UseVisualStyleBackColor = false;
            this.deleteroom_button.Click += new System.EventHandler(this.deleteroom_button_Click);
            // 
            // updateroom_button
            // 
            this.updateroom_button.BackColor = System.Drawing.Color.Chocolate;
            this.updateroom_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateroom_button.Location = new System.Drawing.Point(648, 371);
            this.updateroom_button.Name = "updateroom_button";
            this.updateroom_button.Size = new System.Drawing.Size(221, 49);
            this.updateroom_button.TabIndex = 17;
            this.updateroom_button.Text = "update";
            this.updateroom_button.UseVisualStyleBackColor = false;
            this.updateroom_button.Click += new System.EventHandler(this.updateroom_button_Click);
            // 
            // addroom_button
            // 
            this.addroom_button.BackColor = System.Drawing.Color.Chocolate;
            this.addroom_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addroom_button.Location = new System.Drawing.Point(37, 371);
            this.addroom_button.Name = "addroom_button";
            this.addroom_button.Size = new System.Drawing.Size(224, 49);
            this.addroom_button.TabIndex = 18;
            this.addroom_button.Text = "add";
            this.addroom_button.UseVisualStyleBackColor = false;
            this.addroom_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(44, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "hotel id";
            // 
            // hote_id_txttbox
            // 
            this.hote_id_txttbox.Location = new System.Drawing.Point(245, 93);
            this.hote_id_txttbox.Name = "hote_id_txttbox";
            this.hote_id_txttbox.Size = new System.Drawing.Size(209, 22);
            this.hote_id_txttbox.TabIndex = 20;
            this.hote_id_txttbox.TextChanged += new System.EventHandler(this.hote_id_txttbox_TextChanged);
            // 
            // room_form_dataGridView
            // 
            this.room_form_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.room_form_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.room_form_dataGridView.Location = new System.Drawing.Point(472, 137);
            this.room_form_dataGridView.Name = "room_form_dataGridView";
            this.room_form_dataGridView.RowHeadersWidth = 51;
            this.room_form_dataGridView.RowTemplate.Height = 24;
            this.room_form_dataGridView.Size = new System.Drawing.Size(595, 228);
            this.room_form_dataGridView.TabIndex = 21;
            // 
            // display_room_button
            // 
            this.display_room_button.BackColor = System.Drawing.Color.Chocolate;
            this.display_room_button.Font = new System.Drawing.Font("Script MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_room_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display_room_button.Location = new System.Drawing.Point(472, 87);
            this.display_room_button.Name = "display_room_button";
            this.display_room_button.Size = new System.Drawing.Size(138, 40);
            this.display_room_button.TabIndex = 22;
            this.display_room_button.Text = "display Room";
            this.display_room_button.UseVisualStyleBackColor = false;
            this.display_room_button.Click += new System.EventHandler(this.display_room_button_Click);
            // 
            // last_room_button
            // 
            this.last_room_button.BackColor = System.Drawing.Color.Chocolate;
            this.last_room_button.Font = new System.Drawing.Font("Script MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_room_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.last_room_button.Location = new System.Drawing.Point(616, 87);
            this.last_room_button.Name = "last_room_button";
            this.last_room_button.Size = new System.Drawing.Size(145, 41);
            this.last_room_button.TabIndex = 23;
            this.last_room_button.Text = "last Room";
            this.last_room_button.UseVisualStyleBackColor = false;
            this.last_room_button.Click += new System.EventHandler(this.last_room_button_Click);
            // 
            // display_room_details_button
            // 
            this.display_room_details_button.BackColor = System.Drawing.Color.Chocolate;
            this.display_room_details_button.Font = new System.Drawing.Font("Script MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_room_details_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display_room_details_button.Location = new System.Drawing.Point(890, 377);
            this.display_room_details_button.Name = "display_room_details_button";
            this.display_room_details_button.Size = new System.Drawing.Size(167, 35);
            this.display_room_details_button.TabIndex = 25;
            this.display_room_details_button.Text = "display Room details";
            this.display_room_details_button.UseVisualStyleBackColor = false;
            this.display_room_details_button.Click += new System.EventHandler(this.display_room_details_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Akhbar MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1038, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 39);
            this.label8.TabIndex = 35;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // select_room_button
            // 
            this.select_room_button.BackColor = System.Drawing.Color.Chocolate;
            this.select_room_button.Font = new System.Drawing.Font("Script MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_room_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.select_room_button.Location = new System.Drawing.Point(767, 87);
            this.select_room_button.Name = "select_room_button";
            this.select_room_button.Size = new System.Drawing.Size(145, 41);
            this.select_room_button.TabIndex = 26;
            this.select_room_button.Text = "select Room";
            this.select_room_button.UseVisualStyleBackColor = false;
            this.select_room_button.Click += new System.EventHandler(this.first_room_button_Click);
            // 
            // room_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.select_room_button);
            this.Controls.Add(this.display_room_details_button);
            this.Controls.Add(this.last_room_button);
            this.Controls.Add(this.display_room_button);
            this.Controls.Add(this.room_form_dataGridView);
            this.Controls.Add(this.hote_id_txttbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addroom_button);
            this.Controls.Add(this.updateroom_button);
            this.Controls.Add(this.deleteroom_button);
            this.Controls.Add(this.free_no_rb);
            this.Controls.Add(this.free_yes_rb);
            this.Controls.Add(this.rate_combobox);
            this.Controls.Add(this.type_combobox);
            this.Controls.Add(this.room_number_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_txtbox);
            this.Controls.Add(this.num_f_beds);
            this.Controls.Add(this.room_number_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "room_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "room_form";
            this.Load += new System.EventHandler(this.room_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_form_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label room_number_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_f_beds;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.TextBox room_number_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox type_combobox;
        private System.Windows.Forms.ComboBox rate_combobox;
        private System.Windows.Forms.RadioButton free_yes_rb;
        private System.Windows.Forms.RadioButton free_no_rb;
        private System.Windows.Forms.Button deleteroom_button;
        private System.Windows.Forms.Button updateroom_button;
        private System.Windows.Forms.Button addroom_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hote_id_txttbox;
        private System.Windows.Forms.DataGridView room_form_dataGridView;
        private System.Windows.Forms.Button display_room_button;
        private System.Windows.Forms.Button last_room_button;
        private System.Windows.Forms.Button display_room_details_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button select_room_button;
    }
}