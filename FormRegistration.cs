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
            if(loginRegistrationTextBox.Text.Length!=0 & passwordRegistrationLabel.Text.Length != 0)
            {
                Database db = new Database("Data Source=userdb.db;");
                DBUsers user = new DBUsers(loginRegistrationTextBox.Text,passwordRegistrationTextBox.Text);
                if (!db.ValidUser(user))
                {
                    if (db.Registration(user))
                    {
                        MessageBox.Show("Регистрация успешно пройдена");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка регистрации");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с такими данными уже существует");
                }
                

            }
            else
            {
                MessageBox.Show("Заполните поля для регистрации");
            }
        }

       
    }
}
