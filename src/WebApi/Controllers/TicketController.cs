using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using AutoMapper;

using WebApi.DataContext;

using TicketRequest = WebApi.Models.Requests.Tickets.CreateTicket;
using TicketResponse = WebApi.Models.Responses.Ticket;
using TicketDatabase = WebApi.Models.Database.Ticket;

namespace WebApi.Controllers
{

    [Route("[controller]")]
    public class TicketController : Controller
    {

        private ProjectContext _context;
        private IMapper _mapper;

        public TicketController(ProjectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<TicketResponse> Post([FromBody] TicketRequest project)
        {
            var mappedTicket = _mapper.Map<TicketDatabase>(project);
            _context.Add(mappedTicket);
            _context.SaveChanges();

            var foundTicket =
                await _context.Tickets
                    .Include(e => e.Project).Include(e => e.UpdatedBy)
                    .FirstOrDefaultAsync(e => e.Id == mappedTicket.Id);
            return _mapper.Map<TicketResponse>(foundTicket);
        }

    }

}
