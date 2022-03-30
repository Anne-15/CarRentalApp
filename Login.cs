using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            userNameInput.Text = "";
            passwordInput.Text = "";
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = String.IsNullOrEmpty(userNameInput.Text) ? "sta001" : userNameInput.Text;
            string password = String.IsNullOrEmpty(passwordInput.Text) ? "givemethekeys123" : passwordInput.Text;
            var isValid = true;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                isValid = false;
                MessageBox.Show("Wrong input data");

            } else
            {
                isValid = true;
                MessageBox.Show("Welcome to the Car Rental App");
            }
        }
    }
}