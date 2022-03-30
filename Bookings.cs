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
    public partial class Bookings : Form
    {
        private readonly RentalCarEntities rentalCarEntities;
        public Bookings()
        {
            InitializeComponent();
            rentalCarEntities = new RentalCarEntities();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = customerFirstName.Text;
                string surName = customerSurname.Text;
                string address = customerAddress.Text;
                var age = customerAge.ToString();
                string drivingLicence = validLicence.ToString();
                string numberDays = numberOfDays.ToString();
                var typeCar = carType.SelectedItem.ToString();
                var fuel = fuelType.SelectedItem.ToString();
                var extra = extraZ.SelectedItem.ToString();
                var isValid = true;
                var errorMessage = " ";

                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(surName)
                    || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(age))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter missing data.";
                }

                if (isValid == true)
                {
                    var rentalRecord = new CarRentalTABLE();
                    rentalRecord.CustomerFirstName = firstName;
                    rentalRecord.CustomerSurname = surName;
                    rentalRecord.CustomerAddress = address;
                    rentalRecord.CustomerAge = (int)age;
                    rentalRecord.DrivingLicence = drivingLicence;
                    rentalRecord.NumberOfDays = (int)numberDays;
                    rentalRecord.CarTypeId = (int)carType.SelectedValue;
                    rentalRecord.FuelTypeId = (int)fuelType.SelectedValue;
                    rentalRecord.Service = (int)extraZ.SelectedValue;
                    
                    rentalCarEntities.CarRentalTABLEs.Add(rentalRecord);
                    rentalCarEntities.SaveChanges();

                    MessageBox.Show($"Customer First Name: {firstName}\n\r" +
                    $"Customer Surname: {surName}\n\r" +
                    $"Customer Address: {address} \n\r" +
                    $"Customer Age: {age}\n\r" +
                    $"Customer Driving Licence: {drivingLicence}\n\r" +
                    $"Number of Days: {numberDays} \n\r" +
                    $"The car type: {typeCar}\n\r" +
                    $"The fuel type: {fuel}\n\r" +
                    $"Additional Extras: {extra}\n\r");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            var cars = rentalCarEntities.TypesOfCars.ToList();
            carType.DisplayMember = "CarType";
            carType.DisplayMember = "Prices";
            carType.ValueMember = "id";
            carType.DataSource = cars;

            var fuel = rentalCarEntities.FuelTypes.ToList();
            fuelType.DisplayMember = "FuelType";
            fuelType.DisplayMember = "Prices";
            fuelType.ValueMember = "id";
            fuelType.DataSource = fuel;

            var service = rentalCarEntities.Services.ToList();
            extraZ.DisplayMember = "Services";
            extraZ.DisplayMember = "Prices";
            extraZ.ValueMember = "id";
            extraZ.DataSource = service;
        }
    }
}
