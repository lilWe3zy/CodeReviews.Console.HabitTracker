using System.ComponentModel.DataAnnotations;
namespace HabitTracker.lilWe3zy.Models;

public class Habit
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public string? UnitOfMeasurement { get; set; }
    [DataType(DataType.Date)]
    public DateTime CreationDate { get; set; }
}