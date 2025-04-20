using apbd12_cw4.Models;
using Microsoft.AspNetCore.Mvc;

namespace apbd12_cw4.Controllers;

[ApiController]
[Route("api/[controller]")]

public class AnimalsController : ControllerBase
{
    
    //GET api/animals
    [HttpGet]
    public IActionResult Get()
    {
        var database = Database.Animals;
        return Ok(database);
    }

    //GET api/animals/id
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var animal = Database.Animals.FirstOrDefault(x => x.Id == id);
        if (animal == null)
            return NotFound();
        return Ok(animal);
    }
    
    //POST api/animals
    //i w jsonie {"Id": int, "Name": string,
    //"Type": string, "Weight": float, "FurColor": string}
    [HttpPost]
    public IActionResult Add(Animal animal)
    {
        if (Database.Animals.Any(a => a.Id == animal.Id))
            return BadRequest();
        
        Database.Animals.Add(animal);
        return Created();
    }
    
    //PUT api/animals
    //id jest wychwytywane z jsona
    [HttpPut]
    public IActionResult Update(Animal animal)
    {
        
        var currentAnimal = Database.Animals.FirstOrDefault(x => x.Id == animal.Id);
        if(currentAnimal == null)
            return NotFound();
        currentAnimal.Name = animal.Name;
        currentAnimal.Type = animal.Type;
        currentAnimal.Weight = animal.Weight;
        currentAnimal.FurColor = animal.FurColor;
        return Ok(currentAnimal);
    }
    
    //DELETE api/animals
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var animal = Database.Animals.FirstOrDefault(x => x.Id == id);
        if (animal == null)
            return NotFound();
        Database.Animals.Remove(animal);
        return Ok();
    }
    
    //GET api/animals/name
    [HttpGet("byName/{name}")]
    public IActionResult GetByName(string name)
    {
        var animal = Database.Animals.FirstOrDefault(x => x.Name == name);
        if(animal == null)
            return NotFound();
        return Ok(animal);
    }
}