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
    public partial class rate_form : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public rate_form()
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

        private void rate_form_Load(object sender, EventArgs e)
        {

        }

        private void rate_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connstr = "Data Source=ORCL;User Id=hr;password=hr;";
            string cmbstr = "select * from hotles where rate=:r_ate";
            adapter = new OracleDataAdapter(cmbstr, connstr);
            adapter.SelectCommand.Parameters.Add("r_ate", rate_cb.SelectedItem.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            rate_dataGridView.DataSource = ds.Tables[0];
        }
    }
}
