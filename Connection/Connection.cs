using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermProject.Connection
{
    internal class Connection
    {
        public static OleDbConnection conn;
        public static string dbconnect = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\MIDTERM.accdb";
        //rovider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\user\source\repos\MidtermProject\bin\Debug\MIDTERM.accdb

        public static void DB()
        {
            try
            {
                conn = new OleDbConnection(dbconnect);
                conn.Open();


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
