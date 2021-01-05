using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Odev2
{

        
        

       

    
    class Program
    {
            public List<Book> GetAll()
            {
                var bookList = new List<Book>();
                SqlCommand cmd = new SqlCommand("Select*from Books2");
                SqlDataReader reader = SqlExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book
                    {
                        Id = Convert.ToInt32(reader[0]),
                        BookName = reader[1].ToString(),
                        Writer = reader[2].ToString(),
                        Category = reader[3].ToString(),
                        Year = Convert.ToInt32(reader[4])
                    };
                    bookList.Add(book);
                }
                return bookList;
            }
        
    }
}
