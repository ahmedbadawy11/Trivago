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
    public partial class login_form : Form
    {
        public static string ussername= null;
        public static int id = 0;

        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        public login_form()
        {
            InitializeComponent();
        }

        private void newuser_button_Click(object sender, EventArgs e)
        {
            sign_up_form S = new sign_up_form();
            S.Show();
            this.Hide();
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn1 = new OracleCommand();
            cn1.Connection = conn;
            cn1.CommandText = "select * from customer where username=:name and password =:pass";
            cn1.CommandType = CommandType.Text;
            cn1.Parameters.Add("name", name_txtbox.Text);
            cn1.Parameters.Add("pass",password_txtbox.Text);
            OracleDataReader dr1 = cn1.ExecuteReader();
            if (dr1.Read())
            {
                ussername = name_txtbox.Text;
                booking_and_deleting_choice_form a = new booking_and_deleting_choice_form();
                a.ShowDialog();
                this.Hide();

            }
            else
            {
               
                OracleCommand cn2 = new OracleCommand();
                cn2.Connection = conn;
                cn2.CommandText = "select * from adminn where user__name=:name and admin_id =:pass";
                cn2.CommandType = CommandType.Text;
                cn2.Parameters.Add("name", name_txtbox.Text);
                cn2.Parameters.Add("pass", password_txtbox.Text);
                OracleDataReader dr2 = cn2.ExecuteReader();
                if (dr2.Read())
                {
                    ussername = name_txtbox.Text;
                    admin_form a = new admin_form();
                    a.ShowDialog();
                    this.Hide();
                  
              
                }
                else
                {
                    MessageBox.Show("wrong username or password please try again if you have an account if you don't please create one");
                }
                dr2.Close();
            }
            dr1.Close();
            conn.Close();
            
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
          
        }

        private void X_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
