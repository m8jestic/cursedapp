using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursedapp
{
    
    public partial class FormAuth : Form
    {
       
        public FormAuth()
        {
            InitializeComponent();
        }

       
        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult authDialogResult = new FormRegistration().ShowDialog();
            this.Show();
            
        }

      
        private void okButton_Click(object sender, EventArgs e)
        {
            
            string login = loginTextBox.Text.Trim();
            
            
            if (loginTextBox.Text.Length !=0 & passwordTextBox.Text.Length != 0 & labelCheckLogin.Visible== false & labelCheckPassword.Visible == false)
            {
                Database db = new Database("Data Source=userdb.db;");
                string Hpassword = db.Hash(passwordTextBox.Text);
                DBUsers user = new DBUsers(login, Hpassword);
                if (db.ValidUser(user)) {
                    this.Hide();
                    var formMain = new FormMain();
                    formMain.Closed += (s, args) => this.Close();
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Заполните поля для авторизации","Ошибка");
            }
           
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar; 
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            string less = "Логин должен содержать более 4 символов";
            string more = "Логин должен содержать менее 12 символов";
            if (loginTextBox.Text.Length < 4)
            {
                labelCheckLogin.Text = less;
                labelCheckLogin.Visible = true;
            }
            else if(loginTextBox.Text.Length>=12)
            {
                labelCheckLogin.Text = more;
                labelCheckLogin.Visible = true;
            }
            else
            {
                labelCheckLogin.Visible = false;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            string less = "Пароль должен содержать более 5 символов";
            string more = "Пароль должен содержать менее 14 символов";
            if (passwordTextBox.Text.Length < 5)
            {
                labelCheckPassword.Text = less;
                labelCheckPassword.Visible = true;
            }
            else if (passwordTextBox.Text.Length >= 14)
            {
                labelCheckPassword.Text = more;
                labelCheckPassword.Visible = true;
            }
            else
            {
                labelCheckPassword.Visible = false;
            }
        }
    }
}
