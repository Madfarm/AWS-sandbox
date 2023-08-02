namespace GopherAPI.Data;

public class GopherContext :  DbContext
{
    protected readonly IConfiguration Configuration;

    public GopherContext(DbContextOptions<DbContext> options) : base(options) { }
    public DbSet<Gopher> Gophers { get; set; }

    
}