using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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
        public required PostType Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public required User User { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int Width { get; set; }
        public required int Hight { get; set; }
        public required List<Tag> Tags { get; set; } = null!;
        public required GroundType? GroundType { get; set; }
        public PostPrewiew? Prewiew { get; set; }
        public AppFile AppFile { get; set; } = new();
        public List<Image>? Images { get; set; }
    }
}