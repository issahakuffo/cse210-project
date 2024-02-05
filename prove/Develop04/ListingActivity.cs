using System;
using System.IO;


// Listing Activity
class ListingActivity : Activity
{
	// Attributes
	private int _count;
	private List<string> _prompts = new List<string>();

	// Listing Methods
	public ListingActivity()
	{
		// constructor
		_name = "Listing Activity";
		_description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
	}

	// Run Method
	public void Run()
	{
		List<string> saveList = new List<string>();

		DisplayStartingMessage();
		GetRandomPrompt();
		Console.Write("You may begin in: ");
		ShowCountDown(5);
		Console.WriteLine();
		saveList = GetListFromUser();
		Console.WriteLine($"You listed {_count} item(s)!");
		DisplayEndingMessage();
		SaveToFile(saveList);
	}

	// Gets Random Prompt
	private void GetRandomPrompt()
	{
		Random radm = new Random();
		int index;

		_prompts.Add("Who are people that you appreciate?");
		_prompts.Add("What are personal strengths of yours?");
		_prompts.Add("Who are people that you have helped this week?");
		_prompts.Add("When have you felt the Holy Ghost this month?");
		_prompts.Add("Who are some of your personal heroes?");

		index = radm.Next(0, _prompts.Count);
		Console.WriteLine("\nList as many responses you can to the following prompt:");
		Console.WriteLine($" --- {_prompts[index]} ---");
	}

	// Get List From User
	private List<string> GetListFromUser()
	{
		DateTime futureTime = DateTime.Now.AddSeconds(_duration);
		List<string> answers = new List<string>();
		string ans;
		_count = 0;

		while (DateTime.Now <= futureTime)
		{
			Console.Write("> ");
			ans = Console.ReadLine();
			answers.Add(ans);
			_count++;
		}
		return (answers);
	}

	// Showing creativity or exceeing requirement
	private void SaveToFile(List<string> lists)
	{
		string fileName = "listingActivity.txt";

		using (StreamWriter outputFile = new StreamWriter(fileName))
		{
			string currentTime = DateTime.Now.ToString("MM/dd/yyyy");

			outputFile.WriteLine($"{_name} : {currentTime}");

			foreach (string s in lists)
			{
				outputFile.WriteLine($"       {s}");
			}
			outputFile.WriteLine($"You have completed {_duration} seconds of the {_name}.");
		}
	}
}