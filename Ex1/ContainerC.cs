namespace Ex1;

public class ContainerC : IContainer
{
    public double Mass { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public int SerialNumber { get; set; }
    public int MaxCapacity { get; set; } 
    string ProductType { get; set; }
    int Temperature { get; set; }

    public void Load(double Mass)
    {
        throw new NotImplementedException();
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }
}