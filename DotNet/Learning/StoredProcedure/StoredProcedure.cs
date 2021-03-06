﻿using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace StoredProcedure
{
	class SroredProcedureTest
	{
		public static string connectionString = "Server=SP2013ii;Database=TestDB;Trusted_Connection=True;";
		public static void Main(string[] args)
		{

			InvokeStoredProcudure();
		}
		public static void InvokeStoredProcudure()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand("My_Test", con))
				{
					try
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = 1;
						con.Open();
						//cmd.ExecuteNonQuery();
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
						con.Close();
					}
				}
			}
		}

		public static void RunSelect()
		{
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
