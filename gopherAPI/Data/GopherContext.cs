namespace GopherAPI.Data;

public class GopherContext :  DbContext
{
    protected readonly IConfiguration Configuration;

    public GopherContext(IConfiguration configuration) => Configuration = configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("GopherContextPostgres"));
    }

    public DbSet<Gopher> Gophers { get; set; }
}