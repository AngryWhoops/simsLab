namespace api.Models
{
    /// <summary>
    /// Класс пользователя
    /// </summary>
    public class User
    {
        public long Id { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Post>? Posts { get; set; }

    }
}