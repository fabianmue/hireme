using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HireMe.WebApi.Shared;

public abstract class Entity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Comment("Time of creation"), Required, DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }

    [Comment("Time of last modification"), DataType(DataType.DateTime)]
    public DateTime? ModifiedAt { get; set; }
}
