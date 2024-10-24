public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int numberOfComments()
    {
        int number = _comments.Count;
        return number;
    }

    public void Display()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Lengh(mn): {_length}");
            Console.WriteLine($"Number of comments: {numberOfComments()}");
            Console.WriteLine("Comments: ");
            foreach(var comment in _comments)
            {
                comment.Display();
            }
        }
}