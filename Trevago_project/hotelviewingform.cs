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
    public partial class price_form : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;password=hr;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public price_form()
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

        private void price_form_Load(object sender, EventArgs e)
        {
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void price_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmbstr;
            string connstr = "Data Source=ORCL;User Id=hr;password=hr;";
            if (price_cb.SelectedIndex == 0)
            {
                cmbstr = " SELECT * FROM room WHERE Price BETWEEN 0 AND 500";
                adapter = new OracleDataAdapter(cmbstr, connstr);
                ds = new DataSet();
                adapter.Fill(ds);
                price_dataGridView.DataSource = ds.Tables[0];
            }
            else if (price_cb.SelectedIndex == 1)
            {
                cmbstr = " SELECT * FROM room WHERE Price BETWEEN 501 AND 1000";
                adapter = new OracleDataAdapter(cmbstr, connstr);
                ds = new DataSet();
                adapter.Fill(ds);
                price_dataGridView.DataSource = ds.Tables[0];
            }
            else if (price_cb.SelectedIndex == 2)
            {
                cmbstr = " SELECT * FROM room WHERE Price BETWEEN 1001 AND 1500";
                adapter = new OracleDataAdapter(cmbstr, connstr);
                ds = new DataSet();
                adapter.Fill(ds);
                price_dataGridView.DataSource = ds.Tables[0];
            }
            else if (price_cb.SelectedIndex == 3)
            {
                cmbstr = " SELECT * FROM room WHERE Price BETWEEN 1501 AND 2000";
                adapter = new OracleDataAdapter(cmbstr, connstr);
                ds = new DataSet();
                adapter.Fill(ds);
                price_dataGridView.DataSource = ds.Tables[0];
            }
            else if (price_cb.SelectedIndex == 4)
            {
                cmbstr = " SELECT * FROM room WHERE Price BETWEEN 2001 AND 4000";
                adapter = new OracleDataAdapter(cmbstr, connstr);
                ds = new DataSet();
                adapter.Fill(ds);
                price_dataGridView.DataSource = ds.Tables[0];
            }
            else if (price_cb.SelectedIndex == 5)
            {
                cmbstr = " SELECT * FROM room WHERE Price BETWEEN 4001 AND 8000";
                adapter = new OracleDataAdapter(cmbstr, connstr);
                ds = new DataSet();
                adapter.Fill(ds);
                price_dataGridView.DataSource = ds.Tables[0];
            }

        }

        private void price_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
