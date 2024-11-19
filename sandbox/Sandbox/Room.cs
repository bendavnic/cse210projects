public class Room
{
    List<SmartDevice> smartDevices= new List<SmartDevice>();
    public Room()
    {
    }
    public void AddDevice(SmartDevice device)
    {
        smartDevices.Add(device);
    }
    public void TurnOffLights()
    {
        foreach (SmartLight light in smartDevices)
        {
            light.Off();
        }
    }
    public void TurnOff(SmartDevice device)
    {
        device.Off();
    }
    public void TurnOffAll()
    {
        foreach(SmartDevice device in smartDevices)
        {
            device.Off();
        }
    }
    public void Report()
    {
        foreach(SmartDevice device in smartDevices)
        {
            device.Report();
        }
    }
    public void ReportOn()
    {
        foreach(SmartDevice device in smartDevices)
        {
            if (device.isOn)
            {
                device.Report();
            }
        }
    }
    public SmartDevice LongestOn()
    {
        SmartDevice longest = null;
        int longestTime = 0;
        foreach(SmartDevice device in smartDevices)
        {
            int time = device.TimeOn();
            if (time > longestTime)
            {
                longestTime = time;
                longest = device;
            }
        }
        return longest;
    }
}