namespace Trevago_project
{
    partial class sign_up_form
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
            this.create_account_button = new System.Windows.Forms.Button();
            this.age_txtbox = new System.Windows.Forms.TextBox();
            this.female_radiobutton = new System.Windows.Forms.RadioButton();
            this.male_radiobutton = new System.Windows.Forms.RadioButton();
            this.confirmpassword_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.country_txtbox = new System.Windows.Forms.TextBox();
            this.phone_txtbox = new System.Windows.Forms.TextBox();
            this.thirdname_txtbox = new System.Windows.Forms.TextBox();
            this.secondname_txtbox = new System.Windows.Forms.TextBox();
            this.firstname_txtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.X_label);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Script MT Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 89);
            this.panel1.TabIndex = 4;
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Font = new System.Drawing.Font("Akhbar MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.X_label.Location = new System.Drawing.Point(688, 8);
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
            this.back_button.Location = new System.Drawing.Point(12, 13);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(115, 40);
            this.back_button.TabIndex = 17;
            this.back_button.Text = "BacK";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(233, -27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 111);
            this.label2.TabIndex = 1;
            this.label2.Text = "trivago";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // create_account_button
            // 
            this.create_account_button.BackColor = System.Drawing.Color.Chocolate;
            this.create_account_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_account_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.create_account_button.Location = new System.Drawing.Point(59, 370);
            this.create_account_button.Name = "create_account_button";
            this.create_account_button.Size = new System.Drawing.Size(288, 57);
            this.create_account_button.TabIndex = 29;
            this.create_account_button.Text = "create account";
            this.create_account_button.UseVisualStyleBackColor = false;
            this.create_account_button.Click += new System.EventHandler(this.create_account_button_Click);
            // 
            // age_txtbox
            // 
            this.age_txtbox.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.age_txtbox.Location = new System.Drawing.Point(247, 322);
            this.age_txtbox.Name = "age_txtbox";
            this.age_txtbox.Size = new System.Drawing.Size(100, 26);
            this.age_txtbox.TabIndex = 28;
            this.age_txtbox.Text = "age";
            this.age_txtbox.TextChanged += new System.EventHandler(this.age_txtbox_TextChanged);
            this.age_txtbox.Enter += new System.EventHandler(this.age_txtbox_Enter);
            this.age_txtbox.Leave += new System.EventHandler(this.age_txtbox_Leave);
            // 
            // female_radiobutton
            // 
            this.female_radiobutton.AutoSize = true;
            this.female_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_radiobutton.ForeColor = System.Drawing.Color.Chocolate;
            this.female_radiobutton.Location = new System.Drawing.Point(140, 322);
            this.female_radiobutton.Name = "female_radiobutton";
            this.female_radiobutton.Size = new System.Drawing.Size(91, 29);
            this.female_radiobutton.TabIndex = 27;
            this.female_radiobutton.TabStop = true;
            this.female_radiobutton.Text = "female";
            this.female_radiobutton.UseVisualStyleBackColor = true;
            this.female_radiobutton.CheckedChanged += new System.EventHandler(this.female_radiobutton_CheckedChanged);
            // 
            // male_radiobutton
            // 
            this.male_radiobutton.AutoSize = true;
            this.male_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_radiobutton.ForeColor = System.Drawing.Color.Chocolate;
            this.male_radiobutton.Location = new System.Drawing.Point(59, 322);
            this.male_radiobutton.Name = "male_radiobutton";
            this.male_radiobutton.Size = new System.Drawing.Size(75, 29);
            this.male_radiobutton.TabIndex = 26;
            this.male_radiobutton.TabStop = true;
            this.male_radiobutton.Text = "male";
            this.male_radiobutton.UseVisualStyleBackColor = true;
            // 
            // confirmpassword_txtbox
            // 
            this.confirmpassword_txtbox.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassword_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.confirmpassword_txtbox.Location = new System.Drawing.Point(45, 279);
            this.confirmpassword_txtbox.Name = "confirmpassword_txtbox";
            this.confirmpassword_txtbox.Size = new System.Drawing.Size(312, 26);
            this.confirmpassword_txtbox.TabIndex = 25;
            this.confirmpassword_txtbox.Text = "confirm password";
            this.confirmpassword_txtbox.TextChanged += new System.EventHandler(this.confirmpassword_txtbox_TextChanged);
            this.confirmpassword_txtbox.Enter += new System.EventHandler(this.confirmpassword_txtbox_Enter);
            this.confirmpassword_txtbox.Leave += new System.EventHandler(this.confirmpassword_txtbox_Leave);
            // 
            // password_txtbox
            // 
            this.password_txtbox.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.password_txtbox.Location = new System.Drawing.Point(45, 251);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(312, 26);
            this.password_txtbox.TabIndex = 24;
            this.password_txtbox.Text = "password";
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            this.password_txtbox.VisibleChanged += new System.EventHandler(this.password_txtbox_VisibleChanged);
            this.password_txtbox.Enter += new System.EventHandler(this.password_txtbox_Enter);
            this.password_txtbox.Leave += new System.EventHandler(this.password_txtbox_Leave);
            // 
            // username_txtbox
            // 
            this.username_txtbox.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.username_txtbox.Location = new System.Drawing.Point(45, 223);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(312, 26);
            this.username_txtbox.TabIndex = 23;
            this.username_txtbox.Text = "username";
            this.username_txtbox.Enter += new System.EventHandler(this.username_txtbox_Enter);
            this.username_txtbox.Leave += new System.EventHandler(this.username_txtbox_Leave);
            // 
            // email_txtbox
            // 
            this.email_txtbox.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.email_txtbox.Location = new System.Drawing.Point(45, 195);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(312, 26);
            this.email_txtbox.TabIndex = 22;
            this.email_txtbox.Text = "email";
            this.email_txtbox.Enter += new System.EventHandler(this.email_txtbox_Enter);
            this.email_txtbox.Leave += new System.EventHandler(this.email_txtbox_Leave);
            // 
            // country_txtbox
            // 
            this.country_txtbox.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.country_txtbox.Location = new System.Drawing.Point(45, 167);
            this.country_txtbox.Name = "country_txtbox";
            this.country_txtbox.Size = new System.Drawing.Size(312, 26);
            this.country_txtbox.TabIndex = 21;
            this.country_txtbox.Text = "country";
            this.country_txtbox.Enter += new System.EventHandler(this.country_txtbox_Enter);
            this.country_txtbox.Leave += new System.EventHandler(this.country_txtbox_Leave);
            // 
            // phone_txtbox
            // 
            this.phone_txtbox.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.phone_txtbox.Location = new System.Drawing.Point(45, 139);
            this.phone_txtbox.Name = "phone_txtbox";
            this.phone_txtbox.Size = new System.Drawing.Size(312, 26);
            this.phone_txtbox.TabIndex = 20;
            this.phone_txtbox.Text = "phone number";
            this.phone_txtbox.TextChanged += new System.EventHandler(this.phone_txtbox_TextChanged);
            this.phone_txtbox.Enter += new System.EventHandler(this.phone_txtbox_Enter);
            this.phone_txtbox.Leave += new System.EventHandler(this.phone_txtbox_Leave);
            // 
            // thirdname_txtbox
            // 
            this.thirdname_txtbox.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdname_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.thirdname_txtbox.Location = new System.Drawing.Point(257, 111);
            this.thirdname_txtbox.Name = "thirdname_txtbox";
            this.thirdname_txtbox.Size = new System.Drawing.Size(100, 26);
            this.thirdname_txtbox.TabIndex = 17;
            this.thirdname_txtbox.Text = "last name";
            this.thirdname_txtbox.TextChanged += new System.EventHandler(this.thirdname_txtbox_TextChanged);
            this.thirdname_txtbox.Enter += new System.EventHandler(this.thirdname_txtbox_Enter);
            this.thirdname_txtbox.Leave += new System.EventHandler(this.thirdname_txtbox_Leave);
            // 
            // secondname_txtbox
            // 
            this.secondname_txtbox.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondname_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.secondname_txtbox.Location = new System.Drawing.Point(151, 111);
            this.secondname_txtbox.Name = "secondname_txtbox";
            this.secondname_txtbox.Size = new System.Drawing.Size(100, 26);
            this.secondname_txtbox.TabIndex = 18;
            this.secondname_txtbox.Text = "minit";
            this.secondname_txtbox.Enter += new System.EventHandler(this.secondname_txtbox_Enter);
            this.secondname_txtbox.Leave += new System.EventHandler(this.secondname_txtbox_Leave);
            // 
            // firstname_txtbox
            // 
            this.firstname_txtbox.Font = new System.Drawing.Font("Script MT Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.firstname_txtbox.Location = new System.Drawing.Point(45, 111);
            this.firstname_txtbox.Name = "firstname_txtbox";
            this.firstname_txtbox.Size = new System.Drawing.Size(100, 26);
            this.firstname_txtbox.TabIndex = 19;
            this.firstname_txtbox.Text = "first name";
            this.firstname_txtbox.TextChanged += new System.EventHandler(this.firstname_txtbox_TextChanged);
            this.firstname_txtbox.Enter += new System.EventHandler(this.firstname_txtbox_Enter);
            this.firstname_txtbox.Leave += new System.EventHandler(this.firstname_txtbox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Trevago_project.Properties.Resources.trivago3;
            this.pictureBox1.Location = new System.Drawing.Point(373, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // sign_up_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.create_account_button);
            this.Controls.Add(this.age_txtbox);
            this.Controls.Add(this.female_radiobutton);
            this.Controls.Add(this.male_radiobutton);
            this.Controls.Add(this.confirmpassword_txtbox);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.country_txtbox);
            this.Controls.Add(this.phone_txtbox);
            this.Controls.Add(this.thirdname_txtbox);
            this.Controls.Add(this.secondname_txtbox);
            this.Controls.Add(this.firstname_txtbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sign_up_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sign_up_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button create_account_button;
        private System.Windows.Forms.TextBox age_txtbox;
        private System.Windows.Forms.RadioButton female_radiobutton;
        private System.Windows.Forms.RadioButton male_radiobutton;
        private System.Windows.Forms.TextBox confirmpassword_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox country_txtbox;
        private System.Windows.Forms.TextBox phone_txtbox;
        private System.Windows.Forms.TextBox thirdname_txtbox;
        private System.Windows.Forms.TextBox secondname_txtbox;
        private System.Windows.Forms.TextBox firstname_txtbox;
        private System.Windows.Forms.Label X_label;
    }
}