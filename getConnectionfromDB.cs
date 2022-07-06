using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace FYP_CarRentalSystem
{
    public class getConnectionfromDB
    {
        //making a connection to SQL server.
        //ab ham aik method banate hain jo connection return karyga. ta k hamen bar bar connection na banana parhy aur coding likhne ma kam wqt lagy.
        public static SqlConnection getSqlConnection() //es method ki type ham ne SQlConnection set ki hai q k hamen connection chahiye. database sy tu yeh conn. return kr rha hai.
        {
            //opens a connection
            SqlConnection conn = new SqlConnection();// yeh ham ne sql ka instance create kia hai.

            try// try catch block ma es liye likha k agr koi error aye connection ma tu hamen btaye. use kia kabi try and catch? phir thek hai.
            {

                String constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sam\Documents\CarRentalManagementDB.mdf;Integrated Security=True;Connect Timeout=30";
                conn.ConnectionString = constring;// jo conn.ConnectionString a rha wo string hai jis ma ham pura database ka yeh code dete jo uper likha hoa hai. esko ham direct b likh sakte mtlb aisy.
                conn.Open();
            }//agr try block k ander jo code likha hoa us ma error ati tu phir catch block wala code run hoga.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
        }

        public static void CloseConnection(SqlConnection conn)//es ma ham jo  b database ka connection pass karengy yeh usko clos kr dyga.
        {
            //close a connection
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}