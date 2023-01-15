using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathee_Stephanus_PRG282_Exam
{
    public partial class Registration : Form
    {
        Display display = new Display();
        DataHandler dh = new DataHandler();
        List<User> users = new List<User>();    
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cbxGender.Items.Add("Male");
            cbxGender.Items.Add("Female");

            for (int i = 1; i <= 31; i++)
            {
                cbxDay.Items.Add($"{i}");
            }
            for (int i = 1; i <= 12; i++)
            {
                cbxMonth.Items.Add($"{i}");
            }
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cbxYear.Items.Add($"{i}");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user;
            if (txtEmail.Text != "" && txtFirstname.Text != "" && txtLastName.Text != "" && txtPassword.Text != "" && cbxGender.Text != "Select Sex" && cbxDay.Text != "Day"
                && cbxMonth.Text != "Month" && cbxYear.Text != "Year")
            {
                DateTime birthDate = dateTimePicker1.Value;

                user = new User(txtFirstname.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, cbxGender.Text, birthDate);
                dh.InsertData(user);
            }
            else
            {
                MessageBox.Show("Please fill in the required fields or select the right option");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            display.Show();
        }
    }
}
