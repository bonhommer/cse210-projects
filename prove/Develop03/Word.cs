public class Word
{
    private string _text;
    public bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void hide()
    {
        _isHidden = true;
    }

    public void show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
       return _isHidden;
    }

    public string getDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            int count = _text.Length;
            string hideText= new string('-', count);
            return hideText;
        }
    }
}