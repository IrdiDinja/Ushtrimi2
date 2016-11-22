using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace ushtrim
{
   public class Ruaj
    {

        public bool RuajNeDBTest(string toEmail,string subject,string body,string error)
        {

            string log=toEmail+','+subject+','+body+','+error;
            File.AppendAllText("C:\\Users\\idinja\\Desktop\\New folder\\ushtrim\\ushtrim\\Ruaj.txt", log+Environment.NewLine);
            
            return true;
	
        }
        public void RuajNeDB(string toEmail, string subject,string body,string error)
        {
            using(SqlConnection con=new SqlConnection("Data Source=IDINJA-PC\\IDINJA;Initial Catalog=email;Integrated Security=True"))
            {
                string insert = "INSERT INTO email(toEmail,subject,body,error) VALUES(@toEmail,@subject,@body,@error)";
                using(SqlCommand cmd=new SqlCommand(insert,con))
                {
                    cmd.Parameters.AddWithValue("@toEmail",toEmail);
                    cmd.Parameters.AddWithValue("@subject",subject);
                    cmd.Parameters.AddWithValue("@body", body);
                    cmd.Parameters.AddWithValue("@error",error);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    

                }
            }
        }
    }
}
