using System.ComponentModel.DataAnnotations;
using HireMe.WebApi.Shared;

namespace HireMe.WebApi.WorkExperiences;

public class WorkExperienceWriteDto : EntityWriteDto
{
    [Required(AllowEmptyStrings = false), StringLength(64, MinimumLength = 8)]
    public required string JobTitle { get; set; }

    public required List<string> Responsibilities { get; set; }

    [Required, DataType(DataType.DateTime)]
    public required DateTime From { get; set; }

    [DataType(DataType.DateTime)]
    public required DateTime? To { get; set; }

    [Required(AllowEmptyStrings = false), StringLength(32, MinimumLength = 4)]
    public required string Location { get; set; }
}
