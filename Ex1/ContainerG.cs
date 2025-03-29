namespace Ex1;

public class ContainerG : IContainer, IHazardNotifier
{
    public double Mass { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public string SerialNumber { get; }
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
    
    public ContainerG(double mass, int height, int weight, int depth, int index) {
        Load(mass);
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = GenerateSerialNumber(ContainerType.G, index);
    }

    public string GenerateSerialNumber(ContainerType type, int index)
    {
        return $"KON-{type.ToString()}-{index}";
    }
}