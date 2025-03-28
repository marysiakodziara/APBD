namespace Ex1;

public class ContainerL : IContainer, IHazardNotifier
{
    
    public double Mass { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public string SerialNumber { get; set; }
    public int MaxCapacity { get; set; }    
    private Boolean HasDangerousCargo { get; set; }
    
    public void Load(double mass)
    {
        if (HasDangerousCargo)
        {
            
        }
        throw new NotImplementedException();
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public void SendMessage(int containersNumber)
    {
        throw new NotImplementedException();
    }
    
    public ContainerL(double mass, int height, int weight, int depth, int index) {
        Load(mass);
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = GenerateSerialNumber(ContainerType.L, index);
    }

    public string GenerateSerialNumber(ContainerType type, int index)
    {
        return $"KON-{type.ToString()}-{index}";
    }
}