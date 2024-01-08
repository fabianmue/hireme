using HireMe.WebApi.Shared;

namespace HireMe.WebApi.WorkExperiences;

#pragma warning disable CS8618 // data transfer object
public class WorkExperienceDto : EntityDto
{
    public string JobTitle { get; set; }

    public string Employer { get; set; }

    public List<string> Responsibilities { get; set; }

    public DateOnly From { get; set; }

    public DateOnly? To { get; set; }

    public string Location { get; set; }
}
