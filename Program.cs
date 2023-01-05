using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursedapp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            if (!File.Exists($"{path}\\userdb.db"))
            {
                new Database("Data Source=userdb.db;").InitializeDatabase();
            }
            Application.Run(new FormAuth());
           

        }
    }
}
