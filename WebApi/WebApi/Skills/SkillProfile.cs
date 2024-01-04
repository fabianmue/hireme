using AutoMapper;

namespace HireMe.WebApi.Skills;

public class SkillProfile : Profile
{
    public SkillProfile()
    {
        CreateMap<SkillWriteDto, Skill>();
        CreateMap<Skill, SkillDto>();
    }
}
