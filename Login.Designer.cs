
namespace CarRentalApp
{
    partial class Login
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
            this.carRentalSystem = new System.Windows.Forms.Label();
            this.stuffLogIn = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carRentalSystem
            // 
            this.carRentalSystem.AutoSize = true;
            this.carRentalSystem.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carRentalSystem.Location = new System.Drawing.Point(223, 82);
            this.carRentalSystem.Name = "carRentalSystem";
            this.carRentalSystem.Size = new System.Drawing.Size(235, 31);
            this.carRentalSystem.TabIndex = 0;
            this.carRentalSystem.Text = "Car Rental System";
            this.carRentalSystem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stuffLogIn
            // 
            this.stuffLogIn.AutoSize = true;
            this.stuffLogIn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuffLogIn.Location = new System.Drawing.Point(275, 142);
            this.stuffLogIn.Name = "stuffLogIn";
            this.stuffLogIn.Size = new System.Drawing.Size(122, 25);
            this.stuffLogIn.TabIndex = 1;
            this.stuffLogIn.Text = "Stuff Log In";
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(190, 233);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(293, 20);
            this.userNameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(190, 291);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(293, 20);
            this.passwordInput.TabIndex = 3;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(190, 212);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(70, 14);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(190, 272);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 14);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(266, 346);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(109, 31);
            this.LogInButton.TabIndex = 6;
            this.LogInButton.Text = "Submit";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 503);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.stuffLogIn);
            this.Controls.Add(this.carRentalSystem);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carRentalSystem;
        private System.Windows.Forms.Label stuffLogIn;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button LogInButton;
    }
}

