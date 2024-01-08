using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HireMe.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false, comment: "Short, ideally one-word description"),
                    Proficiency = table.Column<int>(type: "integer", nullable: false, comment: "Rated from 1 to 5, where 5 indicates a high proficiency"),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()", comment: "Time of creation"),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "now()", comment: "Time of last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobTitle = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false, comment: "Official job title"),
                    Employer = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false, comment: "Company, institution or alike"),
                    Responsibilities = table.Column<List<string>>(type: "text[]", nullable: false),
                    From = table.Column<DateOnly>(type: "date", nullable: false, comment: "Start date"),
                    To = table.Column<DateOnly>(type: "date", nullable: true, comment: "End date, null means still active"),
                    Location = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false, comment: "Office location"),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()", comment: "Time of creation"),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "now()", comment: "Time of last modification")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedAt", "Description", "Proficiency" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 8, 21, 31, 53, 955, DateTimeKind.Utc).AddTicks(5647), "Full stack web development", 5 },
                    { 2, new DateTime(2024, 1, 8, 21, 31, 53, 955, DateTimeKind.Utc).AddTicks(5651), "Scrum", 4 },
                    { 3, new DateTime(2024, 1, 8, 21, 31, 53, 955, DateTimeKind.Utc).AddTicks(5652), "DevSecOps", 2 },
                    { 4, new DateTime(2024, 1, 8, 21, 31, 53, 955, DateTimeKind.Utc).AddTicks(5653), "CI / CD Pipelines", 3 },
                    { 5, new DateTime(2024, 1, 8, 21, 31, 53, 955, DateTimeKind.Utc).AddTicks(5654), "ASP.NET Core", 4 },
                    { 6, new DateTime(2024, 1, 8, 21, 31, 53, 955, DateTimeKind.Utc).AddTicks(5655), "Angular", 3 },
                    { 7, new DateTime(2024, 1, 8, 21, 31, 53, 955, DateTimeKind.Utc).AddTicks(5656), "GitLab", 2 }
                });

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "Id", "CreatedAt", "Employer", "From", "JobTitle", "Location", "Responsibilities", "To" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 8, 21, 31, 53, 955, DateTimeKind.Utc).AddTicks(5821), "GVZ Gebäudeversicherung Kanton Zürich", new DateOnly(2022, 3, 1), "Software engineer", "8050 Zürich", new List<string> { "Full stack web development of multiple applications to manage company core data", "Formation of a software development team; definition and implementation of development processes, evaluation and selection of technologies, quality insurance and testing", "Supervision and training of an apprentice specializing in application development (from 2023)" }, null },
                    { 2, new DateTime(2024, 1, 8, 21, 31, 53, 955, DateTimeKind.Utc).AddTicks(5825), "M&F Engineering AG Zürich", new DateOnly(2018, 1, 1), "Software engineer in the trainee programme", "8951 Fahrweid", new List<string> { "Trainee programme for university graduates; collaboration with teams at various partner companies, coaching by senior developers, workshops for hard and soft skills", "Usage of various technologies, application of different development processes, getting to know companies in different industries", "Assignments of 12+ months at AskMeWhy AG, Qualivision AG and EBP Schweiz AG" }, new DateOnly(2021, 10, 31) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "WorkExperiences");
        }
    }
}
