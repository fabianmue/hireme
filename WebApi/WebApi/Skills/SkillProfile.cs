using AutoMapper;

namespace HireMe.WebApi.Skills;

public abstract class SkillProfile : Profile
{
    protected SkillProfile()
    {
        CreateMap<SkillWriteDto, Skill>();
        CreateMap<Skill, SkillDto>();
    }
}
