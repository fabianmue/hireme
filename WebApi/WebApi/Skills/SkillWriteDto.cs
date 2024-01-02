using HireMe.WebApi.Shared;

namespace HireMe.WebApi.Skills;

public class SkillWriteDto : EntityWriteDto
{
    public required string Description { get; set; }

    public required int Proficiency { get; set; }
}
