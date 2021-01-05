using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Odev2
{
    class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Writer { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }

        public Book()
        {

        }

        public Book(int ıd, string bookName, string writer, string category, int year)
        {
            Id = ıd;
            BookName = bookName;
            Writer = writer;
            Category = category;
            Year = year;
        }

        private static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static bool SqlExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                }
                return true;

            }
            catch
            {

                return false;
            }
        }
        public static SqlDataReader SqlExecuteReader(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            cmd.Connection = conn;
            return cmd.ExecuteReader();
        }
        
}
}