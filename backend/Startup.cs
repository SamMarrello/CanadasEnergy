using backend.Persistence;
using Microsoft.EntityFrameworkCore;

namespace backend;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DataContext>(options =>
            options.UseNpgsql(Config.GetConnectionString("Connection")));
    }
}