namespace Trevago_project
{
    partial class report1
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.report1_button = new System.Windows.Forms.Button();
            this.report2_button = new System.Windows.Forms.Button();
            this.report3_combobox = new System.Windows.Forms.Button();
            this.startdate_comboBox = new System.Windows.Forms.ComboBox();
            this.roomtype_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(35, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(983, 385);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // report1_button
            // 
            this.report1_button.BackColor = System.Drawing.Color.Chocolate;
            this.report1_button.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report1_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.report1_button.Location = new System.Drawing.Point(35, 441);
            this.report1_button.Name = "report1_button";
            this.report1_button.Size = new System.Drawing.Size(237, 37);
            this.report1_button.TabIndex = 15;
            this.report1_button.Text = "Report 1";
            this.report1_button.UseVisualStyleBackColor = false;
            this.report1_button.Click += new System.EventHandler(this.hotel_report_button_Click);
            // 
            // report2_button
            // 
            this.report2_button.BackColor = System.Drawing.Color.Chocolate;
            this.report2_button.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report2_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.report2_button.Location = new System.Drawing.Point(404, 441);
            this.report2_button.Name = "report2_button";
            this.report2_button.Size = new System.Drawing.Size(237, 37);
            this.report2_button.TabIndex = 16;
            this.report2_button.Text = "Report 2";
            this.report2_button.UseVisualStyleBackColor = false;
            this.report2_button.Click += new System.EventHandler(this.report2_button_Click);
            // 
            // report3_combobox
            // 
            this.report3_combobox.BackColor = System.Drawing.Color.Chocolate;
            this.report3_combobox.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report3_combobox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.report3_combobox.Location = new System.Drawing.Point(764, 441);
            this.report3_combobox.Name = "report3_combobox";
            this.report3_combobox.Size = new System.Drawing.Size(237, 37);
            this.report3_combobox.TabIndex = 17;
            this.report3_combobox.Text = "Report 3";
            this.report3_combobox.UseVisualStyleBackColor = false;
            this.report3_combobox.Click += new System.EventHandler(this.button1_Click);
            // 
            // startdate_comboBox
            // 
            this.startdate_comboBox.FormattingEnabled = true;
            this.startdate_comboBox.Location = new System.Drawing.Point(880, 411);
            this.startdate_comboBox.Name = "startdate_comboBox";
            this.startdate_comboBox.Size = new System.Drawing.Size(121, 24);
            this.startdate_comboBox.TabIndex = 18;
            // 
            // roomtype_comboBox
            // 
            this.roomtype_comboBox.FormattingEnabled = true;
            this.roomtype_comboBox.Location = new System.Drawing.Point(520, 411);
            this.roomtype_comboBox.Name = "roomtype_comboBox";
            this.roomtype_comboBox.Size = new System.Drawing.Size(121, 24);
            this.roomtype_comboBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(774, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "start date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(411, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Room type";
            // 
            // report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1071, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomtype_comboBox);
            this.Controls.Add(this.startdate_comboBox);
            this.Controls.Add(this.report3_combobox);
            this.Controls.Add(this.report2_button);
            this.Controls.Add(this.report1_button);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "report1";
            this.Text = "report1";
            this.Load += new System.EventHandler(this.report1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button report1_button;
        private System.Windows.Forms.Button report2_button;
        private System.Windows.Forms.Button report3_combobox;
        private System.Windows.Forms.ComboBox startdate_comboBox;
        private System.Windows.Forms.ComboBox roomtype_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}