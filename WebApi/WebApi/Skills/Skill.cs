using System.ComponentModel.DataAnnotations;
using HireMe.WebApi.Shared;
using Microsoft.EntityFrameworkCore;

namespace HireMe.WebApi.Skills;

public class Skill : Entity
{
    [
        Comment("Short, ideally one-word description"),
        Required(AllowEmptyStrings = false),
        StringLength(32, MinimumLength = 4)
    ]
    public required string Description { get; set; }

    [Comment("Rated from 1 to 5, where 5 indicates a high proficiency"), Required, Range(1, 5)]
    public required int Proficiency { get; set; }
}
