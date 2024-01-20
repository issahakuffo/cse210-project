using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Please Compile with .Net 8.0 or edit <programname>.csproj TargetFramework

class Program
{
	static void Main(string[] args)
	{
		// Beginning of program
		Journal journalName = new Journal();
		string filename = "";

		while (true)
		{
			string option;

			Console.WriteLine("\nSelect an entry (1-5):\n");

			Console.WriteLine("1. Write a new entry");
			Console.WriteLine("2. Display the journal");
			Console.WriteLine("3. Save journal to file");
			Console.WriteLine("4. Load journal from file");
			Console.WriteLine("5. Save as JSON file");
			Console.WriteLine("6. Exit Program\n\n");

			Console.Write("Enter option: ");

			option = Console.ReadLine() ?? "0";

			switch (option)
			{
				case "1":
					WriteEntry(journalName);
					break;
				case "2":
					journalName.DisplayAll();
					break;
				case "3":
					SaveEntriesToFile(journalName, filename);
					break;
				case "4":
					LoadEntriesFromFile(journalName, filename);
					break;
				case "5":
					SaveToJsonFile(journalName);
					break;
				case "6":
					return;
				default:
					Console.WriteLine("\nInvalid option");
					break;
			}
		}
	}

	static void WriteEntry(Journal journalName)
	{
		Entry new_entry = new Entry();

		Console.WriteLine("\nEnter your entry below (Press Return/Enter to end)\n");

		Console.WriteLine(new_entry._promptText);
		Console.WriteLine("------------------------------------------\n");

		new_entry._entryText = Console.ReadLine() ?? " ";

		journalName.AddEntry(new_entry);
	}

	static void SaveEntriesToFile(Journal journalName, string fileName)
	{
		if (fileName == "")
		{
			Console.Write("Enter your filename (without an extension): ");
			fileName = Console.ReadLine() ?? "default";
			fileName += ".txt";
		}
		
		journalName.SaveToFile(fileName);
	}

	static void LoadEntriesFromFile(Journal journalName, string fileName)
	{
		if (fileName == "")
		{
			Console.Write("Enter your filename: ");

			fileName = Console.ReadLine() ?? "default";
		}

		journalName.LoadFromFile(fileName);
	}

	static void SaveToJsonFile(Journal journalName)
	{
		string filename;
		string jsonString;

		Console.WriteLine("\nPick a filename: \n");
		filename = Console.ReadLine() ?? "default";
		filename += ".json";

		jsonString = JsonSerializer.Serialize(journalName, new JsonSerializerOptions { WriteIndented = true });
		File.WriteAllText(filename, jsonString);
	}

}

