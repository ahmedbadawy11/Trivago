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
    public partial class booking_and_deleting_choice_form : Form
    {
        public string customer_username=login_form.ussername;
        public booking_and_deleting_choice_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
           
        }

        private void search_button_bokinganddeletingform_Click(object sender, EventArgs e)
        {
            chossing_the_factor L = new chossing_the_factor();
            L.Show();
            this.Hide();
        }

        private void reservation_button_Click(object sender, EventArgs e)
        {
            reservation_username L = new reservation_username();
            L.Show();
            this.Hide();
        }

        private void cancel_reservation_button_bookinganddeleting_Click(object sender, EventArgs e)
        {
            deleting_reservation_form L = new deleting_reservation_form();
            L.Show();
            this.Hide();
        }

        private void X_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void booking_and_deleting_choice_form_Load(object sender, EventArgs e)
        {

        }
    }
}
