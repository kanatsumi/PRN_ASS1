// See https://aka.ms/new-console-template for more information
using DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System.Net;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
        => services.AddDbContext<SaleDbContext>();
}

