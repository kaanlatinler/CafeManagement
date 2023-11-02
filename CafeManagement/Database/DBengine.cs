using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Database
{
    class DBengine
    {
        public static readonly string connString = @"Data Source=DESKTOP-L24PRRJ\SQLEXPRESS;Initial Catalog=CafeManagamentDB;Persist Security Info=True;User ID=sa;Password=kaanhdd374";
        public static SqlConnection conn= new SqlConnection(connString);

        public static bool IsValid(string user, string pass)
        {
            bool isValid = false;

            string query = @"Select * from users where username = '" + user + "' and uPass = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            { 
                isValid = true;
            }

            return isValid;
        }
    }
}
