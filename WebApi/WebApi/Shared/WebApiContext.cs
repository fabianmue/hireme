using HireMe.WebApi.Skills;
using HireMe.WebApi.WorkExperiences;
using Microsoft.EntityFrameworkCore;

namespace HireMe.WebApi.Shared;

public class WebApiContext : DbContext
{
    public DbSet<Skill> Skills { get; set; } = default!;

    public DbSet<WorkExperience> WorkExperiences { get; set; } = default!;

    protected WebApiContext()
        : base() { }

    public WebApiContext(DbContextOptions<WebApiContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityConfiguration<>).Assembly);
    }
}
