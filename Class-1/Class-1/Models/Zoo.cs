namespace Class_1.Models;

public class Zoo
{
    public Guid Id { get; set; }

    public string Name { get; set; }
    
    public List<string> Animals { get; set; }
    
    public List<string> AnimalFoods { get; set; }
    
    public List<string> Workers { get; set; }
}
