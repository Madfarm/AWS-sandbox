namespace GopherAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GopherController : ControllerBase
{
    private GopherContext _context;
    public GopherController(GopherContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Gopher>> GetGophers()
    {
        if (_context.Gophers.Count() != 0)
        {
            var output = _context.Gophers.ToList();
            return output;
        }

        return NoContent();
    }

    [HttpGet("{id}")]
    public ActionResult<Gopher> GetGopher(int id)
    {
        var gopher = _context.Gophers.Find(id);

        if (gopher == null)
        {
            return NotFound();
        }

        return gopher;
    }

    [HttpPost]
    public async Task<ActionResult<Gopher>> CreateGopher([FromBody] CreateGopherDto newGoph)
    {
        Gopher gopher = new()
        {
            Name = newGoph.Name,
            Age = newGoph.Age
        };

        _context.Gophers.Add(gopher);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetGopher), new { id = gopher.Id }, gopher);
    }

}