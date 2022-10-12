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
    public partial class room_form : Form
    {
        string free;
        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        public room_form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (free_no_rb.Checked)
            {
                free = "no";
            }
            else if (free_yes_rb.Checked)
            {
                free = "yes";
            }
            int max_number,new_number;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn1 = new OracleCommand();
            cn1.Connection = conn;
            cn1.CommandText = "Get_room_number";
            cn1.CommandType = CommandType.StoredProcedure;
            cn1.Parameters.Add("number",OracleDbType.Int32,ParameterDirection.Output);
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
            cn2.CommandText = "INSERT_ROOM";
            cn2.CommandType = CommandType.StoredProcedure;
            cn2.Parameters.Add("r_n", new_number);
            cn2.Parameters.Add("r_type", type_combobox.SelectedItem.ToString());
            cn2.Parameters.Add("r_ate", rate_combobox.SelectedItem.ToString());
            cn2.Parameters.Add("pric", price_txtbox.Text);
            cn2.Parameters.Add("numb_of_beds", num_f_beds.Text);
            cn2.Parameters.Add("f_ree", free);
            cn2.Parameters.Add("h_id",hote_id_txttbox.Text);
            cn2.ExecuteNonQuery();
                MessageBox.Show("room is added succesfully");
            conn.Close();
            hote_id_txttbox.Text = "";
            room_number_txtbox.Text = "";
            price_txtbox.Text = "";
            num_f_beds.Text = "";
            type_combobox.Text = "";
            rate_combobox.Text = "";
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            admin_form L = new admin_form();
            L.Show();
            this.Hide();
        }

        private void X_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateroom_button_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            if (free_no_rb.Checked)
            {
                free = "no";
            }
            else if (free_yes_rb.Checked)
            {
                free = "yes";
            }
            OracleCommand cn3 = new OracleCommand();
            cn3.Connection = conn;
            cn3.CommandText = "UPDATE__ROOM";
            cn3.CommandType = CommandType.StoredProcedure;
            cn3.Parameters.Add("room_number",Int16.Parse(room_number_txtbox.Text));
            cn3.Parameters.Add("room_typ", type_combobox.SelectedItem.ToString());
            cn3.Parameters.Add("r_ate", Int16.Parse(rate_combobox.SelectedItem.ToString()));
            cn3.Parameters.Add("p_rice", Int16.Parse(price_txtbox.Text));
            cn3.Parameters.Add("num_of_beds",Int16.Parse( num_f_beds.Text));
            cn3.Parameters.Add("f_ree", free);
            cn3.ExecuteNonQuery();
            MessageBox.Show("room is updated succesfully");
            conn.Close();
            hote_id_txttbox.Text = "";
            room_number_txtbox.Text = "";
            price_txtbox.Text = "";
            num_f_beds.Text = "";
            type_combobox.Text = "";
            rate_combobox.Text = "";
        }

        private void deleteroom_button_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            if (free_no_rb.Checked)
            {
                free = "no";
            }
            else if (free_yes_rb.Checked)
            {
                free = "yes";
            }
            OracleCommand cn2 = new OracleCommand();
            cn2.Connection = conn;
            cn2.CommandText = "DELETE_ROOM";
            cn2.CommandType = CommandType.StoredProcedure;
            cn2.Parameters.Add("r_n", room_number_txtbox.Text);
            cn2.ExecuteNonQuery();
            MessageBox.Show("room is deleted succesfully");
            conn.Close();
            hote_id_txttbox.Text = "";
            room_number_txtbox.Text = "";
            price_txtbox.Text = "";
            num_f_beds.Text = "";
            type_combobox.Text = "";
            rate_combobox.Text = "";
        }

        private void display_room_button_Click(object sender, EventArgs e)
        {
            room_form_dataGridView.DataSource = get_room();

        }
        private DataTable get_room()
        {
            DataTable rooms= new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn3 = new OracleCommand();
            cn3.Connection = conn;
            cn3.CommandText = "display__room";
            cn3.CommandType = CommandType.StoredProcedure;
            cn3.Parameters.Add("f", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cn3.ExecuteReader();
            rooms.Load(dr);
            return rooms;
        }

        private void last_room_button_Click(object sender, EventArgs e)
        {
            room_form_dataGridView.DataSource = last_room();
        }
        private DataTable last_room()
        {
            DataTable rooms = new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn3 = new OracleCommand();
            cn3.Connection = conn;
            cn3.CommandText = "select max(room_num) from room ";
            cn3.CommandType = CommandType.Text;
            OracleDataReader dr = cn3.ExecuteReader();
            rooms.Load(dr);
            return rooms;
        }

        private void hote_id_txttbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void r_o_spec_hotel_button_Click(object sender, EventArgs e)
        {
  
        }
       

        private void display_room_details_button_Click(object sender, EventArgs e)
        {
            OracleCommand cn2 = new OracleCommand();
            cn2.Connection = conn;
            cn2.CommandText = "select * from room where room_num = :r_n";
            cn2.CommandType = CommandType.Text;
            cn2.Parameters.Add("r_n", room_number_txtbox.Text);
            OracleDataReader dr1 = cn2.ExecuteReader();
            if(dr1.Read())
            {
                type_combobox.Text =dr1[0].ToString();
                rate_combobox.Text = dr1[1].ToString();
                price_txtbox.Text = dr1[2].ToString();
                num_f_beds.Text = dr1[3].ToString();
                if (dr1[4].ToString().Equals("yes"))
                {
                    free_yes_rb.Select();
                }
                else
                {
                    free_no_rb.Select();
                }
                hote_id_txttbox.Text = dr1[5].ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void room_form_Load(object sender, EventArgs e)
        {

        }

        private void first_room_button_Click(object sender, EventArgs e)
        {
            OracleCommand cn2 = new OracleCommand();
            cn2.Connection = conn;
            cn2.CommandText = "first_room";
            cn2.CommandType = CommandType.StoredProcedure;
            cn2.Parameters.Add("r_num", room_number_txtbox.Text);
            cn2.Parameters.Add("r_t", OracleDbType.Varchar2,ParameterDirection.Output);
            cn2.Parameters.Add("r", OracleDbType.Int32, ParameterDirection.Output);
            cn2.Parameters.Add("p", OracleDbType.Int32, ParameterDirection.Output);
            cn2.Parameters.Add("b", OracleDbType.Int32, ParameterDirection.Output);
            cn2.Parameters.Add("f", OracleDbType.Varchar2, ParameterDirection.Output);
            cn2.Parameters.Add("h", OracleDbType.Int32, ParameterDirection.Output);
            cn2.ExecuteNonQuery();
            try
            {
                type_combobox.Text = cn2.Parameters["r_t"].Value.ToString();
                rate_combobox.Text = cn2.Parameters["r"].Value.ToString();
                price_txtbox.Text = cn2.Parameters["p"].Value.ToString();
                num_f_beds.Text = cn2.Parameters["b"].Value.ToString();
                if (cn2.Parameters["f"].Value.ToString().Equals("yes"))
                {
                    free_yes_rb.Text = cn2.Parameters["f"].Value.ToString();
                }
                else
                {
                    free_no_rb.Text = cn2.Parameters["f"].Value.ToString();
                }
                hote_id_txttbox.Text =cn2.Parameters["h"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("the room dosent exisist");
            }
        }
    }
}
