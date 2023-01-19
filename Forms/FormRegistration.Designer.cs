namespace cursedapp
{
    partial class FormRegistration
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
            this.registrationLabel = new System.Windows.Forms.Label();
            this.loginRegistrationLabel = new System.Windows.Forms.Label();
            this.passwordRegistrationLabel = new System.Windows.Forms.Label();
            this.loginRegistrationTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegistrationTextBox = new System.Windows.Forms.TextBox();
            this.okRegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.Location = new System.Drawing.Point(275, 130);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(275, 19);
            this.registrationLabel.TabIndex = 0;
            this.registrationLabel.Text = "Введите данные для регистрации";
            // 
            // loginRegistrationLabel
            // 
            this.loginRegistrationLabel.AutoSize = true;
            this.loginRegistrationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegistrationLabel.Location = new System.Drawing.Point(389, 162);
            this.loginRegistrationLabel.Name = "loginRegistrationLabel";
            this.loginRegistrationLabel.Size = new System.Drawing.Size(46, 17);
            this.loginRegistrationLabel.TabIndex = 1;
            this.loginRegistrationLabel.Text = "Логин";
            // 
            // passwordRegistrationLabel
            // 
            this.passwordRegistrationLabel.AutoSize = true;
            this.passwordRegistrationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegistrationLabel.Location = new System.Drawing.Point(385, 213);
            this.passwordRegistrationLabel.Name = "passwordRegistrationLabel";
            this.passwordRegistrationLabel.Size = new System.Drawing.Size(54, 17);
            this.passwordRegistrationLabel.TabIndex = 2;
            this.passwordRegistrationLabel.Text = "Пароль";
            // 
            // loginRegistrationTextBox
            // 
            this.loginRegistrationTextBox.Location = new System.Drawing.Point(319, 182);
            this.loginRegistrationTextBox.Name = "loginRegistrationTextBox";
            this.loginRegistrationTextBox.Size = new System.Drawing.Size(187, 20);
            this.loginRegistrationTextBox.TabIndex = 3;
            // 
            // passwordRegistrationTextBox
            // 
            this.passwordRegistrationTextBox.Location = new System.Drawing.Point(319, 233);
            this.passwordRegistrationTextBox.Name = "passwordRegistrationTextBox";
            this.passwordRegistrationTextBox.PasswordChar = '*';
            this.passwordRegistrationTextBox.Size = new System.Drawing.Size(187, 20);
            this.passwordRegistrationTextBox.TabIndex = 4;
            this.passwordRegistrationTextBox.UseSystemPasswordChar = true;
            // 
            // okRegistrationButton
            // 
            this.okRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okRegistrationButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okRegistrationButton.Location = new System.Drawing.Point(375, 267);
            this.okRegistrationButton.Name = "okRegistrationButton";
            this.okRegistrationButton.Size = new System.Drawing.Size(75, 23);
            this.okRegistrationButton.TabIndex = 5;
            this.okRegistrationButton.Text = "OK";
            this.okRegistrationButton.UseVisualStyleBackColor = true;
            this.okRegistrationButton.Click += new System.EventHandler(this.okRegistrationButton_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okRegistrationButton);
            this.Controls.Add(this.passwordRegistrationTextBox);
            this.Controls.Add(this.loginRegistrationTextBox);
            this.Controls.Add(this.passwordRegistrationLabel);
            this.Controls.Add(this.loginRegistrationLabel);
            this.Controls.Add(this.registrationLabel);
            this.Name = "FormRegistration";
            this.Text = "Окно регистрации";
  
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label loginRegistrationLabel;
        private System.Windows.Forms.Label passwordRegistrationLabel;
        private System.Windows.Forms.TextBox loginRegistrationTextBox;
        private System.Windows.Forms.TextBox passwordRegistrationTextBox;
        private System.Windows.Forms.Button okRegistrationButton;
    }
}