using System;
using System.Windows.Forms;

public class Time1 : Object
{
    private int hour;
    private int minute;
    private int second;

    public int Hour
    {
        get { return hour; }
        set { hour = value >= 0 && value < 24 ? value : 0; }
    }
    
    public int Minute
    {
        get { return minute; }
        set { minute = value >= 0 && value < 60 ? value : 0; }
    }

    public int Second
    {
        get { return second; }
        set { second = value >= 0 && value < 60 ? value : 0; }
    }

    public Time1()
    {
        SetTime(0, 0, 0);
    }

    public void SetTime(int hValue, int mValue, int sValue)
    {
        Hour = hValue;
        Minute = mValue;
        Second = sValue;
    }

    public string ToUniversalString()
    {
        return String.Format($"{hour:D2}:{minute:D2}:{second:D2}");
    }

    public string ToStandardString()
    {
        return String.Format("{0}:{1:D2}:{2:D2} {3}",
            hour == 12 || hour == 0 ? 12 : hour % 12,
            minute, second, hour < 12 ? "AM" : "PM");
    }
}

class TimeTest1
{
    static void Main(string[] args)
    {
        MyTimeClass time = new MyTimeClass();
        string output;

        time.SetTime(13, 17, 6);
        output = $"Universal time is: {time.ToUniversalString()}\n";
        output += $"Standard time is: {time.ToStandardString()}";

        MessageBox.Show(output, "Testing Class Time1");
    }
}