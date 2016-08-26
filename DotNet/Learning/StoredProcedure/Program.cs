using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace StoredProcedure
{
	class SroredProcedureTest
	{
		static void Main(string[] args)
		{
			string connectionString = "Server=SP2013ii;Database=TestDB;Trusted_Connection=True;";
			string sql = "SELECT " + "Id, Name, Label" + " FROM TestTable";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                try
                {
                    connection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
							int i = 0;
                        }
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
		}
	}
}
