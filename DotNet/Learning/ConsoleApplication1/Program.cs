using System;
using System.Collections.Generic;
using System.Xml;

public class Folders
{
	public static IEnumerable<string> FolderNames(string xml, char startingLetter)
	{
		List<string> toRet = new List<string>();
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(xml);
		XmlNodeList nodes = xmlDoc.GetElementsByTagName("folder");
		for (int i = 0; i < nodes.Count; i++)
		{
			if (nodes[i].Attributes["name"].Value.StartsWith("u"))
			{
				toRet.Add(nodes[i].Attributes["name"].Value);
			}
		}
		IEnumerable<string> xxx = toRet;
		return xxx;
	}

	public static void Main(string[] args)
	{
		string xml =
			"<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
			"<folder name=\"u\">" +
				"<folder name=\"uprogram files\">" +
					"<folder name=\"uninstall information\" />" +
				"</folder>" +
				"<folder name=\"users\" />" +
			"</folder>";
		foreach (string name in Folders.FolderNames(xml, 'u'))
			Console.WriteLine(name);

		int y = 0;
	}
}