using System;

public abstract class Robot
{
    public string ModelName { get; set; }
    public int BatteryCapacity { get; set; }
    public string SoftwareVersion { get; set; }

    public abstract Robot Clone();
    public abstract void DisplayInfo();
}


public class ServiceRobot : Robot
{
    public string ServiceTask { get; set; }

    public override Robot Clone()
    {
        return (Robot)this.MemberwiseClone();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Service Robot: {ModelName}, Battery: {BatteryCapacity}h, OS: {SoftwareVersion}, Task: {ServiceTask}");
    }
}

public class IndustrialRobot : Robot
{
    public string IndustrialTask { get; set; }

    public override Robot Clone()
    {
        return (Robot)this.MemberwiseClone();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Industrial Robot: {ModelName}, Battery: {BatteryCapacity}h, OS: {SoftwareVersion}, Task: {IndustrialTask}");
    }
}

public class EntertainmentRobot : Robot
{
    public string EntertainmentFeature { get; set; }

    public override Robot Clone()
    {
        return (Robot)this.MemberwiseClone();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Entertainment Robot: {ModelName}, Battery: {BatteryCapacity}h, OS: {SoftwareVersion}, Feature: {EntertainmentFeature}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        ServiceRobot baseRobot = new ServiceRobot
        {
            ModelName = "CareBot",
            BatteryCapacity = 12,
            SoftwareVersion = "v1.0",
            ServiceTask = "Healthcare"
        };

        
        ServiceRobot clonedRobot = (ServiceRobot)baseRobot.Clone();
        clonedRobot.BatteryCapacity = 24;
        clonedRobot.SoftwareVersion = "v1.2";

    
        baseRobot.DisplayInfo();
        clonedRobot.DisplayInfo();
    }
}