namespace api.Models
{
    /// <summary>
    /// Класс для работы с файлами у постов
    /// </summary>
    public class File
    {
        public long Id { get; set; }
        public string? Path { get; set; }
        public Post? Post { get; set; }
    }
}