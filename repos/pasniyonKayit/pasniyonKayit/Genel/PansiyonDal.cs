using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasniyonKayit.Genel
{
   public class PansiyonDal : IPansiyon
    {
        public void Add(Pansiyon pans)
        {
            using (SqlCommand cmd=
                new SqlCommand("Insert Into Pansiyon(Adi,Soyadi,OdaNo,Telefon,Hesap,PansiyonId) Values (@Adi,@Soyadi,@OdaNo,@Telefon,@Hesap,@PansiyonId)"))
            {
                cmd.Parameters.AddWithValue("Adi", pans.Adi);
                cmd.Parameters.AddWithValue("Soyadi", pans.Soyadi);
                cmd.Parameters.AddWithValue("OdaNo", pans.OdaNo);
                
                cmd.Parameters.AddWithValue("Telefon", pans.Telefon);
                cmd.Parameters.AddWithValue("Hesap", pans.Hesap);
                cmd.Parameters.AddWithValue("PansiyonId", pans.PansiyonId);

                VTYS.SqlExecuteNonQuery(cmd);

            }
        }


        public void Delete(Pansiyon pans)
        {
            using (SqlCommand cmd =
                new SqlCommand("Delete From Pansiyon where PansiyonId=@gPansiyonId"))
            {
                cmd.Parameters.AddWithValue("PansiyonId", pans.PansiyonId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public List<Pansiyon> GetAll()
        {
            var pansList = new List<Pansiyon>();
            SqlCommand cmd = new SqlCommand("Select * From Pansiyon");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Pansiyon pans = new Pansiyon
                {
                    Id = Convert.ToInt32(reader[0]),
                    Adi = reader[1].ToString(),
                    Soyadi = reader[2].ToString(),
                    OdaNo = Convert.ToInt32(reader[3]),
                    Telefon =int.Parse(reader[4].ToString()),
                    Hesap = int.Parse(reader[5].ToString()),
                    PansiyonId= Convert.ToInt32(reader[6])
                };
                pansList.Add(pans);
            }
            return pansList;
        }

        public List<Pansiyon> GetByHesap()
        {
            throw new NotImplementedException();
        }

        public Pansiyon GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Pansiyon pans)
        {
            using (SqlCommand cmd =
               new SqlCommand("Update Pansiyon set Adi = @Adi, Soyadi = @Soyadi, Odano = @OdaNo, Telefon=@Telefon,Hesap=@Hesap,PansiyonId=@PansiyonId where Id = @Id"))
            {
                cmd.Parameters.AddWithValue("Id", pans.Id);
                cmd.Parameters.AddWithValue("Adi", pans.Adi);
                cmd.Parameters.AddWithValue("Soyadi", pans.Soyadi);
                cmd.Parameters.AddWithValue("OdaNo", pans.OdaNo);
                
                cmd.Parameters.AddWithValue("Telefon", pans.Telefon);
                cmd.Parameters.AddWithValue("Hesap", pans.Hesap);
                cmd.Parameters.AddWithValue("PansiyonId", pans.PansiyonId);

                VTYS.SqlExecuteNonQuery(cmd);
            }
        }
    }
}
