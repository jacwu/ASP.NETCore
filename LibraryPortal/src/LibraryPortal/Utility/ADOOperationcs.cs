using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibraryPortal.Models;

namespace LibraryPortal.Utility
{
    public class ADOOperationcs
    {
        public static IEnumerable<BookCategory> GetBookCategories()
        {            
            var connString = Startup.Configuration["Data:EFConnection:ConnectionString"];

            string sql = "select * from BookCategory";

            var cats = new List<BookCategory>();

            using (var conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                conn.Open();

                using (var command = new SqlCommand(sql, conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);

                        cats.Add(new BookCategory { Id = id, Name = name });                        
                    }
                }
            }

            return cats;
        }
    }
}
