using AutoMapper;
using HireMe.WebApi.Shared;

namespace HireMe.WebApi.Skills;

[Tags("Skills")]
public class SkillsController(WebApiContext context, IMapper mapper)
    : EntitiesController<Skill, SkillDto, SkillWriteDto>(context, mapper) { }
