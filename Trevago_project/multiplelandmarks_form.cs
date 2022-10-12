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
    public partial class multiplelandmarks_form : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public multiplelandmarks_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            booking_and_deleting_choice_form l = new booking_and_deleting_choice_form();
            l.Show();
            this.Hide();
        }

        private void X_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void multiplelandmarks_form_Load(object sender, EventArgs e)
        {
            string connstr = "Data Source=ORCL;User Id=hr;password=hr;";
            string cmbstr = "select * from hotles";
            adapter = new OracleDataAdapter(cmbstr, connstr);
            ds = new DataSet();
            adapter.Fill(ds);
            multipilemarks_dataGridView.DataSource = ds.Tables[0];
        }

        private void multipilemarks_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
