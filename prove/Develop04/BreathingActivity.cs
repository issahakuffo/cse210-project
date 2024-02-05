using System;
using System.IO;

// Breathing Activity Class

class BreathingActivity : Activity
{

	public BreathingActivity()
	{
		// Constructor
		_description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
		_name = "Breathing Activity";
	}

	public void Run()
	{
		DisplayStartingMessage();
		DateTime futureTime = DateTime.Now.AddSeconds(_duration);

		while (DateTime.Now <= futureTime)
		{
			Console.Write("\nBreathe in...");
			ShowCountDown(5);
			Console.Write("\nNow breathe out...");
			ShowCountDown(5);
			Console.WriteLine();
		}
		DisplayEndingMessage();
		Spinner(5);
		SaveToFile();
	}

	// Showing creativity or Exceeding Requirement
	protected void SaveToFile()
	{
		string fileName = "breathingActivity.txt";

		using (StreamWriter outputFile = new StreamWriter(fileName))
		{
			string currentTime = DateTime.Now.ToString("MM/dd/yyy");

			outputFile.WriteLine($"{_name}: {currentTime}");
			outputFile.WriteLine($"         You have completed {_duration} seconds of {_name}.");
		}
	}
}