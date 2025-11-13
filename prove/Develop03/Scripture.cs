public class Scripture
{
    private string _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            //Word newWord = new Word(word);
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        //string text = " ";

        Console.WriteLine(_reference);

        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }

    }

    public void HideRandomWords()
    {
        int hiddenCount = 0;
        int numberToHide = 1;

        while (hiddenCount < numberToHide)
    {
        int index = _random.Next(_words.Count);
        Word word = _words[index];

        if (!word.IsHidden())
        {
            word.HideWord();
            hiddenCount++;
        }
    }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}