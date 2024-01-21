using HireMe.WebApi.Shared;
using HireMe.WebApi.Skills;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(SkillProfile));
builder.Services.AddControllers();
builder.Services.AddDbContext<WebApiContext>(options =>
{
    var connectionStringBuilder = new NpgsqlConnectionStringBuilder
    {
        Host = builder.Configuration.GetValue<string>("HIREME_WEBAPI_DB_HOST")!,
        Database = builder.Configuration.GetValue<string>("HIREME_WEBAPI_DB_DATABASE")!,
        Username = builder.Configuration.GetValue<string>("HIREME_WEBAPI_DB_USERNAME")!,
        Password = builder.Configuration.GetValue<string>("HIREME_WEBAPI_DB_PASSWORD")!,
    };
    options.UseNpgsql(connectionStringBuilder.ConnectionString);
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
