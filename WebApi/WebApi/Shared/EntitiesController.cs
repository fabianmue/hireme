using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HireMe.WebApi.Shared;

[ApiController]
[Route("[controller]")]
public abstract class EntitiesController<TEntity>(WebApiContext context) : ControllerBase
    where TEntity : Entity
{
    protected readonly WebApiContext Context = context;

    protected readonly DbSet<TEntity> DbSet = context.Set<TEntity>();

    [HttpGet]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<TEntity>>> ReadAsync()
    {
        return Ok(await DbSet.ToListAsync());
    }

    [HttpGet("{id:int}")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TEntity>> ReadByIdAsync([FromRoute] int id)
    {
        if (!DbSet.Any(entity => entity.Id == id))
        {
            return NotFound();
        }

        return await DbSet.SingleAsync(entity => entity.Id == id);
    }
}
