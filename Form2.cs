using Microsoft.Win32.SafeHandles;
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
    public partial class Display : Form
    {
        DataHandler dh = new DataHandler();
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            dh.GetData("@");
            dgvDisplay.DataSource = dh.bs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                dh.GetData("@");
            }
            else
            {
                dh.GetData(txtSearch.Text);
            }
            dgvDisplay.DataSource = dh.bs;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dh.DeleteUser(txtDelete.Text);
            btnSearch_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
