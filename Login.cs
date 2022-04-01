using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly RentalCarEntities users;
        public Login()
        {
            InitializeComponent();
            users = new RentalCarEntities();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sh = SHA256.Create();

                var username = userNameInput.Text.Trim();
                var password = passwordInput.Text;

                //convert the input string to a byte array and compute the hash
                byte[] data = sh.ComputeHash(Encoding.UTF8.GetBytes(password));

                //create a new string builder to collect the bytes and create a string
                StringBuilder sBuild = new StringBuilder();

                //loop through each byte of the hashed data and format each one as a hexadecimal string
                for (int i = 0; i < data.Length; i++)
                {
                    sBuild.Append(data[i].ToString("x2"));
                }

                var hashed_password = sBuild.ToString();

                var userInput = users.users.FirstOrDefault(q => q.username == username && q.password == password);

                if (userInput == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var booking = new Bookings();
                    booking.Show();
                    Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong. Please try again!");
            }
        }
    }
}