namespace api.Models
{
    public class Image
    {
        public long Id { get; set; }
        public string? Small { get; set; }
        public string? Medium { get; set; }
        public string? Large { get; set; }
        public required Post Post { get; set; }
    }
}