using System.Collections.Generic;

namespace api.Models
{
    /// <summary>
    /// Класс пользователя
    /// </summary>
    public class User
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public required string Login { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public List<Post>? Posts { get; set; }

    }
}