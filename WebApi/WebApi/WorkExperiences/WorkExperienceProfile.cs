using AutoMapper;

namespace HireMe.WebApi.WorkExperiences;

public class WorkExperienceProfile : Profile
{
    public WorkExperienceProfile()
    {
        CreateMap<WorkExperienceWriteDto, WorkExperience>();
        CreateMap<WorkExperience, WorkExperienceDto>();
    }
}
