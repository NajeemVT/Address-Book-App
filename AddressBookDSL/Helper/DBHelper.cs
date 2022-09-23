using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AddressBookDSL.Helper
{
    class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = null;
            String ConnectionString = null;
            try
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["AddressBookPL.Properties.Settings.AddressBookConnectionString1"].ConnectionString;
                // ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C: \\Users\\1028259\\Desktop\\NAJEEM\\PROJECT ARCHITECTURE\\AddressBookSolution\\AddressBookDSL\\Data\\AddressBook.mdf;Integrated Security=True";
                con = new SqlConnection(ConnectionString);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : DBHelper:GetConnection : " + ex.Message.ToString());
            }
            return con;
        }
    }
}
