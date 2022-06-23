// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
    
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       var stopWatch = new StopWatch();
       stopWatch.Start();
       System.Threading.Thread.Sleep(10000);
       stopWatch.Stop();
       Console.WriteLine(stopWatch.Duration);
       
       stopWatch.Start();
       System.Threading.Thread.Sleep(2000);
       stopWatch.Stop();
       Console.WriteLine(stopWatch.Duration);
    }
}

public class StopWatch
{
    private bool _isOn;
    private DateTime _startTime { get; set; }
    private DateTime _stopTime { get; set; }
    public TimeSpan Duration
    {
        get
        {
            return _stopTime - _startTime;
        }
    }
    
    public void Start()
    {
        if(!_isOn)
        {
            _isOn = true;
            _startTime = DateTime.Now;
        }
        else
        {
            throw new InvalidOperationException("Cannot start without stopping");
        }
    }
    
    public void Stop()
    {
        if(_isOn)
        {
            _isOn = false;
            _stopTime = DateTime.Now;
        }
        else
        {
            throw new InvalidOperationException("Cannot stop without starting");
        }
    }
}