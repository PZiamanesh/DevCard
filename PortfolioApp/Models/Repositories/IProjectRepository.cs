using PortfolioApp.Models.Domain;

namespace PortfolioApp.Models.Repositories
{
    public interface IProjectRepository
    {
        List<Project> GetAll();
    }
}