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
        modelBuilder
            .Entity<Skill>()
            .HasData(
                new Skill
                {
                    Id = 1,
                    Description = "Full stack web development",
                    Proficiency = 5,
                    CreatedAt = DateTime.UtcNow
                },
                new Skill
                {
                    Id = 2,
                    Description = "Scrum",
                    Proficiency = 4,
                    CreatedAt = DateTime.UtcNow
                },
                new Skill
                {
                    Id = 3,
                    Description = "DevSecOps",
                    Proficiency = 2,
                    CreatedAt = DateTime.UtcNow
                },
                new Skill
                {
                    Id = 4,
                    Description = "CI / CD Pipelines",
                    Proficiency = 3,
                    CreatedAt = DateTime.UtcNow
                },
                new Skill
                {
                    Id = 5,
                    Description = "ASP.NET Core",
                    Proficiency = 4,
                    CreatedAt = DateTime.UtcNow
                },
                new Skill
                {
                    Id = 6,
                    Description = "Angular",
                    Proficiency = 3,
                    CreatedAt = DateTime.UtcNow
                },
                new Skill
                {
                    Id = 7,
                    Description = "GitLab",
                    Proficiency = 2,
                    CreatedAt = DateTime.UtcNow
                }
            );
        modelBuilder
            .Entity<WorkExperience>()
            .HasData(
                new WorkExperience
                {
                    Id = 1,
                    JobTitle = "Software engineer",
                    Employer = "GVZ Gebäudeversicherung Kanton Zürich",
                    Responsibilities =
                    [
                        "Full stack web development of multiple applications to manage company core data",
                        "Formation of a software development team; definition and implementation of development processes, "
                            + "evaluation and selection of technologies, quality insurance and testing",
                        "Supervision and training of an apprentice specializing in application development (from 2023)"
                    ],
                    From = new DateOnly(2022, 3, 1),
                    Location = "8050 Zürich",
                    CreatedAt = DateTime.UtcNow
                },
                new WorkExperience
                {
                    Id = 2,
                    JobTitle = "Software engineer in the trainee programme",
                    Employer = "M&F Engineering AG Zürich",
                    Responsibilities =
                    [
                        "Trainee programme for university graduates; collaboration with teams at various partner companies, "
                            + "coaching by senior developers, workshops for hard and soft skills",
                        "Usage of various technologies, application of different development processes, "
                            + "getting to know companies in different industries",
                        "Assignments of 12+ months at AskMeWhy AG, Qualivision AG and EBP Schweiz AG"
                    ],
                    From = new DateOnly(2018, 1, 1),
                    To = new DateOnly(2021, 10, 31),
                    Location = "8951 Fahrweid",
                    CreatedAt = DateTime.UtcNow
                }
            );
    }
}
