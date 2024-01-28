using System;

class Scripture
{
	private Reference _reference;
	private List<Word> _words = new List<Word>();


	public Scripture(Reference reference, string text)
	{
		_reference = reference;
		_words = StringToWords(text);
	}

	private List<Word> StringToWords(string text)
	{
		List<Word> words = new List<Word>();
		string[] textWords;
		
		textWords = text.Split(' ');
		foreach (string w in textWords)
		{
			Word word = new Word(w);
			words.Add(word);
		}

		return words;
	}

	public void HideRandomWords(int numberToHide)
	{
		int loop = numberToHide;
		Random random = new Random();
		int randomNumber;

		while (loop >= 0)
		{
			int i = 0;
			List<int> numbers = new List<int>();

			if (IsCompletelyHidden())
			{
				break;
			}
			foreach (Word w in _words)
			{
				if (w.IsHidden() == false)
				{
					numbers.Add(i);
				}
				i++;
			}
			if (numbers.Count != 0)
			{
				randomNumber = random.Next(0, numbers.Count);
				randomNumber = numbers[randomNumber];
				_words[randomNumber].Hide();
			}
			loop--;
		}
	}

	public bool IsCompletelyHidden()
	{
		int i = 0;
		List<int> index = new List<int>();

		foreach (Word w in _words)
		{
			if (w.IsHidden() == false)
			{
				index.Add(i);
			}
			i++;
		}
		if (index.Count != 0)
		{
			return false;
		}
		return true;
	}

	public string GetDisplayText()
	{
		string output = "";

		output += _reference.GetDisplayText();
		
		foreach (Word w in _words)
		{
			output += w.GetDisplayText();
		}

		return output;
	}


}