
namespace daze.dazeapp.tests.Dequeuer;

public class BleServiceWrapperMock
{
    public List<string> Results { get; set; }

    public BleServiceWrapperMock()
    {
        Results = new List<string>();
    }

    public async Task<object?> Command1()
    {
        Console.WriteLine("Start Command 1");
        await Task.Delay(2000);
        Console.WriteLine("End Command 1");
        return null;
    }

    public async Task<object?> Command2()
    {
        Console.WriteLine("Start Command 2");
        await Task.Delay(2000);
        Console.WriteLine("End Command 2");
        return null;
    }

    public async Task<object?> Command3()
    {
        Console.WriteLine("Start Command 3");
        await Task.Delay(2000);
        Console.WriteLine("End Command 3");
        return null;
    }

    public async Task<object?> Command4()
    {
        Console.WriteLine("Start Command 4");
        await Task.Delay(2000);
        Console.WriteLine("End Command 4");
        return null;
    }

    internal async Task<bool> CommandBool(bool v, int n)
    {
        Console.WriteLine("Before Command n = " + n);
        await Task.Delay(2000);
        Console.WriteLine("After Command n = " + n);

        return v;
    }
}