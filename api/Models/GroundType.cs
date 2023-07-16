using System.Collections.Generic;

namespace api.Models
{
    /// <summary>
    /// Типа участка в посте с участками
    /// </summary>
    public class GroundType
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public List<Post> Posts { get; set; } = new();
    }
}