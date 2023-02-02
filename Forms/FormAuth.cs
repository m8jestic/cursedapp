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
            
            
            if (loginTextBox.Text.Length !=0 & passwordTextBox.Text.Length != 0)
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

        
    }
}
