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
    public partial class reservation_username : Form
    {
        public string customer_username = login_form.ussername;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        public reservation_username()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void reservation_username_Load(object sender, EventArgs e)
        {
            reservation_username_txtbox.Text = customer_username;
        }

        private void X_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reserved_button_Click(object sender, EventArgs e)
        {
            int max_number, new_number;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn1 = new OracleCommand();
            cn1.Connection = conn;
            cn1.CommandText = "Get_reservation_id";
            cn1.CommandType = CommandType.StoredProcedure;
            cn1.Parameters.Add("number", OracleDbType.Int32, ParameterDirection.Output);
            cn1.ExecuteNonQuery();
            try
            {
                max_number = Convert.ToInt32(cn1.Parameters["number"].Value.ToString());
                new_number = max_number + 1;
            }
            catch
            {
                new_number = 1;
            }
            OracleCommand cn2 = new OracleCommand();
            cn2.Connection = conn;
            cn2.CommandText = "select room_num from room where hotel_id =:h_id and room_type =:r_t and num_of_beds =:n_o_b and free =:f";
            cn2.CommandType = CommandType.Text;
            cn2.Parameters.Add("h_id", reservation_hotel_id_txtbox.Text);
            cn2.Parameters.Add("r_t", room_type_combobox.SelectedItem.ToString());
            cn2.Parameters.Add("n_o_b", num_of_beds_txtbox.Text);
            cn2.Parameters.Add("f", "yes");
            OracleDataReader dr1 = cn2.ExecuteReader();
            if (dr1.Read())
            {
                OracleCommand cn5 = new OracleCommand();
                cn5.Connection = conn;
                cn5.CommandText = "insert into reservation values (:RES_ID,:HOTELL_ID,:NAME_USER,:PERIOD,:START_DATE,:END_DATE,:ROOM_NUMBER)";
                cn5.CommandType = CommandType.Text;
                cn5.Parameters.Add("RES_ID", new_number);
                cn5.Parameters.Add("HOTELL_ID", Convert.ToInt32(reservation_hotel_id_txtbox.Text));
                cn5.Parameters.Add("NAME_USER", reservation_username_txtbox.Text);
                cn5.Parameters.Add("PERIOD", Convert.ToInt32(period_txtbox.Text));
                cn5.Parameters.Add("START_DATE", Convert.ToDateTime(start_date_txtbox.Text));
                cn5.Parameters.Add("END_DATE", Convert.ToDateTime(end_date_txtbox.Text));
                cn5.Parameters.Add("ROOM_NUMBER", Convert.ToInt32(dr1[0]));
                int r = cn5.ExecuteNonQuery();
                if(r!=-1)
                {
                    MessageBox.Show("your room is reserved successfully");
                }
            }
            else
            {
                MessageBox.Show("sorry this room is not available ");
            }
            conn.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void view_hotel_tx_box_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=ORCL;User Id=hr;password=hr;";
            string cmbstr = "select * from hotles";
            adapter = new OracleDataAdapter(cmbstr, connstr);
            ds = new DataSet();
            adapter.Fill(ds);
            reservation_dataGridView.DataSource = ds.Tables[0];
        }

        private void view_room_txttbox_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=ORCL;User Id=hr;password=hr;";
            string cmbstr = "select * from room";
            adapter = new OracleDataAdapter(cmbstr, connstr);
            ds = new DataSet();
            adapter.Fill(ds);
            reservation_dataGridView.DataSource = ds.Tables[0];

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reservation_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
