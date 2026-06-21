using System.ComponentModel.DataAnnotations;

namespace Locatic.Entities;

public class Car
{
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    public string RegistrationNumber { get; set; } = string.Empty;

    public int Year { get; set; }

    public int NumberOfPlaces { get; set; }

    public decimal PricePerDay { get; set; }

    [Required]
    [StringLength(50)]
    public string FuelType { get; set; } = string.Empty;

    public int ModeleId { get; set; }
    public Modele Modele { get; set; } = null!;

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}