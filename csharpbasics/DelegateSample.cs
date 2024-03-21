namespace csharpbasics;

public class DelegateSample
{
    private Action<string> logger;

    public DelegateSample(Action<string> logger)
    {
        this.logger = logger;
    }

    public void LogSomething()
    {
        this.logger("Logged something from DelegateSample"); // calling delegate so the actual function which was provided in constructor will run
    }
}
