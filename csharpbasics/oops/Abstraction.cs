namespace csharpbasics;

// Abstract class
public abstract class Worker
{
    public string Name;
    public abstract void work();
    public void takeRest()
    {
        Console.WriteLine("Sleep");
    }
}

public class FinanceWorker : Worker
{
    public override void work()
    {
        Console.WriteLine("Perform daily tasks");
    }

    public void Exercise()
    {
        Console.WriteLine("Exercise");
    }
}
