namespace csharpbasics;

public interface IFullName
{
    string GetFullName();
}

public interface IAge
{
    int age { get; set; }
}

public class BaseClass
{
    public string Name { get; set; }
}


public class DerivedClass : BaseClass, IFullName, IAge // Single class and multiple interface inheritance supported
{
    public string Surname { get; set; }
    public int age { get; set; }

    public string GetFullName() // Interface forcing method implementation
    {
        return Name + " " + Surname;
    }
}
