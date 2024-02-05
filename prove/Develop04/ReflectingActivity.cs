using System;
using System.IO;

// Reflecting Class
class ReflectingActivity : Activity
{
	// Reflecting Attributes
	private List<string> _prompts = new List<string>();
	private List<string> _questions = new List<string>();

	// Reflecting Methods
	public ReflectingActivity()
	{
		// Constructor
		_name = "Reflecting Activity";
		_description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
	}

	// Run program
	public void Run()
	{
		DisplayStartingMessage();

		Console.WriteLine("\nConsider the following prompt:\n");
		
		DisplayPrompt();
		Console.WriteLine("When you have something in mind, press enter to continue.");
		Console.ReadLine();
		Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
		Console.Write("You may begin in: ");
		ShowCountDown(5);
		DisplayQuestions();
		DisplayEndingMessage();
		SaveToFile();
	}

	private string GetRandomPrompt()
	{
		Random rand = new Random();
		string startingLine = "Think of a time when you ";
		int index;

		_prompts.Add("stood up for someone else.");
		_prompts.Add("did something really difficult.");
		_prompts.Add("helped someone in need");
		_prompts.Add("did something truly selfless.");
		index = rand.Next(0, _prompts.Count);
		return (startingLine + _prompts[index]);
	}

	private string GetRandomQuestion()
	{
		Random rand = new Random();
		int index;

		_questions.Add("Why was this experience meaningful to you?");
		_questions.Add("Have you ever done anything like this before?");
		_questions.Add("How did you get started?");
		_questions.Add("How did you feel when it was complete?");
		_questions.Add("What made this time different than other times when you were not as successful?");
		_questions.Add("What is your favorite thing about this experience?");
		_questions.Add("What could you learn from this experience that applies to other situations?");
		_questions.Add("What did you learn about yourself through this experience?");
		_questions.Add("How can you keep this experience in mind in the future?");

		index = rand.Next(0, _questions.Count);
		return (_questions[index]);
	}

	private void DisplayPrompt()
	{
		string prompt = GetRandomPrompt();
		Console.WriteLine($" --- {prompt} ---\n");
	}

	private void DisplayQuestions()
	{
		Console.Clear();
		DateTime futureTime = DateTime.Now.AddSeconds(_duration);

		while (DateTime.Now <= futureTime)
		{
			string ques = GetRandomQuestion();

			Console.Write($"> {ques} ");
			Spinner(15);
			Console.WriteLine();
		}
	}

	private void SaveToFile()
	{
		string fileName = "reflectingActivity.txt";

		using (StreamWriter outputFile = new StreamWriter(fileName))
		{
			string currentTime = DateTime.Now.ToString("MM/dd/yyyy");

			outputFile.WriteLine($"{_name}: {currentTime}");
			outputFile.WriteLine($"You have completed {_duration} of the {_name}.");
		}
	}
}