public class Reference 
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _reference;

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

        _reference = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

        _reference = $"{_book} {_chapter}:{_verse} ";
    }

    public string getDisplayText()
    {
        return _reference;
    }
    
}