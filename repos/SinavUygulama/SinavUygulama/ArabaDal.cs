using SinavUygulama.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SinavUygulama
{
    public class ArabaDal : IAraba
    {
        public void Add(Araba araba)
        {
            SqlConnection connection = new SqlConnection(@"");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("Insert Into Modeller(Model,Motor,Yil) Values(@Model,@Motor,@Yil)", connection);
            cmd.Parameters.AddWithValue("Model", araba.Model);
            cmd.Parameters.AddWithValue("Motor", araba.Motor);
            cmd.Parameters.AddWithValue("Yil", araba.Yil);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(Araba t)
        {
            SqlConnection connection = new SqlConnection(@"");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("Delete from Modeller where Model=@Model", connection);
            cmd.Parameters.AddWithValue("Model", t.Model);
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public List<Araba> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from Modeller", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Araba> arabaa = new List<Araba>();
            while (reader.Read())
            {
                Araba araba = new Araba
                {
                    Model = reader["Model"].ToString(),
                    Motor = Convert.ToDouble(reader["Motor"]),
                    Yil = Convert.ToInt32(reader["Yil"])
                };
                arabaa.Add(araba);
            }
            reader.Close();
            connection.Close();
            return arabaa;
        }

        public List<Araba> GetByModel(string model)
        {
            var query = (from a in new Araba().List
                         where a.Model == "model"
                         select a);
            return query.ToList();
        }

        public void Update(Araba t)
        {
            SqlConnection connection = new SqlConnection(@"");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand("Update Model set Model=@Model,Motor=@Motor,Yil=@Yil where Model=@Model", connection);
            cmd.Parameters.AddWithValue("Model", t.Model);
            cmd.Parameters.AddWithValue("Motor", t.Motor);
            cmd.Parameters.AddWithValue("Yil", t.Yil);
            cmd.ExecuteNonQuery();
            connection.Close();


        }
    }
}
