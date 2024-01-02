namespace HireMe.WebApi.Shared;

public abstract class EntityDto
{
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }
}
