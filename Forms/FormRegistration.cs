using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursedapp
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void okRegistrationButton_Click(object sender, EventArgs e)
        {
            if (loginRegistrationTextBox.Text.Length != 0 & passwordRegistrationTextBox.Text.Length != 0 
                & passwordRegistrationTextBox.Text == passwordRegistrationConfirmTextBox.Text 
                & labelCheckRegistrLogin.Visible == false 
                & labelCheckRegPassword.Visible == false & labelCheckRegPasswordCheck.Visible == false)
            {
                Database db = new Database("Data Source=userdb.db;");
                string Hpassword = db.Hash(passwordRegistrationTextBox.Text);
                DBUsers user = new DBUsers(loginRegistrationTextBox.Text, Hpassword);
                if (!db.ValidUser(user))
                {
                    if (db.Registration(user))
                    {
                        MessageBox.Show("Регистрация успешно пройдена","Успешно");
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Ошибка регистрации", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с такими данными уже существует", "Ошибка");
                }
                

            }
            else
            {
                MessageBox.Show("Заполните поля для регистрации корректно", "Ошибка");
            }
        }

        private void checkBoxPasswordConfirm_CheckedChanged(object sender, EventArgs e)
        {
            passwordRegistrationConfirmTextBox.UseSystemPasswordChar = !passwordRegistrationConfirmTextBox.UseSystemPasswordChar;
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordRegistrationTextBox.UseSystemPasswordChar = !passwordRegistrationTextBox.UseSystemPasswordChar;
        }

        private void loginRegistrationTextBox_TextChanged(object sender, EventArgs e)
        {
            string less = "Логин должен содержать более 4 символов";
            string more = "Логин должен содержать менее 12 символов";
            if (loginRegistrationTextBox.Text.Length < 4)
            {
                labelCheckRegistrLogin.Text = less;
                labelCheckRegistrLogin.Visible = true;   
            }
            else if(loginRegistrationTextBox.Text.Length >= 12)
            {
                labelCheckRegistrLogin.Text = more;
                labelCheckRegistrLogin.Visible = true;
            }
            else
            {
                labelCheckRegistrLogin.Visible = false;
            }
        }

        private void passwordRegistrationTextBox_TextChanged(object sender, EventArgs e)
        {
            string less = "Пароль должен содержать более 5 символов";
            string more = "Пароль должен содержать менее 14 символов";
            if (passwordRegistrationTextBox.Text.Length < 5)
            {
                labelCheckRegPassword.Text = less;
                labelCheckRegPassword.Visible = true;
            }
            else if (passwordRegistrationTextBox.Text.Length >= 14)
            {
                labelCheckRegPassword.Text = more;
                labelCheckRegPassword.Visible = true;
            }
            else
            {
                labelCheckRegPassword.Visible = false;
            }
        }

        private void passwordRegistrationConfirmTextBox_TextChanged(object sender, EventArgs e)
        {

            if(passwordRegistrationConfirmTextBox.Text != passwordRegistrationTextBox.Text) 
            
                labelCheckRegPasswordCheck.Visible= true;
            
            else

                labelCheckRegPasswordCheck.Visible= false;
        }

       
    }
}
