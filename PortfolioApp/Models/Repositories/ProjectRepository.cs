using PortfolioApp.Models.Domain;

namespace PortfolioApp.Models.Repositories;

public class ProjectRepository : IProjectRepository
{
    public List<Project> GetAll()
    {
        return new List<Project>()
        {
            new()
            {
                Id = 1,
                Title = "PieShop",
                Description = "This is my first project developed with .net6",
                ImageThumb = "Prg1_Thumb.jpg",
                ImageFull = "Prg1_Full.jpg",
                Url = "lalala"
            }
        };
    }
}