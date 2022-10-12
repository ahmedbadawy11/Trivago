namespace Trevago_project
{
    partial class country
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
            this.country_dataGridView = new System.Windows.Forms.DataGridView();
            this.country_cb = new System.Windows.Forms.ComboBox();
            this.hotels_combobox = new System.Windows.Forms.ComboBox();
            this.load_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.country_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.X_label);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 99);
            this.panel1.TabIndex = 10;
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Font = new System.Drawing.Font("Akhbar MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.X_label.Location = new System.Drawing.Point(751, 10);
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
            this.back_button.Location = new System.Drawing.Point(11, 13);
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
            this.label2.Location = new System.Drawing.Point(204, -12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 111);
            this.label2.TabIndex = 1;
            this.label2.Text = "trivago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // country_dataGridView
            // 
            this.country_dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.country_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.country_dataGridView.Location = new System.Drawing.Point(11, 146);
            this.country_dataGridView.Name = "country_dataGridView";
            this.country_dataGridView.RowHeadersWidth = 51;
            this.country_dataGridView.RowTemplate.Height = 24;
            this.country_dataGridView.Size = new System.Drawing.Size(768, 268);
            this.country_dataGridView.TabIndex = 11;
            this.country_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.country_dataGridView_CellContentClick);
            // 
            // country_cb
            // 
            this.country_cb.FormattingEnabled = true;
            this.country_cb.Location = new System.Drawing.Point(12, 116);
            this.country_cb.Name = "country_cb";
            this.country_cb.Size = new System.Drawing.Size(190, 24);
            this.country_cb.TabIndex = 12;
            this.country_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // hotels_combobox
            // 
            this.hotels_combobox.FormattingEnabled = true;
            this.hotels_combobox.Location = new System.Drawing.Point(562, 116);
            this.hotels_combobox.Name = "hotels_combobox";
            this.hotels_combobox.Size = new System.Drawing.Size(201, 24);
            this.hotels_combobox.TabIndex = 13;
            this.hotels_combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // load_button
            // 
            this.load_button.BackColor = System.Drawing.Color.Chocolate;
            this.load_button.Font = new System.Drawing.Font("Script MT Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.load_button.Location = new System.Drawing.Point(421, 109);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(135, 31);
            this.load_button.TabIndex = 14;
            this.load_button.Text = "load hotel";
            this.load_button.UseVisualStyleBackColor = false;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.hotels_combobox);
            this.Controls.Add(this.country_cb);
            this.Controls.Add(this.country_dataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "country";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "country";
            this.Load += new System.EventHandler(this.country_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.country_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView country_dataGridView;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.ComboBox country_cb;
        private System.Windows.Forms.ComboBox hotels_combobox;
        private System.Windows.Forms.Button load_button;
    }
}