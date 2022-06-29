namespace Project.Models
{
    public class Post
    {
        public int UserID { get; init; }
        public int ID { get; init; }
        public string? Title { get; init; }
        public string? Body { get; init; }
        public Post() { }
        public Post(int userID, int iD, string? title, string? body)
        {
            UserID = userID;
            ID = iD;
            Title = title;
            Body = body;
        }
    }
}
