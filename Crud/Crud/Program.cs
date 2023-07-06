using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=YBANALA-L-5498\\SQLEXPRESS;Initial Catalog=Shopdb;User ID=sa;Password=Welcome2evoke@1234");
            con.Open();
            //Select Query
            GetAll(con);
            GetElementById(con);
            //Insert Query
            Insertquery(con);
            //Update Query
            Updatequery(con);
            //Delete Query
            Deletequery(con);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        private static void GetAll(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select * from categories", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0} \t | {1} \t", reader[0], reader[1]));
            }
        }
        private static void GetElementById(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select * from categories where category_id=@Id", con);
            cmd.Parameters.Add(new SqlParameter("Id", 1));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0} \t | {1} \t", reader[0], reader[1]));
            }
        }

        private static void Insertquery(SqlConnection con)
        {
            Console.WriteLine("Insert Command");
            SqlCommand insert = new SqlCommand("Insert into categories (category_id,category_name) values (@id,@name)", con);
            insert.Parameters.Add(new SqlParameter("id", 13));
            insert.Parameters.Add(new SqlParameter("name", "Mobile"));
            Console.WriteLine("Command executed " + insert.ExecuteNonQuery());
            insert.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("Select * from categories", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0} \t | {1} \t", reader[0], reader[1]));
            }
        }

        private static void Updatequery(SqlConnection con)
        {
            SqlCommand update = new SqlCommand("Update categories set category_name = @updatename where category_id = @updateId", con);
            update.Parameters.Add(new SqlParameter("updatename", "jam"));
            update.Parameters.Add(new SqlParameter("updateId", 16));
            Console.WriteLine("Update command executed " + update.ExecuteNonQuery());
        }

        private static void Deletequery(SqlConnection con)
        {
            SqlCommand delete = new SqlCommand("Delete from categories where category_id = @deleteId", con);
            delete.Parameters.Add(new SqlParameter("@deleteId", 16));
            Console.WriteLine("Delete command executed " + delete.ExecuteNonQuery());
        }
    }
}
