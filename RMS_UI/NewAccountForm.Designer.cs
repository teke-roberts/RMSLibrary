namespace RMS_UI
{
    partial class NewAccountForm
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
            newAccountLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            reenterpasswordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            reenterpasswordTextBox = new TextBox();
            createAccountButton = new Button();
            isAdminBox = new CheckBox();
            SuspendLayout();
            // 
            // newAccountLabel
            // 
            newAccountLabel.AutoSize = true;
            newAccountLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newAccountLabel.Location = new Point(199, 71);
            newAccountLabel.Name = "newAccountLabel";
            newAccountLabel.Size = new Size(210, 45);
            newAccountLabel.TabIndex = 0;
            newAccountLabel.Text = "New Account";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(174, 136);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(126, 32);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(174, 197);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(116, 32);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // reenterpasswordLabel
            // 
            reenterpasswordLabel.AutoSize = true;
            reenterpasswordLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reenterpasswordLabel.Location = new Point(174, 258);
            reenterpasswordLabel.Name = "reenterpasswordLabel";
            reenterpasswordLabel.Size = new Size(214, 32);
            reenterpasswordLabel.TabIndex = 3;
            reenterpasswordLabel.Text = "Re-Enter Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(179, 171);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(243, 23);
            usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(179, 232);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(243, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // reenterpasswordTextBox
            // 
            reenterpasswordTextBox.Location = new Point(179, 293);
            reenterpasswordTextBox.Name = "reenterpasswordTextBox";
            reenterpasswordTextBox.Size = new Size(243, 23);
            reenterpasswordTextBox.TabIndex = 6;
            // 
            // createAccountButton
            // 
            createAccountButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccountButton.Location = new Point(234, 353);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(125, 47);
            createAccountButton.TabIndex = 7;
            createAccountButton.Text = "Create";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // isAdminBox
            // 
            isAdminBox.AutoSize = true;
            isAdminBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isAdminBox.Location = new Point(189, 322);
            isAdminBox.Name = "isAdminBox";
            isAdminBox.Size = new Size(75, 25);
            isAdminBox.TabIndex = 8;
            isAdminBox.Text = "Admin";
            isAdminBox.UseVisualStyleBackColor = true;
            // 
            // NewAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 438);
            Controls.Add(isAdminBox);
            Controls.Add(createAccountButton);
            Controls.Add(reenterpasswordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(reenterpasswordLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(newAccountLabel);
            Name = "NewAccountForm";
            Text = "NewAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newAccountLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label reenterpasswordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox reenterpasswordTextBox;
        private Button createAccountButton;
        private CheckBox isAdminBox;
    }
}