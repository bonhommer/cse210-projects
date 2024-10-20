public class Reference 
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _reference;

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _reference = $"{book} {chapter}:{startVerse}-{endVerse}";
    }

    public Reference(string book, int chapter, int verse)
    {
        _reference = $"{book} {chapter}:{verse}";
    }

    public string getDisplayText()
    {
        return _reference;
    }
    
}