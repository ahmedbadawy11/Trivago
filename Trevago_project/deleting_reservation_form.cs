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

    public partial class deleting_reservation_form : Form
    {
        public string customer_username = login_form.ussername;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        public deleting_reservation_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            if (customer_username.Equals("mohahmed"))
            {
                admin_form L = new admin_form();
                L.Show();
                this.Hide();
            }
            else
            {
                booking_and_deleting_choice_form L = new booking_and_deleting_choice_form();
                L.Show();
                this.Hide();
            }
        }

        private void X_label_Click(object sender, EventArgs e)
        {

        }

        private void X_label_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleting_reservation_form_Load(object sender, EventArgs e)
        {
            cancel_res_username_textBox.Text = customer_username;
        }

        private void show_res_button_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=ORCL;User Id=hr;password=hr;";
            string cmbstr = "select * from reservation where name_user = :useername";
            adapter = new OracleDataAdapter(cmbstr, connstr);
            adapter.SelectCommand.Parameters.Add("useername", cancel_res_username_textBox.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            deleting_res_dataGridView.DataSource = ds.Tables[0];
        }

        private void delete_reservation_button_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn4 = new OracleCommand();
            cn4.Connection = conn;
            cn4.CommandText = "select room_number from reservation where name_user=:r_nu";
            cn4.CommandType = CommandType.Text;
            cn4.Parameters.Add("r_nu", cancel_res_username_textBox.Text);
            OracleDataReader dr1 = cn4.ExecuteReader();
            if (dr1.Read())
            {
                OracleCommand cn1 = new OracleCommand();
                cn1.Connection = conn;
                cn1.CommandText = "update room set free=:y where room_num=:r_n";
                cn1.Parameters.Add("free", "yes");
                cn1.Parameters.Add("r_n", Convert.ToInt32(dr1[0]));
                cn1.ExecuteNonQuery();
                OracleCommand cn2 = new OracleCommand();
                cn2.Connection = conn;
                cn2.CommandText = "delete from reservation where name_user=:n_u";
                cn2.CommandType = CommandType.Text;
                cn2.Parameters.Add("n_u", cancel_res_username_textBox.Text);
                int r = cn2.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("reservation is deleted successfuly");
                }
            }
            conn.Close();
        }
    }
}
