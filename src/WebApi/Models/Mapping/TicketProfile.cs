using System;

using AutoMapper;

using TicketRequest = WebApi.Models.Requests.Tickets.CreateTicket;
using TicketResponse = WebApi.Models.Responses.Ticket;
using TicketDatabase = WebApi.Models.Database.Ticket;

namespace WebApi.Models.Mapping
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<TicketRequest, TicketDatabase>()
            .ForMember(e => e.Id,  e => e.MapFrom(s => Guid.NewGuid()))
            .ForMember(e => e.ReceivedOnUtc, e => e.MapFrom(s => s.ReceivedOnUtc ?? s.ReceivedOn.UtcDateTime))
            .ForMember(e => e.UpdatedById,  e => e.MapFrom(s => new Guid("00000000-0000-0000-0000-000000000001")))
            .ForMember(e => e.UpdatedBy,  e => e.Ignore())
            .ForMember(e => e.UpdatedOn,  e => e.MapFrom(s => DateTime.Now))
            .ForMember(e => e.UpdatedOnUtc,  e => e.MapFrom(s => DateTime.UtcNow))
            .ForMember(e => e.IsActive,  e => e.MapFrom(s => true));

            CreateMap<TicketDatabase, TicketResponse>();
        }
    }
}