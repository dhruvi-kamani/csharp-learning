namespace csharpbasics;
public class Bank
{
    public virtual int getInterestRate()
    {
        return 10;
    }
}

public class IciciBank : Bank
{
    public override int getInterestRate()
    {
        return 5;
    }
}

public class HdfcBank : Bank
{
    public override int getInterestRate()
    {
        return 7;
    }
}

