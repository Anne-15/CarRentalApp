
namespace CarRentalApp
{
    partial class Bookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.customerFirstName = new System.Windows.Forms.TextBox();
            this.customerAge = new System.Windows.Forms.TextBox();
            this.validLicence = new System.Windows.Forms.TextBox();
            this.numberOfDays = new System.Windows.Forms.TextBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.customerSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.carType = new System.Windows.Forms.ComboBox();
            this.extraZ = new System.Windows.Forms.ComboBox();
            this.fuelType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Page";
            // 
            // customerFirstName
            // 
            this.customerFirstName.Location = new System.Drawing.Point(239, 85);
            this.customerFirstName.Name = "customerFirstName";
            this.customerFirstName.Size = new System.Drawing.Size(309, 20);
            this.customerFirstName.TabIndex = 1;
            this.customerFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // customerAge
            // 
            this.customerAge.Location = new System.Drawing.Point(239, 237);
            this.customerAge.Name = "customerAge";
            this.customerAge.Size = new System.Drawing.Size(309, 20);
            this.customerAge.TabIndex = 2;
            this.customerAge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // validLicence
            // 
            this.validLicence.Location = new System.Drawing.Point(239, 286);
            this.validLicence.Name = "validLicence";
            this.validLicence.Size = new System.Drawing.Size(309, 20);
            this.validLicence.TabIndex = 3;
            this.validLicence.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // numberOfDays
            // 
            this.numberOfDays.Location = new System.Drawing.Point(239, 334);
            this.numberOfDays.Name = "numberOfDays";
            this.numberOfDays.Size = new System.Drawing.Size(309, 20);
            this.numberOfDays.TabIndex = 4;
            this.numberOfDays.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // customerAddress
            // 
            this.customerAddress.Location = new System.Drawing.Point(239, 186);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(309, 20);
            this.customerAddress.TabIndex = 5;
            this.customerAddress.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // customerSurname
            // 
            this.customerSurname.Location = new System.Drawing.Point(239, 138);
            this.customerSurname.Name = "customerSurname";
            this.customerSurname.Size = new System.Drawing.Size(309, 20);
            this.customerSurname.TabIndex = 6;
            this.customerSurname.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valid Driving Licence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Customer Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Customer Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(236, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Customer Surname";
            // 
            // carType
            // 
            this.carType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carType.FormattingEnabled = true;
            this.carType.Items.AddRange(new object[] {
            "City Car",
            "Family Car",
            "Sport Car",
            "SUV "});
            this.carType.Location = new System.Drawing.Point(239, 382);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(309, 21);
            this.carType.TabIndex = 13;
            this.carType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // extraZ
            // 
            this.extraZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extraZ.FormattingEnabled = true;
            this.extraZ.Items.AddRange(new object[] {
            "Unlimited mileage ",
            "Breakdown Coverage"});
            this.extraZ.Location = new System.Drawing.Point(239, 475);
            this.extraZ.Name = "extraZ";
            this.extraZ.Size = new System.Drawing.Size(309, 21);
            this.extraZ.TabIndex = 14;
            this.extraZ.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // fuelType
            // 
            this.fuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelType.FormattingEnabled = true;
            this.fuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Full Electric"});
            this.fuelType.Location = new System.Drawing.Point(239, 432);
            this.fuelType.Name = "fuelType";
            this.fuelType.Size = new System.Drawing.Size(309, 21);
            this.fuelType.TabIndex = 15;
            this.fuelType.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Type of Car";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fuel Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(236, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "Optional Extras";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(347, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fuelType);
            this.Controls.Add(this.extraZ);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerSurname);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.numberOfDays);
            this.Controls.Add(this.validLicence);
            this.Controls.Add(this.customerAge);
            this.Controls.Add(this.customerFirstName);
            this.Controls.Add(this.label1);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Bookings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerFirstName;
        private System.Windows.Forms.TextBox customerAge;
        private System.Windows.Forms.TextBox validLicence;
        private System.Windows.Forms.TextBox numberOfDays;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.TextBox customerSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox carType;
        private System.Windows.Forms.ComboBox extraZ;
        private System.Windows.Forms.ComboBox fuelType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}