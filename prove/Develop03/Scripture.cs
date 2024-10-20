public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void hideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rand.Next(_words.Count());
            if (!_words[index].isHidden())
            {
                _words[index].hide();
                hiddenCount += 1;
            }
        }

    }

    public string getDisplayText()
    {
        string result = _reference.getDisplayText();
        foreach (Word word in _words)
        {
            result += word.getDisplayText();
        }
        return result;
    }

    public bool isCompletlyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.isHidden())
            {
                return true;
            }
        }
        return false;
    }
}

