using System;

class Word
{
	private string _text;
	private bool _isHidden;

	public Word(string text)
	{
		_isHidden = false;
		_text = text;
	}

	public void Hide()
	{
		_isHidden = true;
	}	

	public void Show()
	{
		_isHidden = false;
	}

	public bool IsHidden()
	{
		return _isHidden;
	}

	public string GetDisplayText()
	{
		if (IsHidden() == false)
		{
			return $" {_text} ";
		}
		int len = _text.Length;
		int i;
		string text = " ";

		for (i = 0; i < len; i++)
		{
			text += "_";
		}
		return $"{text} ";
	}
}