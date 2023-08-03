namespace GopherAPI.Data;

public class GopherContext :  DbContext
{
    public GopherContext(DbContextOptions<GopherContext> options) : base(options) { }
    public DbSet<Gopher> Gophers { get; set; }
}