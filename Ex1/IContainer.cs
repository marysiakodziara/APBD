namespace Ex1;

public interface IContainer
{
    double Mass { get; set; }
    int Height { get; set; }
    int Weight { get; set; }
    int Depth { get; set; }
    string SerialNumber { get; }
    int MaxCapacity { get; set; }

    void Unload();
    void Load(double mass);
    
    string GenerateSerialNumber(ContainerType type, int index);
}