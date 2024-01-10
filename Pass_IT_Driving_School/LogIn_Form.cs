using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_IT_Driving_School
{
    public partial class LogIn_Form : Form
    {
        public LogIn_Form()
        {
            InitializeComponent();
            txtUserName.Focus();
            txtPassword.UseSystemPasswordChar = true;
        }


        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Form registration_Page = new Registration_Form();
            this.Close();
            registration_Page.Show();
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                if (txtPassword.Text.Length >= 5)
                {
                    if(txtUserName.Text == "Admin" && txtPassword.Text == "Admin")
                    {
                        Admin_Form admin_Page = new Admin_Form();
                        this.Close();
                        admin_Page.Show();
                    }
                    else
                    {
                        llblMessage.Text = "User name/password incorrect!!!";
                        llblMessage.BackColor = Color.Red;
                        llblMessage.ForeColor = System.Drawing.Color.White;
                    }
                   
                }
                else
                {
                    llblMessage.Text = "Password should be at least of 5 character!!!";
                    llblMessage.BackColor = Color.Red;
                    llblMessage.ForeColor = System.Drawing.Color.White;
                }
            }
            else
            {
                txtUserName.Focus();
                llblMessage.Text = "Please enter user name and password.";
                llblMessage.ForeColor = System.Drawing.Color.White;
                llblMessage.BackColor = System.Drawing.Color.Red;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                llblMessage.Text = "User name must have letters and digits only!!!";
                llblMessage.ForeColor = System.Drawing.Color.White;
                llblMessage.BackColor = System.Drawing.Color.Red;
            }
            else
            { e.Handled = false; }
        }

        private void lchkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lchkBox.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
