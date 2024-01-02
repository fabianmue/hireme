using System.Net.Mime;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HireMe.WebApi.Shared;

[ApiController]
[Route("[controller]")]
public abstract class EntitiesController<TEntity, TEntityDto, TEntityWriteDto>(
    WebApiContext context,
    IMapper mapper
) : ControllerBase
    where TEntity : Entity
    where TEntityDto : EntityDto
    where TEntityWriteDto : EntityWriteDto
{
    protected readonly WebApiContext Context = context;

    protected readonly DbSet<TEntity> DbSet = context.Set<TEntity>();

    protected readonly IMapper Mapper = mapper;

    [HttpGet]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<TEntityDto>>> ReadAsync()
    {
        List<TEntity> entities = await DbSet.AsNoTracking().ToListAsync();
        return Ok(Mapper.Map<List<TEntityDto>>(entities));
    }

    [HttpGet("{id:int}")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TEntityDto>> ReadByIdAsync([FromRoute] int id)
    {
        if (!DbSet.Any(entity => entity.Id == id))
        {
            return NotFound();
        }

        TEntity entity = await DbSet.AsNoTracking().SingleAsync(entity => entity.Id == id);
        return Ok(Mapper.Map<TEntityDto>(entity));
    }

    [HttpPost]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TEntityDto>> CreateAsync([FromBody] TEntityWriteDto writeDto)
    {
        TEntity entity = Mapper.Map<TEntity>(writeDto);
        await DbSet.AddAsync(entity);
        await Context.SaveChangesAsync();

        var dto = Mapper.Map<TEntityDto>(entity);
        return Created(Url.Action(nameof(ReadByIdAsync), new { id = dto.Id }), dto);
    }

    [HttpPut("{id:int}")]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TEntityDto>> UpdateAsync(
        [FromRoute] int id,
        [FromBody] TEntityWriteDto writeDto
    )
    {
        if (!DbSet.Any(entity => entity.Id == id))
        {
            return NotFound();
        }

        TEntity entity = await DbSet.SingleAsync(entity => entity.Id == id);
        Mapper.Map(writeDto, entity);
        await Context.SaveChangesAsync();

        return Ok(Mapper.Map<TEntityDto>(entity));
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> DeleteAsync([FromRoute] int id)
    {
        if (!DbSet.Any(entity => entity.Id == id))
        {
            return NotFound();
        }

        TEntity entity = await DbSet.SingleAsync(entity => entity.Id == id);
        DbSet.Remove(entity);
        await Context.SaveChangesAsync();

        return Ok();
    }
}
