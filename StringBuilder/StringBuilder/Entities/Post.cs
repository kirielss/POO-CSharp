namespace StringBuilder.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public void ShowComments(List<Comment> comments)
        {
            foreach (Comment comment in Comments)
            {
                Console.WriteLine(comment);
                Console.WriteLine();
            }
        }
        public override string ToString()
        {
            return Title + Environment.NewLine + Likes + " Likes - " + Moment + Environment.NewLine + Content + Environment.NewLine + "Comments:" + Environment.NewLine ShowComments(Comments);
        }
    }
}
