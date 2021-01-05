using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryADONET
{
    class BookDal : IBook
    {
        public void Add(Book book)
        {
            using (SqlCommand cmd =
                    new SqlCommand("INSERT INTO Books (Title,Description, Year, CategoryId) VALUES (@Title,@Description, @Year, @CategoryId)"))
            {
                cmd.Parameters.AddWithValue("Title", book.Title);
                cmd.Parameters.AddWithValue("Description", book.Description);
                cmd.Parameters.AddWithValue("Year", book.Year);
                cmd.Parameters.AddWithValue("CategoryId", book.CategoryId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }

        public void Delete(Book book)
        {
            using (SqlCommand cmd=
                new SqlCommand("DELETE FROM Books where Id=@Id"))
            {
                cmd.Parameters.AddWithValue("Id", book.Id);
                VTYS.SqlExecuteNonQuery(cmd);

            }
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            using (SqlCommand cmd =
                    new SqlCommand("UPDATE Books set Title=@Title,Description=@Description, Year=@Year, CategoryId=@CategoryId where Id=@Id")) 
            {
                cmd.Parameters.AddWithValue("Id", book.Id);
                cmd.Parameters.AddWithValue("Title", book.Title);
                cmd.Parameters.AddWithValue("Description", book.Description);
                cmd.Parameters.AddWithValue("Year", book.Year);
                cmd.Parameters.AddWithValue("CategoryId", book.CategoryId);
                VTYS.SqlExecuteNonQuery(cmd);
            }
        }
    }
}
