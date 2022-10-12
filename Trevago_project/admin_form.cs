using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trevago_project
{
    public partial class admin_form : Form
    {
        public int customer_password = login_form.id;
        public string customer_username = login_form.ussername;

        public admin_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            login_form L = new login_form();
            L.Show();
            this.Hide();
        }

        private void search_button_admin_Click(object sender, EventArgs e)
        {
            chossing_the_factor L = new chossing_the_factor();
            L.Show();
            this.Hide();
        }

        private void reservation_button_admin_Click(object sender, EventArgs e)
        {
            reservation_username L = new reservation_username();
            L.Show();
            this.Hide();
        }

        private void cancel_reservation_button_admin_Click(object sender, EventArgs e)
        {
            deleting_reservation_form L = new deleting_reservation_form();
            L.Show();
            this.Hide();
        }

        private void manage_room_button_Click(object sender, EventArgs e)
        {
            room_form L = new room_form();
            L.Show();
            this.Hide();
        }

        private void manage_hotel_button_Click(object sender, EventArgs e)
        {
            hotel_form L = new hotel_form();
            L.Show();
            this.Hide();
        }

        private void X_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void hotel_report_button_Click(object sender, EventArgs e)
        {
            report1 r = new report1();
            r.Show();
            this.Hide();
        }
    }
}
