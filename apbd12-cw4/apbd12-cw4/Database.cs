using apbd12_cw4.Models;

namespace apbd12_cw4;

public class Database
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal
        {
            Id = 1, 
            Name = "Fruzia", 
            Type = "Kot", 
            Weight = 6.2f, 
            FurColor = "Rudy"
        },
        new Animal
        {
            Id = 2, 
            Name = "Henio", 
            Type = "Pies", 
            Weight = 9.3f, 
            FurColor = "Brunatny"
        },
        new Animal
        {
            Id = 3, 
            Name = "Kotunio", 
            Type = "Kot", 
            Weight = 7.1f, 
            FurColor = "Bialy"
        }
    };

    public static List<Appointment> Appointments = new List<Appointment>()
    {
        new Appointment
        {
            VisitDate = DateTime.Parse("2025-07-07T13:00:00"),
            AnimalId = 1,
            Description = "Czipowanie",
            Price = 50
        },
        new Appointment
        {
            VisitDate = DateTime.Parse("2025-05-19T14:15:00"),
            AnimalId = 2,
            Description = "Kastracja",
            Price = 700
        },
        new Appointment
        {
            VisitDate = DateTime.Parse("2025-04-20T16:30:00"),
            AnimalId = 3,
            Description = "Badania podstawowe",
            Price = 100
        }
    };
}