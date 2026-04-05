internal class Program
{
    private static void Main(string[] args)
    {
        Dog d1 = new Dog("Lucky", "German Shepherd", 40);
        Dog d2 = new Dog("Tina", "Shar pei", 25);
        Dog d3 = new Dog("Rex", 10);
        Console.WriteLine(d1.Describe());
        Console.WriteLine(d2.Describe());
        Console.WriteLine(d3.Describe());
        Console.ReadKey();

    }
}

public class Dog
{
    private string _name;
    private string _breed;
    private int _weight;

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog(string name, int weight) : this(name, "mixed-breed", weight)
    {
        
    }

    public string Describe() 
    {
        string description;
        if (_weight < 5)
        {
            description = "tiny";
        }
        else if (_weight >= 5 && _weight < 30)
        {
            description = "medium";
        }
        else
        {
            description = "large";
        }
        return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {description} dog.";
    }
}