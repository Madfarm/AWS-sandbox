namespace GopherAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GopherController : ControllerBase
{
    public GopherController(GopherContext context)
    {
        _context = context;
    }
    // [HttpGet]
    // public async <ActionResult<List<Gopher>>> GetGophers()
    // {
    //     var output = await _context.Gophers.ToList();
    // }

    // [HttpGet]
    // public Task<> GetGopher()
    // {

    // }
}