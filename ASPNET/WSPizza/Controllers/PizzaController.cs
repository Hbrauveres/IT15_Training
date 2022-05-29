using Microsoft.AspNetCore.Mvc;

namespace WSPizzaria.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    private readonly ILogger<PizzaController> _logger;

    public PizzaController(ILogger<PizzaController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Pizza> GetAll()
    {
        return PizzaServices.GetAll();
    }

    [HttpGet("{id}")] //.../pizza/1
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public ActionResult<Pizza> GetById(int id)
    {
        _logger.LogInformation($"GET pizza por id={id}");
       
        var pizza = PizzaServices.GetPizza(id); 
        
        if (pizza is null) return NotFound();
        return pizza;
    }

    [HttpPut]
    public ActionResult<Pizza> Create(Pizza pizza)
    {
        _logger.LogInformation($"Criar pizza: {pizza}");
        PizzaServices.Add(pizza);
        return CreatedAtAction(nameof(GetById), new {id=pizza.Id}, pizza);      
    }

    [HttpDelete("{id}")] // .../pizza/1
    public IActionResult Delete(int id)
    {
        var pizza = PizzaServices.GetPizza(id);
        if (pizza is null) return NotFound();
        PizzaServices.Delete(id);
        return NoContent();
    }
}   
