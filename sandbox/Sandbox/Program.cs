using System;

class Program
{
    static void Main(string[] args)
    {
        SmartLight light = new SmartLight();
        Thread.Sleep(1000);
        string time = light.Off();
        Console.WriteLine(time);
    
    }
}







