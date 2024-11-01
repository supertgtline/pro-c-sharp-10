// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
//TimerCallback timerCallback = new TimerCallback(PrintTimer);
_ = new Timer(
    PrintTimer, // The TimerCallback delegate object.
    "Hello from C# 10.0", // Any info to pass into the called method (null for no info).
    0, // Amount of time to wait before starting (in milliseconds).
    1000); // Interval of time between calls (in milliseconds)._
_ = new Timer(
    Add, // The TimerCallback delegate object.
    "Hello from C# 10.0", // Any info to pass into the called method (null for no info).
    0, // Amount of time to wait before starting (in milliseconds).
    1000); // Interval of time between calls (in milliseconds).
Console.WriteLine("Hit Enter key to terminate...");
Console.ReadLine();

static void PrintTimer(object? state)
{
    Console.WriteLine("Time is: {0}. Param is {1}",
        DateTime.Now.ToLongTimeString(), state.ToString());
}

static void Add(object? state)
{
    Console.WriteLine("Time is: {0}. Param is {1}",
        2 + 2, 4);
}