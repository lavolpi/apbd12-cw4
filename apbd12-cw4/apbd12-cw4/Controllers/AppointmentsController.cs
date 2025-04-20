using apbd12_cw4.Models;
using Microsoft.AspNetCore.Mvc;

namespace apbd12_cw4.Controllers;

[ApiController]
[Route("api/[controller]")]

public class AppointmentsController : ControllerBase
{
    //GET api/appointments/id(zwierzaka)
    [HttpGet("{animalId}")]
    public IActionResult Get(int animalId)
    {
        var appointments = Database.Appointments.Where(x => x.AnimalId == animalId);
        if(!appointments.Any())
            return NotFound();
        return Ok(appointments);
    }
    
    //POST api/appointments
    //i w jsonie {"VisitDate": "YYYY-MM-DDTHMS",
    //"AnimalId": id,
    //"Description": string, "Price": decimal}
    [HttpPost]
    public IActionResult Add(Appointment appointment)
    {
        if (Database.Appointments.Any(a => a.VisitDate == appointment.VisitDate))
            return BadRequest();
        Database.Appointments.Add(appointment);
        return Created();
    }
}