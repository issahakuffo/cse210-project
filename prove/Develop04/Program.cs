using System;

// Exceeded requirement by saving logs to file
// Compile with .Net 8.0
class Program
{
	static void Main(string[] args)
	{
		ReflectingActivity reflecting = new ReflectingActivity();
		ListingActivity listing = new ListingActivity();
		BreathingActivity breathing = new BreathingActivity();

		while(true)
		{
			int res;

			Console.Clear();
			Console.WriteLine("Menu Options:");
			Console.WriteLine("     1. Start breathing activity");
			Console.WriteLine("     2. Start reflecting activity");
			Console.WriteLine("     3. Start listing activity");
			Console.WriteLine("     4. Quit");

			Console.Write("Select a choice from the menu: ");

			res = int.Parse(Console.ReadLine() ?? "4");

			switch(res)
			{
				case 1:
					Console.Clear();
					breathing.Run();
					break;
				case 2:
					Console.Clear();
					reflecting.Run();
					break;
				case 3:
					Console.Clear();
					listing.Run();
					break;
				case 4:
					return;
				default:
					Console.WriteLine("Input a number from 1-4");
					break;
			}

		}
	}
}