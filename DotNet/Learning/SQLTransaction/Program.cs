using System;
using System.Data;
using System.Data.SqlClient;

public class DatabaseHelper
{
	public static void ExecuteQuery(IConnection conn, string query)
	{
		try
		{
			conn.Execute(query);
			conn.Commit();
		}
		catch
		{
			conn.Rollback();
		}
		finally
		{
			conn.Close();
		}
		//implement
	}
}

public interface IConnection
{
	void Execute(string query);

	void Commit();

	void Rollback();

	void Close();
}

public class Connection : IConnection
{
	public void Execute(string query)
	{
		Console.WriteLine("Executed: " + query);
	}

	public void Commit()
	{
		Console.WriteLine("Commit");
	}

	public void Rollback()
	{
		Console.WriteLine("Rollback");
	}

	public void Close()
	{
		Console.WriteLine("Close");
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		DatabaseHelper.ExecuteQuery(new Connection(), "SELECT * FROM Users;");
	}
}

