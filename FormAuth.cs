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

        private void FormAuth_Load(object sender, EventArgs e)
        {
            
        }

        

        private void registerButton_Click(object sender, EventArgs e)
        {
            
            DialogResult authDialogResult = new FormRegistration().ShowDialog();
            
        }

      
        private void okButton_Click(object sender, EventArgs e)
        {
            
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            if(loginTextBox.Text.Length !=0 & passwordTextBox.Text.Length != 0)
            {
                DBUsers user = new DBUsers(login, password);
                Database db = new Database("Data Source=userdb.db;");
                if (db.ValidUser(user)) {
                    MessageBox.Show("E");
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            else
            {
                MessageBox.Show("Заполните поля для авторизации");
            }
           
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
