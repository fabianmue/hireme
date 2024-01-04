using System.ComponentModel.DataAnnotations;
using HireMe.WebApi.Shared;

namespace HireMe.WebApi.Skills;

public class SkillWriteDto : EntityWriteDto
{
    [Required(AllowEmptyStrings = false), StringLength(32, MinimumLength = 4)]
    public required string Description { get; set; }

    [Required, Range(1, 5)]
    public required int Proficiency { get; set; }
}
