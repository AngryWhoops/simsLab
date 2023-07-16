using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    ///<summary>
    ///Тип перечислитель, который указывает на тип поста
    /// <br></br>
    ///<value>PlotContent</value> = 0;
    /// <br></br> 
    ///<value>ModContent</value> = 1;
    /// <br></br>
    ///<value>AdditionalContent</value> = 2;
    ///</summary>
    public enum PostType
    {
        /* Пост с участком */
        PlotContent,
        /* Пост с модами */
        ModContent,
        /* Пост с доп. контентом */
        AdditionalContent
    }
    ///<summary>
    ///Класс для постов пользователя.
    ///</summary>
    public class Post
    {
        public long Id { get; set; }
        public PostType? Type { get; set; }
        public User? User { get; set; }
        [MaxLength(100)]
        public string? Head { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }
        public int? Width { get; set; }
        public int? Hight { get; set; }
        public List<Tag> Tags { get; set; } = new();
        public GroundType? GroundType { get; set; }
        public PostPrewiew? Prewiew { get; set; }
        public File File { get; set; } = new();
        [MinLength(1)]
        [MaxLength(10)]
        public List<Image>? Images { get; set; }
    }
}