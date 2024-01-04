using AutoMapper;
using HireMe.WebApi.Shared;

namespace HireMe.WebApi.WorkExperiences;

[Tags("WorkExperiences")]
public class WorkExperiencesController(WebApiContext context, IMapper mapper)
    : EntitiesController<WorkExperience, WorkExperienceDto, WorkExperienceWriteDto>(
        context,
        mapper
    ) { }
