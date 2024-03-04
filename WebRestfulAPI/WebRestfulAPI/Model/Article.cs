namespace WebRestfulAPI.Model
{
    public class Article
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string? Title { get; set; }
        public string? Text { get; set; }
    }
}
