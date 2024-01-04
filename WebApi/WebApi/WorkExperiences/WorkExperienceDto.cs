using HireMe.WebApi.Shared;

namespace HireMe.WebApi.WorkExperiences;

public class WorkExperienceDto : EntityDto
{
    public required string JobTitle { get; set; }

    public required List<string> Responsibilities { get; set; }

    public required DateTime From { get; set; }

    public required DateTime? To { get; set; }

    public required string Location { get; set; }
}
