namespace Locatic.Entities;

public class Reservation
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;

    public int CarId { get; set; }
    public Car Car { get; set; } = null!;
}