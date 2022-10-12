using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Trevago_project
{
    public partial class sign_up_form : Form
    {
        string gender;
        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        public sign_up_form()
        {
            InitializeComponent();
        }

        private void create_account_button_Click(object sender, EventArgs e)
        {
           
            if (female_radiobutton.Checked)
            {
                gender = "female";
            }
            else if (male_radiobutton.Checked)
            {
                gender = "male";
            }
            if (password_txtbox.Text == confirmpassword_txtbox.Text)
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cn1 = new OracleCommand();
                cn1.Connection = conn;
                cn1.CommandText = "insert into customer values (:f_n,:minitt,:thrd_name,:pho_num,:cntry,:e_mail,:userN,:psword,:agee,:gndr)";
                cn1.CommandType = CommandType.Text;
                cn1.Parameters.Add("f_n", firstname_txtbox.Text);
                cn1.Parameters.Add("minitt", secondname_txtbox.Text);
                cn1.Parameters.Add("thrd_name", thirdname_txtbox.Text);
                cn1.Parameters.Add("pho_num", phone_txtbox.Text);
                cn1.Parameters.Add("cntry", country_txtbox.Text);
                cn1.Parameters.Add("e_mail", email_txtbox.Text);
                cn1.Parameters.Add("userN", username_txtbox.Text);
                cn1.Parameters.Add("psword", password_txtbox.Text);
                cn1.Parameters.Add("agee", age_txtbox.Text);
                cn1.Parameters.Add("gndr", gender);
                int r = cn1.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("you are regestered");
                }
                conn.Close();
                login_form f = new login_form();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("the password isn,t confirmied");
            } 
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            login_form L = new login_form();
            L.Show();
            this.Hide();
        }

        private void firstname_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void confirmpassword_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstname_txtbox_Enter(object sender, EventArgs e)
        {
            string fname = firstname_txtbox.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                firstname_txtbox.Text = "";
                firstname_txtbox.ForeColor = Color.Black;
            }

        }

        private void firstname_txtbox_Leave(object sender, EventArgs e)
        {
            string fname = firstname_txtbox.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                firstname_txtbox.Text = "first name";
                firstname_txtbox.ForeColor = Color.Gray;
            }
        }

        private void secondname_txtbox_Enter(object sender, EventArgs e)
        {
            string fname = secondname_txtbox.Text;
            if (fname.ToLower().Trim().Equals("minit"))
            {
                secondname_txtbox.Text = "";
                secondname_txtbox.ForeColor = Color.Black;
            }
        }

        private void secondname_txtbox_Leave(object sender, EventArgs e)
        {
            string fname = secondname_txtbox.Text;
            if (fname.ToLower().Trim().Equals("minit") || fname.Trim().Equals(""))
            {
                secondname_txtbox.Text = "minit";
                secondname_txtbox.ForeColor = Color.Gray;
            }
        }

        private void thirdname_txtbox_Enter(object sender, EventArgs e)
        {
            string fname = thirdname_txtbox.Text;
            if (fname.ToLower().Trim().Equals("last name"))
            {
                thirdname_txtbox.Text = "";
                thirdname_txtbox.ForeColor = Color.Black;
            }
        }

        private void thirdname_txtbox_Leave(object sender, EventArgs e)
        {
            string fname = thirdname_txtbox.Text;
            if (fname.ToLower().Trim().Equals("third name") || fname.Trim().Equals(""))
            {
                thirdname_txtbox.Text = "third name";
                thirdname_txtbox.ForeColor = Color.Gray;
            }
        }

        private void phone_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_txtbox_Enter(object sender, EventArgs e)
        {
            string fname = phone_txtbox.Text;
            if (fname.ToLower().Trim().Equals("phone number"))
            {
                phone_txtbox.Text = "";
                phone_txtbox.ForeColor = Color.Black;
            }
        }

        private void phone_txtbox_Leave(object sender, EventArgs e)
        {
            string fname = phone_txtbox.Text;
            if (fname.ToLower().Trim().Equals("phone number") || fname.Trim().Equals(""))
            {
                phone_txtbox.Text = "phone number";
                phone_txtbox.ForeColor = Color.Gray;
            }
        }

        private void country_txtbox_Enter(object sender, EventArgs e)
        {
            string fname = country_txtbox.Text;
            if (fname.ToLower().Trim().Equals("country"))
            {
                country_txtbox.Text = "";
                country_txtbox.ForeColor = Color.Black;
            }
        }

        private void country_txtbox_Leave(object sender, EventArgs e)
        {
            string fname = country_txtbox.Text;
            if (fname.ToLower().Trim().Equals("country") || fname.Trim().Equals(""))
            {
                country_txtbox.Text = "country";
                country_txtbox.ForeColor = Color.Gray;
            }
        }

        private void email_txtbox_Enter(object sender, EventArgs e)
        {
            string fname = email_txtbox.Text;
            if (fname.ToLower().Trim().Equals("email"))
            {
                email_txtbox.Text = "";
                email_txtbox.ForeColor = Color.Black;
            }
        }

        private void email_txtbox_Leave(object sender, EventArgs e)
        {
            string fname = email_txtbox.Text;
            if (fname.ToLower().Trim().Equals("email") || fname.Trim().Equals(""))
            {
                email_txtbox.Text = "email";
                email_txtbox.ForeColor = Color.Gray;
            }
        }

        private void username_txtbox_Enter(object sender, EventArgs e)
        {
            string fname = username_txtbox.Text;
            if (fname.ToLower().Trim().Equals("username"))
            {
                username_txtbox.Text = "";
                username_txtbox.ForeColor = Color.Black;
            }
        }

        private void username_txtbox_Leave(object sender, EventArgs e)
        {
            string fname = username_txtbox.Text;
            if (fname.ToLower().Trim().Equals("username") || fname.Trim().Equals(""))
            {
                username_txtbox.Text = "username";
                username_txtbox.ForeColor = Color.Gray;
            }
        }

        private void password_txtbox_Enter(object sender, EventArgs e)
        {
            string fname = password_txtbox.Text;
            if (fname.ToLower().Trim().Equals("password"))
            {
                password_txtbox.Text = "";
                password_txtbox.UseSystemPasswordChar = true;
                password_txtbox.ForeColor = Color.Black;
            }
        }

        private void password_txtbox_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void confirmpassword_txtbox_Enter(object sender, EventArgs e)
        {
            string fname = confirmpassword_txtbox.Text;
            if (fname.ToLower().Trim().Equals("confirm password"))
            {
                confirmpassword_txtbox.Text = "";
                confirmpassword_txtbox.UseSystemPasswordChar = true;
                confirmpassword_txtbox.ForeColor = Color.Black;
            }
        }

        private void confirmpassword_txtbox_Leave(object sender, EventArgs e)
        {
            string fname = confirmpassword_txtbox.Text;
            if (fname.ToLower().Trim().Equals("confirm password") || fname.Trim().Equals(""))
            {
                confirmpassword_txtbox.Text = "confirm password";
                confirmpassword_txtbox.UseSystemPasswordChar = false;
                confirmpassword_txtbox.ForeColor = Color.Gray;
            }
        }

        private void age_txtbox_Enter(object sender, EventArgs e)
        {
            string fname = age_txtbox.Text;
            if (fname.ToLower().Trim().Equals("age"))
            {
                age_txtbox.Text = "";
                age_txtbox.ForeColor = Color.Black;
            }
        }

        private void age_txtbox_Leave(object sender, EventArgs e)
        {
            string fname = age_txtbox.Text;
            if (fname.ToLower().Trim().Equals("age") || fname.Trim().Equals(""))
            {
                age_txtbox.Text = "age";
                age_txtbox.ForeColor = Color.Gray;
            }
        }

        private void password_txtbox_Leave(object sender, EventArgs e)
        {
            string fname = password_txtbox.Text;
            if (fname.ToLower().Trim().Equals("password") || fname.Trim().Equals(""))
            {
                password_txtbox.Text = "passeord";
                password_txtbox.UseSystemPasswordChar = false;
                password_txtbox.ForeColor = Color.Gray;
            }
        }

        private void age_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void X_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thirdname_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void female_radiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
