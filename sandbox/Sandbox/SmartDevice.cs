abstract public class SmartDevice
{
    bool _isOn;
    public bool isOn
    {
        get { return _isOn; }
    }
    DateTime _lastState = DateTime.Now;
    string _deviceName;

    public string Off()
    {
        DateTime now = DateTime.Now;
        TimeSpan diff = now - _lastState;
        _isOn = false;
        return diff.TotalSeconds.ToString();
    }
    public void On()
    {
        _isOn = true;
        _lastState = DateTime.Now;
    }
    public int TimeOn()
    {
        if (_isOn)
        {
            DateTime now = DateTime.Now;
        TimeSpan diff = now - _lastState;
        return (int)Math.Round(diff.TotalSeconds);
        }
        else
        {
            return 0;
        }
    }
    public void Report()
    {
        string state = "off";
        if (_isOn)
        {
            state = "on";
        }
        Console.WriteLine($"{_deviceName} Status: {state}");
    }
}