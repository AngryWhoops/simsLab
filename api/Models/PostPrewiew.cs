namespace api.Models
{
    /// <summary>  
    ///  Класс для превью картинок постов  
    /// </summary>  
    public class PostPrewiew
    {
        public long Id { get; set; }
        public Post? Post { get; set; }
        public string? Small { get; set; }
        public string? Medium { get; set; }
        public string? Large { get; set; }
    }
}