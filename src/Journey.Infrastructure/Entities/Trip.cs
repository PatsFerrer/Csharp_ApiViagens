namespace Journey.Infrastructure.Entities;
public class Trip
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty; // não vai ser nulo e sim vazio
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public IList<Activity> Activities { get; set; } = []; // não vai ser nulo e sim vazio
}
