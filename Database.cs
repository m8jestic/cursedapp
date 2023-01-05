using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace cursedapp
{
    public class Database
    {
        private readonly string dataSource;
        public Database(string dataSource)
        {
            this.dataSource = dataSource;
          

        }
        public bool InitializeDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "DROP TABLE IF EXISTS users;"
                    + "CREATE TABLE users("
                   + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                   + "login TEXT, "
                   + "password TEXT, "
                   + "role TEXT; ";
                    cmd.CommandText = sql_command;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return true;
        }
      
        public bool ValidUser(DBUsers user)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("SELECT COUNT(login)"
                    + "FROM users "
                    + "where login = '{0}' AND "
                    + "password = '{1}'",
                    user.login, user.password);
                    var usersCount = (int)cmd.ExecuteScalar();
                    return usersCount > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return false;
        }
        public bool Registration(DBUsers user)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            
                conn.Open();
                if(conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                   
                    cmd.CommandText = String.Format("INSERT INTO users ('name','password')"+ "VALUES('{0}', '{1}')",user.login,user.password);
                    cmd.ExecuteNonQuery();
                    return true;

                }
                return true;
         
            
           
        }
        
    }
}
