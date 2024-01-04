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

    public required List<string> Responsibilities { get; set; } = [];

    [Comment("Start date"), Required, DataType(DataType.DateTime)]
    public required DateTime From { get; set; }

    [Comment("End date, null means still active"), DataType(DataType.DateTime)]
    public required DateTime? To { get; set; }

    [
        Comment("Office location"),
        Required(AllowEmptyStrings = false),
        StringLength(32, MinimumLength = 4)
    ]
    public required string Location { get; set; }
}
