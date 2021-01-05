using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Sinavv
{
    public class CategoryDal : ICategoryDal
    {
        public void Add(Category t)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PansiyonDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlCommand cmd = new SqlCommand("Insert into (CategoryName) Values(@CategoryName)", connection))
            {
                cmd.Parameters.AddWithValue("CategoryName", t.CategoryName);

                cmd.ExecuteNonQuery();
                connection.Close();
            }
            
        }

        public void Delete(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PansiyonDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlCommand cmd = new SqlCommand("Delete from Category where CategoryID=@CategoryID", connection))
            {
                cmd.Parameters.AddWithValue("CategoryID", id);

                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }

        public List<Category> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PansiyonDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand cmd = new SqlCommand("Select *from Category", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Category> categories = new List<Category>();

            while (reader.Read())
            {
                Category category = new Category()
                {
                    CategoryId = Convert.ToInt32(reader[0]),
                    CategoryName = reader[1].ToString()
                };
            categories.Add(category);

            }
            reader.Close();
            connection.Close();
            return categories;
        }

        public void Update(Category t)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PansiyonDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlCommand cmd = new SqlCommand("Update Category set CategoryName=@CategoryName where CategoryName=@CategoryName", connection))
            {
                cmd.Parameters.AddWithValue("CategoryName", t.CategoryName);
                cmd.ExecuteNonQuery();
                connection.Close();

            };
        }
    }
}
