using pasniyonKayit.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasniyonKayit.Genel
{
    public class TurDal : ITur
    {
        public void Add(Tur t)
        {
            using (SqlCommand cmd =
                new SqlCommand("Insert Into Tur(PansiyonTuru) Values(@PansiyonTuru)"))
            {
                cmd.Parameters.AddWithValue("PansiyonTuru", t.PansiyonTuru);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Delete(Tur t)
        {
            using (SqlCommand cmd =
                new SqlCommand("Delete From Tur Where PansiyonId=@PansiyonId"))
            {
                cmd.Parameters.AddWithValue("PansiyonId", t.PansiyonId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public List<Tur> GetAll()
        {
            var turList = new List<Tur>();
            SqlCommand cmd = new SqlCommand("Selecet *from Tur");
            var reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Tur tur = new Tur
                {
                    PansiyonId = Convert.ToInt32(reader[0]),
                    PansiyonTuru = reader[1].ToString()
                };
                turList.Add(tur);
            }
            return turList;
        }

        public Tur GetById(int id)
        {
            Tur tur = new Tur();
            SqlCommand cmd = new SqlCommand("Select *from Tur Where PansiyonId=@PansiyonId");
            cmd.Parameters.AddWithValue("PansiyonId", id);
            var reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                tur.PansiyonId = Convert.ToInt32(reader[0]);
                tur.PansiyonTuru = reader[1].ToString();
            }
            return tur;
        }

        public List<Tur> GetByPansiyonTuru()
        {
            var turList = new List<Tur>();
            SqlCommand cmd = new SqlCommand("Selecet *from Tur Where PansiyonTuru=@PansiyonTuru");
            var reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Tur tur = new Tur
                {
                   
                    PansiyonTuru = reader[0].ToString()
                };
                turList.Add(tur);
            }
            return turList;
        }

        public void Update(Tur t)
        {
            using (SqlCommand cmd =
                new SqlCommand("UPDATE Tur SET PansiyonId = @PansiyonId WHERE PansiyonTuru = @PansiyonTuru"))
            {
                cmd.Parameters.AddWithValue("PansiyonId", t.PansiyonId);
                cmd.Parameters.AddWithValue("PansiyonTuru", t.PansiyonTuru);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }
    }
}
