namespace PortfolioApp.Models.Domain
{
    public class Project
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ImageThumb { get; set; }
        public string? ImageFull { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
    }
}
