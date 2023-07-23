namespace api.Models
{
    /// <summary>
    /// Класс для работы с файлами у постов
    /// </summary>
    public class AppFile
    {
        public long Id { get; set; }
        public string? Path { get; set; }
        public long PostId { get; set; }
        public Post? Post { get; set; }
    }
}