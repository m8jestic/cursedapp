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
            this.passwordRegistrationConfirmTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxPasswordConfirm = new System.Windows.Forms.CheckBox();
            this.labelCheckRegistrLogin = new System.Windows.Forms.Label();
            this.labelCheckRegPassword = new System.Windows.Forms.Label();
            this.labelCheckRegPasswordCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.Location = new System.Drawing.Point(285, 115);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(275, 19);
            this.registrationLabel.TabIndex = 0;
            this.registrationLabel.Text = "Введите данные для регистрации";
            // 
            // loginRegistrationLabel
            // 
            this.loginRegistrationLabel.AutoSize = true;
            this.loginRegistrationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegistrationLabel.Location = new System.Drawing.Point(399, 143);
            this.loginRegistrationLabel.Name = "loginRegistrationLabel";
            this.loginRegistrationLabel.Size = new System.Drawing.Size(46, 17);
            this.loginRegistrationLabel.TabIndex = 1;
            this.loginRegistrationLabel.Text = "Логин";
            // 
            // passwordRegistrationLabel
            // 
            this.passwordRegistrationLabel.AutoSize = true;
            this.passwordRegistrationLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegistrationLabel.Location = new System.Drawing.Point(395, 213);
            this.passwordRegistrationLabel.Name = "passwordRegistrationLabel";
            this.passwordRegistrationLabel.Size = new System.Drawing.Size(54, 17);
            this.passwordRegistrationLabel.TabIndex = 2;
            this.passwordRegistrationLabel.Text = "Пароль";
            // 
            // loginRegistrationTextBox
            // 
            this.loginRegistrationTextBox.Location = new System.Drawing.Point(329, 163);
            this.loginRegistrationTextBox.Name = "loginRegistrationTextBox";
            this.loginRegistrationTextBox.Size = new System.Drawing.Size(187, 20);
            this.loginRegistrationTextBox.TabIndex = 3;
            this.loginRegistrationTextBox.TextChanged += new System.EventHandler(this.loginRegistrationTextBox_TextChanged);
            // 
            // passwordRegistrationTextBox
            // 
            this.passwordRegistrationTextBox.Location = new System.Drawing.Point(329, 233);
            this.passwordRegistrationTextBox.Name = "passwordRegistrationTextBox";
            this.passwordRegistrationTextBox.Size = new System.Drawing.Size(187, 20);
            this.passwordRegistrationTextBox.TabIndex = 4;
            this.passwordRegistrationTextBox.UseSystemPasswordChar = true;
            this.passwordRegistrationTextBox.TextChanged += new System.EventHandler(this.passwordRegistrationTextBox_TextChanged);
            // 
            // okRegistrationButton
            // 
            this.okRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okRegistrationButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okRegistrationButton.Location = new System.Drawing.Point(385, 345);
            this.okRegistrationButton.Name = "okRegistrationButton";
            this.okRegistrationButton.Size = new System.Drawing.Size(75, 23);
            this.okRegistrationButton.TabIndex = 5;
            this.okRegistrationButton.Text = "OK";
            this.okRegistrationButton.UseVisualStyleBackColor = true;
            this.okRegistrationButton.Click += new System.EventHandler(this.okRegistrationButton_Click);
            // 
            // passwordRegistrationConfirmTextBox
            // 
            this.passwordRegistrationConfirmTextBox.Location = new System.Drawing.Point(329, 302);
            this.passwordRegistrationConfirmTextBox.Name = "passwordRegistrationConfirmTextBox";
            this.passwordRegistrationConfirmTextBox.Size = new System.Drawing.Size(187, 20);
            this.passwordRegistrationConfirmTextBox.TabIndex = 6;
            this.passwordRegistrationConfirmTextBox.UseSystemPasswordChar = true;
            this.passwordRegistrationConfirmTextBox.TextChanged += new System.EventHandler(this.passwordRegistrationConfirmTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label1.Location = new System.Drawing.Point(355, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Подтвердите пароль";
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(522, 236);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPassword.TabIndex = 8;
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // checkBoxPasswordConfirm
            // 
            this.checkBoxPasswordConfirm.AutoSize = true;
            this.checkBoxPasswordConfirm.Location = new System.Drawing.Point(522, 305);
            this.checkBoxPasswordConfirm.Name = "checkBoxPasswordConfirm";
            this.checkBoxPasswordConfirm.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPasswordConfirm.TabIndex = 9;
            this.checkBoxPasswordConfirm.UseVisualStyleBackColor = true;
            this.checkBoxPasswordConfirm.CheckedChanged += new System.EventHandler(this.checkBoxPasswordConfirm_CheckedChanged);
            // 
            // labelCheckRegistrLogin
            // 
            this.labelCheckRegistrLogin.AutoSize = true;
            this.labelCheckRegistrLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.labelCheckRegistrLogin.ForeColor = System.Drawing.Color.Red;
            this.labelCheckRegistrLogin.Location = new System.Drawing.Point(281, 186);
            this.labelCheckRegistrLogin.Name = "labelCheckRegistrLogin";
            this.labelCheckRegistrLogin.Size = new System.Drawing.Size(282, 17);
            this.labelCheckRegistrLogin.TabIndex = 14;
            this.labelCheckRegistrLogin.Text = "Логин должен содержать более 4 символов";
            this.labelCheckRegistrLogin.Visible = false;
            // 
            // labelCheckRegPassword
            // 
            this.labelCheckRegPassword.AutoSize = true;
            this.labelCheckRegPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.labelCheckRegPassword.ForeColor = System.Drawing.Color.Red;
            this.labelCheckRegPassword.Location = new System.Drawing.Point(277, 256);
            this.labelCheckRegPassword.Name = "labelCheckRegPassword";
            this.labelCheckRegPassword.Size = new System.Drawing.Size(290, 17);
            this.labelCheckRegPassword.TabIndex = 15;
            this.labelCheckRegPassword.Text = "Пароль должен содержать более 5 символов";
            this.labelCheckRegPassword.Visible = false;
            // 
            // labelCheckRegPasswordCheck
            // 
            this.labelCheckRegPasswordCheck.AutoSize = true;
            this.labelCheckRegPasswordCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.labelCheckRegPasswordCheck.ForeColor = System.Drawing.Color.Red;
            this.labelCheckRegPasswordCheck.Location = new System.Drawing.Point(350, 325);
            this.labelCheckRegPasswordCheck.Name = "labelCheckRegPasswordCheck";
            this.labelCheckRegPasswordCheck.Size = new System.Drawing.Size(144, 17);
            this.labelCheckRegPasswordCheck.TabIndex = 16;
            this.labelCheckRegPasswordCheck.Text = "Пароли не совпадают";
            this.labelCheckRegPasswordCheck.Visible = false;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCheckRegPasswordCheck);
            this.Controls.Add(this.labelCheckRegPassword);
            this.Controls.Add(this.labelCheckRegistrLogin);
            this.Controls.Add(this.checkBoxPasswordConfirm);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordRegistrationConfirmTextBox);
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
        private System.Windows.Forms.TextBox passwordRegistrationConfirmTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxPasswordConfirm;
        private System.Windows.Forms.Label labelCheckRegistrLogin;
        private System.Windows.Forms.Label labelCheckRegPassword;
        private System.Windows.Forms.Label labelCheckRegPasswordCheck;
    }
}