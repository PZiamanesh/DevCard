using Microsoft.AspNetCore.Mvc.RazorPages;
using PortfolioApp.Models.Domain;
using PortfolioApp.Models.Repositories;

namespace PortfolioApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProjectRepository _projectRepository;
        public List<Project>? Projects { get; set; }

        public IndexModel(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void OnGet()
        {
            Projects = _projectRepository.GetAll();
        }
    }
}