using System.ComponentModel.DataAnnotations;
using HireMe.WebApi.Shared;
using Microsoft.EntityFrameworkCore;

namespace HireMe.WebApi.WorkExperiences;

public class WorkExperience : Entity
{
    [
        Comment("Official job title"),
        Required(AllowEmptyStrings = false),
        StringLength(64, MinimumLength = 8)
    ]
    public required string JobTitle { get; set; }

    [
        Comment("Company, institution or alike"),
        Required(AllowEmptyStrings = false),
        StringLength(64, MinimumLength = 4)
    ]
    public required string Employer { get; set; }

    public required List<string> Responsibilities { get; set; } = [];

    [Comment("Start date"), Required, DataType(DataType.Date)]
    public required DateOnly From { get; set; }

    [Comment("End date, null means still active"), DataType(DataType.Date)]
    public DateOnly? To { get; set; }

    [
        Comment("Office location"),
        Required(AllowEmptyStrings = false),
        StringLength(32, MinimumLength = 4)
    ]
    public required string Location { get; set; }
}
