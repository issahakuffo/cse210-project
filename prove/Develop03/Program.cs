using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		List<Reference> references = new List<Reference>();
		List<string> scriptures = new List<string>();
		Scripture scripture;
		Random random = new Random();
		int index;

		// Exceeding requirement
		// By saving some scriptures and picking random one
		// for printing
		string one = "For God so love the world that He gave his only begotten son, and whosoever believeth in Him shall not perish but have everlasting life";
		Reference refr = new Reference("John", 3, 16);
		references.Add(refr);
		scriptures.Add(one);

		string two = "The LORD had said to Abram, “Go from your country, your people and your father's household to the land I will show you. “I will make you into a great nation, and I will bless you; I will make your name great, and you will be a blessing.";
		Reference refr1 = new Reference("Genesis", 12, 1, 3);
		references.Add(refr1);
		scriptures.Add(two);

		string three = "In the beginning was the Word, and the Word was with God, and the Word was God";
		Reference refr2 = new Reference("John", 1, 1);
		references.Add(refr2);
		scriptures.Add(three);

		index = random.Next(0, scriptures.Count);
		
		scripture = new Scripture(references[index], scriptures[index]);

		while (true)
		{
			string response;

			Console.Clear();
			Console.Write(scripture.GetDisplayText());

			Console.WriteLine("\nPress enter to continue ot typee 'quit' to finish:");
			response = Console.ReadLine() ?? "nill";
			if (response == "quit")
			{
				return;
			}
			if (scripture.IsCompletelyHidden() == true)
			{
				return;
			}
			scripture.HideRandomWords(2);
		}
	}
}