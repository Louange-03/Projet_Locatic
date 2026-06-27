using System.ComponentModel.DataAnnotations;

namespace Locatic.Entities;

public class Reservation
{
    public int Id { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [Range(1, int.MaxValue)]
    public int ClientId { get; set; }

    public Client Client { get; set; } = null!;

    [Range(1, int.MaxValue)]
    public int CarId { get; set; }

    public Car Car { get; set; } = null!;
}