using System.ComponentModel.DataAnnotations;
using HireMe.WebApi.Shared;

namespace HireMe.WebApi.WorkExperiences;

public class WorkExperienceWriteDto : EntityWriteDto
{
    [Required(AllowEmptyStrings = false), StringLength(64, MinimumLength = 8)]
    public required string JobTitle { get; set; }

    [Required(AllowEmptyStrings = false), StringLength(64, MinimumLength = 4)]
    public required string Employer { get; set; }

    public required List<string> Responsibilities { get; set; }

    [Required, DataType(DataType.Date)]
    public required DateOnly From { get; set; }

    [DataType(DataType.Date)]
    public required DateOnly? To { get; set; }

    [Required(AllowEmptyStrings = false), StringLength(32, MinimumLength = 4)]
    public required string Location { get; set; }
}
