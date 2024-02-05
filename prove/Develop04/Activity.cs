using System;

// Compile with .Net 8.0

// Activity base class

class Activity
{
	// Activity attributes
	protected string _name;
	protected string _description;
	protected int _duration;


	// Activity Methods
	
	public Activity()
	{//Constructor
	}

	// Display Starting Message
	protected void DisplayStartingMessage()
	{
		Console.WriteLine($"Welcome to the {_name}.\n");
		Console.WriteLine($"{_description}\n");

		Console.Write($"How long, in seconds, would you like for your session? ");
		_duration = int.Parse(Console.ReadLine() ?? "30");
		Console.Clear();
		Console.WriteLine("Get ready...");
		Spinner(5);
		
	}

	// Display Ending Message
	protected void DisplayEndingMessage()
	{
		Console.WriteLine("\nWell done!!");
		Spinner(5);
		Console.WriteLine();
		Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
		Spinner(5);
	}

	// Show Spinner
	protected void Spinner(int seconds)
	{
		int j;
		List<string> spinnerLine = new List<string>() {"|", "\\", "-", "/"};
		DateTime futureTime = DateTime.Now.AddSeconds(seconds);

		j = 0;
		while (DateTime.Now <= futureTime)
		{
			string s = spinnerLine[j];

			Console.Write(s);
			Thread.Sleep(500);
			Console.Write("\b \b");

			j++;
			if (j >= spinnerLine.Count)
			{
				j = 0;
			}
		}
	}

	// Show Count-Down
	protected void ShowCountDown(int seconds)
	{
		while(seconds >= 0)
		{
			Console.Write(seconds--);
			Thread.Sleep(1000);
			Console.Write("\b \b");
		}
	}
}