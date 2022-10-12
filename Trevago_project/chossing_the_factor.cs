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
    public partial class chossing_the_factor : Form
    {
      
        public chossing_the_factor()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
           
            string customer_username = login_form.ussername;
            if (customer_username.Equals("mohahmed"))
            {
                admin_form L = new admin_form();
                L.Show();
                this.Hide();
            }
            else
            {
                booking_and_deleting_choice_form L = new booking_and_deleting_choice_form();
                L.Show();
                this.Hide();
            }
        }
        

        private void price_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (price_checkbox.Checked)
            {
                price_form L = new price_form();
                L.Show();
                this.Hide();
            }
            
        }

        private void rate_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rate_checkbox.Checked)
            {
                rate_form L = new rate_form();
                L.Show();
                this.Hide();
            }
        }

        private void country_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (country_checkbox.Checked)
            {
                country L = new country();
                L.Show();
                this.Hide();
            }
        }

        private void landmark_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (landmark_checkbox.Checked)
            {
                landmark L = new landmark();
                L.Show();
                this.Hide();
            }
        }

        private void choosingmultiplefactors_button_Click(object sender, EventArgs e)
        {
            multiplelandmarks_form L = new multiplelandmarks_form();
            L.Show();
            this.Hide();
        }

        private void X_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
