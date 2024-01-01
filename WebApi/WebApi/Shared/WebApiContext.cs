using Microsoft.EntityFrameworkCore;

namespace HireMe.WebApi.Shared;

public class WebApiContext : DbContext
{
    protected WebApiContext()
        : base() { }

    public WebApiContext(DbContextOptions<WebApiContext> options)
        : base(options) { }
}
