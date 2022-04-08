using GraphQL.AspnetCore.Client;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private readonly OwnerConsumer _consumer;

    public ValuesController(OwnerConsumer consumer)
    {
        _consumer = consumer;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var owners = await _consumer.GetAllOwners();
        return Ok(owners);
    }
  
}