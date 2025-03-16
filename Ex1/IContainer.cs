namespace Ex1;

public interface IContainer
{
    double Mass { get; set; }
    int Height { get; set; }
    int Weight { get; set; }
    int Depth { get; set; }
    int SerialNumber { get; set; }
    int MaxCapacity { get; set; }

    void Unload();
    void Load(double Mass);
}