namespace api.Models
{
    /// <summary>
    /// Класс для работы с тегами постов
    /// </summary>
    public class Tag
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public List<Post> PlotPosts { get; set; } = new();
    }
}