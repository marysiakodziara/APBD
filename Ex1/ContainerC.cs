using System.Linq.Expressions;
using System.Text;

namespace Ex1;

public class ContainerC : IContainer
{
    public double Mass { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public string SerialNumber { get; }
    public int MaxCapacity { get; set; } 
    string ProductType { get; set; }
    int Temperature { get; set; }

    public void Load(double mass)
    {
        throw new NotImplementedException();
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }
    
    public ContainerC(double mass, int height, int weight, int depth, int index) {
        Load(mass);
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = GenerateSerialNumber(ContainerType.C, index);
    }

    public string GenerateSerialNumber(ContainerType type, int index)
    {
        return $"KON-{type.ToString()}-{index}";
    }

    
    
}