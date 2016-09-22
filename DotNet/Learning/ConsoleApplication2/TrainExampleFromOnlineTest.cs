using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

public class Train<T>
{
	private readonly Dictionary<int, object> wagons;

	public Train(int wagonCount, Func<int, T> fillWagon)
	{
		this.wagons = new Dictionary<int, object>();

		for (int i = 0; i < wagonCount; i++)
		{
			this.wagons[i] = fillWagon(i);
		}
	}

	public T PeekWagon(int wagonIndex)
	{
		return (T)this.wagons[wagonIndex];
	}
}

public class TrainStation
{
	public static void Main(string[] args)
	{
		string str = "ad 8 & sdf";
		Regex rgx = new Regex("[^a-zA-Z]");
		str = rgx.Replace(str, "");
		char[] tempstr = str.ToCharArray();
		Array.Reverse(tempstr);
		string revstr = new string(tempstr);
		bool caseignore = str.Equals(revstr, StringComparison.OrdinalIgnoreCase);


		Process proc = Process.GetCurrentProcess();
		int noOfWagons = 100;
		Train<string> train = new Train<string>(noOfWagons, wagonIndex => "Wagon: " + wagonIndex);

		for (int i = 0; i < noOfWagons; i++)
		{
			Console.WriteLine(train.PeekWagon(i));
		}
		
		int yield = 0;
	}
}
