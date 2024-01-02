using HireMe.WebApi.Shared;

namespace HireMe.WebApi.Skills;

public class SkillDto : EntityDto
{
    public required string Description { get; set; }

    public required int Proficiency { get; set; }
}
