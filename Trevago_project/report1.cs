using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Trevago_project
{
    public partial class report1 : Form
    {

        CrystalReport4 cr4;
        CrystalReport5 cr5;
        CrystalReport6 cr6;
        public report1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void report1_Load(object sender, EventArgs e)
        {
            
            cr4 = new CrystalReport4();
            cr5 = new CrystalReport5();
            cr6 = new CrystalReport6();
            foreach (ParameterDiscreteValue v3 in cr5.ParameterFields[0].DefaultValues) 
            roomtype_comboBox.Items.Add(v3.Value);
            foreach (ParameterDiscreteValue v4 in cr6.ParameterFields[0].DefaultValues)
                startdate_comboBox.Items.Add(v4.Value);
        }

        private void hotel_report_button_Click(object sender, EventArgs e)
        {

            crystalReportViewer1.ReportSource = cr4;
        }

        private void report2_button_Click(object sender, EventArgs e)
        {
            cr5.SetParameterValue(0, roomtype_comboBox.Text);
            crystalReportViewer1.ReportSource = cr5;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr6.SetParameterValue(0, Convert.ToDateTime( startdate_comboBox.Text));
            crystalReportViewer1.ReportSource = cr6;
        }
    }
}
