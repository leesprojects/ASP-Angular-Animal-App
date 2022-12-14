using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  public class AnimalsController : BaseApiController
  {
    private readonly DataContext _context;
    public AnimalsController(DataContext context)
    {
      _context = context;
    }

    //E.g. api/animals/
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animals>>> GetAnimals() //Use <List> if you want to filtering etc...
    {
      return await _context.Animals.ToListAsync();
    }

    //E.g. api/animals/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Animals>> GetAnimal(int id)
    {
      return await _context.Animals.FindAsync(id);
    }
    
    [HttpPost]
    public async Task<ActionResult<Animals>> AddAnimal(Animals animal)
    {
      _context.Animals.Add(animal);
      await _context.SaveChangesAsync();
      Console.WriteLine(animal.CommonName + " added.");
      return animal;
    }
  }
}