using Microsoft.AspNetCore.Mvc;

using AutoMapper;

using WebApi.DataContext;

using ProjectRequest = WebApi.Models.Requests.Projects.CreateProject;
using ProjectResponse = WebApi.Models.Responses.Project;
using ProjectDatabase = WebApi.Models.Database.Project;

namespace WebApi.Controllers
{

    [Route("[controller]")]
    public class ProjectController : Controller
    {

        private ProjectContext _context;
        private IMapper _mapper;

        public ProjectController(ProjectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public ProjectResponse Post([FromBody] ProjectRequest project)
        {
            var mappedProject = _mapper.Map<ProjectDatabase>(project);
            _context.Add(mappedProject);
            _context.SaveChanges();

            var foundProject = _context.Find<ProjectDatabase>(mappedProject.Id);
            return _mapper.Map<ProjectResponse>(foundProject);
        }

    }

}
