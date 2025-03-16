namespace Ex1;

public class ContainerG : IContainer, IHazardNotifier
{
    public double Mass { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public int SerialNumber { get; set; }
    public int MaxCapacity { get; set; } 
    int Pressure { get; set; }

    public void Unload()
    {
        Mass *= 0.95;
    }

    public void Load(double mass)
    {
        if (Mass > MaxCapacity) throw new ArgumentException();
        Mass = mass;
    }

    public void SendMessage(int containersNumber)
    {
        throw new NotImplementedException();
    }
}