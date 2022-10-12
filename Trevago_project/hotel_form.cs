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
    public partial class hotel_form : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        public hotel_form()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hotel_form_Load(object sender, EventArgs e)
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

        private void addhotel_button_Click(object sender, EventArgs e)
        {
            int max_number, new_number;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn4 = new OracleCommand();
            cn4.Connection = conn;
            cn4.CommandText = "get_hotel_id";
            cn4.CommandType = CommandType.StoredProcedure;
            cn4.Parameters.Add("number", OracleDbType.Int32, ParameterDirection.Output);
            cn4.ExecuteNonQuery();
            try
            {
                max_number = Convert.ToInt32(cn4.Parameters["number"].Value.ToString());
                new_number = max_number + 1;
            }
            catch
            {
                new_number = 1;
            }
            OracleCommand cn1 = new OracleCommand();
            cn1.Connection = conn;
            cn1.CommandText = "insert into hotles values (:h_id,:h_name,:lndmrk,:loction,:h_description,:ra_te,:web_id,:admin_id)";
            cn1.CommandType = CommandType.Text;
            cn1.Parameters.Add("h_id", new_number);
            cn1.Parameters.Add("h_name", textBoxhotelname_txtbox.Text);
            cn1.Parameters.Add("lndmrk", landmard_txtbox.Text);
            cn1.Parameters.Add("loction", location_txtbox.Text);
            cn1.Parameters.Add("h_description", hoteldiscription_txtbox.Text);
            cn1.Parameters.Add("ra_te",rate_combobox.SelectedItem.ToString());
            cn1.Parameters.Add("web_id", website_id_txtbox.Text);
            cn1.Parameters.Add("admin_id",1);
            int r = cn1.ExecuteNonQuery();
            if (r != -1)
            {
                //points of intrest
                OracleCommand cn3 = new OracleCommand();
                cn3.Connection = conn;
                cn3.CommandText = "insert into POINTS_OF_INTREST values (:p_o_i,:h_id)";
                cn3.CommandType = CommandType.Text;
                cn3.Parameters.Add("p_o_i", pointsofintrest_txtbox.Text);
                cn3.Parameters.Add("h_id", new_number);
                int r2 = cn3.ExecuteNonQuery();
                if (r2 != -1)
                {
                    MessageBox.Show("hotel is added succesfully");
                }
            }
      
            conn.Close();
            textBoxhotelname_txtbox.Text = "";
            landmard_txtbox.Text = "";
            location_txtbox.Text = "";
            pointsofintrest_txtbox.Text = "";
            hoteldiscription_txtbox.Text = "";
            website_id_txtbox.Text = "";
            hotl_id_txtbox.Text = "";
            rate_combobox.SelectedItem = null;
        }

        private void add_websitename_button_Click(object sender, EventArgs e)
        {
           
        }

        private void deletehotel_button_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            //points of intrest
            OracleCommand cn3 = new OracleCommand();
            cn3.Connection = conn;
            cn3.CommandText = "delete from POINTS_OF_INTREST where hotel_id =:h_id";
            cn3.CommandType = CommandType.Text;
            cn3.Parameters.Add("h_id",Convert.ToInt32( hotl_id_txtbox.Text));
            int r2 = cn3.ExecuteNonQuery();
            //reservation
            OracleCommand cn8 = new OracleCommand();
            cn8.Connection = conn;
            cn8.CommandText = "delete from reservation where HOTELL_ID=:h_id";
            cn8.CommandType = CommandType.Text;
            cn8.Parameters.Add("h_id", Convert.ToInt32(hotl_id_txtbox.Text));
            int r4 = cn8.ExecuteNonQuery();
            //room
            OracleCommand cn7 = new OracleCommand();
            cn7.Connection = conn;
            cn7.CommandText = "delete from room where hotel_id=:h_id";
            cn7.CommandType = CommandType.Text;
            cn7.Parameters.Add("h_id", Convert.ToInt32(hotl_id_txtbox.Text));
            int r3 = cn7.ExecuteNonQuery();
           //hotel
            if ((r2  != -1)&&(r3 != -1)&&(r4 != -1))
            {

                OracleCommand cn1 = new OracleCommand();
                cn1.Connection = conn;
                cn1.CommandText = "delete from hotles where hotel_id=:h_id";
                cn1.CommandType = CommandType.Text;
                cn1.Parameters.Add("h_id", Convert.ToInt32(hotl_id_txtbox.Text));
                int r = cn1.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("hotel is deleted succesfully");
                }
            }
            conn.Close();
            textBoxhotelname_txtbox.Text = "";
            landmard_txtbox.Text = "";
            location_txtbox.Text = "";
            pointsofintrest_txtbox.Text = "";
            hoteldiscription_txtbox.Text = "";
            website_id_txtbox.Text = "";
            hotl_id_txtbox.Text = "";
            rate_combobox.SelectedItem = null;
        }

        private void updatehotel_button_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn1 = new OracleCommand();
            cn1.Connection = conn;
            cn1.CommandText = "update hotles set hotel_name=:h_n,LANMDMARK=:lndmrk,locations=:lction,HOTEL_DISCRIPTION=:h_dscrption,rate=:rat,website_id=:w_id,adminid=:a_id where hotel_id=:h_id";
            cn1.CommandType = CommandType.Text;
            cn1.Parameters.Add("h_n", textBoxhotelname_txtbox.Text);
            cn1.Parameters.Add("lndmrk", landmard_txtbox.Text);
            cn1.Parameters.Add("lction", location_txtbox.Text);
            cn1.Parameters.Add("h_dscrption", hoteldiscription_txtbox.Text);
            cn1.Parameters.Add("rat", rate_combobox.SelectedItem.ToString());
            cn1.Parameters.Add("w_id", Convert.ToInt32(website_id_txtbox.Text));
            cn1.Parameters.Add("a_id", 1);
            cn1.Parameters.Add("h_id", Convert.ToInt32(hotl_id_txtbox.Text));
            cn1.ExecuteNonQuery();
            //points of intrest
            OracleCommand cn3 = new OracleCommand();
            cn3.Connection = conn;
            cn3.CommandText = "update POINTS_OF_INTREST set POINTS_OF_INTREST =:p_o_i where HOTEL_ID=:h_id";
            cn3.CommandType = CommandType.Text;
            cn3.Parameters.Add("p_o_i", pointsofintrest_txtbox.Text);
            cn3.Parameters.Add("h_id", Convert.ToInt32(hotl_id_txtbox.Text));
            cn3.ExecuteNonQuery();
            MessageBox.Show("hotel is updated succesfully");
            conn.Close();
            textBoxhotelname_txtbox.Text = "";
            landmard_txtbox.Text = "";
            location_txtbox.Text = "";
            pointsofintrest_txtbox.Text = "";
            hoteldiscription_txtbox.Text = "";
            website_id_txtbox.Text = "";
            hotl_id_txtbox.Text = "";
            rate_combobox.SelectedItem = null;
        }

        private void update_button_rate_Click(object sender, EventArgs e)
        {

        }

        private void delete_button_rate_Click(object sender, EventArgs e)
        {

        }

        private void view_website_button_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=ORCL;User Id=hr;password=hr;";
            string cmbstr = "select * from website";
            adapter = new OracleDataAdapter(cmbstr, connstr);
            ds = new DataSet();
            adapter.Fill(ds);
            hotel_dataGridView.DataSource = ds.Tables[0];
        }

        private void view_hotel_button_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=ORCL;User Id=hr;password=hr;";
            string cmbstr = "select * from hotles";
            adapter = new OracleDataAdapter(cmbstr, connstr);
            ds = new DataSet();
            adapter.Fill(ds);
            hotel_dataGridView.DataSource = ds.Tables[0];
        }

        private void manage_website_button_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void hotel_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
