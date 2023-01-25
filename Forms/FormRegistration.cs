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
            if(loginRegistrationTextBox.Text.Length!=0 & passwordRegistrationTextBox.Text.Length != 0 & passwordRegistrationTextBox.Text == passwordRegistrationConfirmTextBox.Text)
            {
                Database db = new Database("Data Source=userdb.db;");
                DBUsers user = new DBUsers(loginRegistrationTextBox.Text,passwordRegistrationTextBox.Text);
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

        
    }
}
