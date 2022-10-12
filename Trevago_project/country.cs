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
    public partial class country : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        OracleDataAdapter adapter;
         OracleCommandBuilder builder;
        DataSet ds;
        public country()
        {

            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            booking_and_deleting_choice_form L = new booking_and_deleting_choice_form();
            L.Show();
            this.Hide();
        }

        private void X_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void country_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn = new OracleCommand();
            cn.Connection = conn;
            cn.CommandText = "select locations from hotles";
            cn.CommandType = CommandType.Text;
            OracleDataReader dr = cn.ExecuteReader();
            while(dr.Read())
            {
                country_cb.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connstr = "Data Source=ORCL;User Id=hr;password=hr;";
            string cmbstr = "select * from hotles where locations=:cntry";
            adapter = new OracleDataAdapter(cmbstr, connstr);
            adapter.SelectCommand.Parameters.Add("cntry", country_cb.SelectedItem.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            country_dataGridView.DataSource = ds.Tables[0];
        }

        private void country_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn = new OracleCommand();
            cn.Connection = conn;
            cn.CommandText = "select HOTEL_NAME from hotles where LOCATIONS =:loc";
            cn.CommandType = CommandType.Text;
            cn.Parameters.Add("loc", country_cb.SelectedItem.ToString());
            OracleDataReader dr = cn.ExecuteReader();
            while (dr.Read())
            {
                hotels_combobox.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
    }
}
