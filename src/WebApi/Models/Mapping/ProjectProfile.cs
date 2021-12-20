using System;

using AutoMapper;

using ProjectRequest = WebApi.Models.Requests.Projects.CreateProject;
using ProjectResponse = WebApi.Models.Responses.Project;
using ProjectDatabase = WebApi.Models.Database.Project;

namespace WebApi.Models.Mapping
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectRequest, ProjectDatabase>()
            .ForMember(e => e.Id,  e => e.MapFrom(s => Guid.NewGuid()))
            .ForMember(e => e.UpdatedById,  e => e.MapFrom(s => new Guid("00000000-0000-0000-0000-000000000001")))
            .ForMember(e => e.UpdatedBy,  e => e.Ignore())
            .ForMember(e => e.UpdatedOn,  e => e.MapFrom(s => DateTime.Now))
            .ForMember(e => e.UpdatedOnUtc,  e => e.MapFrom(s => DateTime.UtcNow))
            .ForMember(e => e.IsActive,  e => e.MapFrom(s => true));

            CreateMap<ProjectDatabase, ProjectResponse>();
        }
    }
}