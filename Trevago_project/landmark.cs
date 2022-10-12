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
    public partial class landmark : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public landmark()
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

        private void landmark_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cn = new OracleCommand();
            cn.Connection = conn;
            cn.CommandText = "select LANMDMARK from hotles";
            cn.CommandType = CommandType.Text;
            OracleDataReader dr = cn.ExecuteReader();
            while (dr.Read())
            {
                landmark_cb.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void landmark_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connstr = "Data Source=ORCL;User Id=hr;password=hr;";
            string cmbstr = "select * from hotles where LANMDMARK=:l_andmark";
            adapter = new OracleDataAdapter(cmbstr, connstr);
            adapter.SelectCommand.Parameters.Add("l_andmark", landmark_cb.SelectedItem.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            landmark_dataGridView.DataSource = ds.Tables[0];
        }
    }
}
