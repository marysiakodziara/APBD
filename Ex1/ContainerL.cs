namespace Ex1;

public class ContainerL : IContainer, IHazardNotifier
{
    
    public double Mass { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public int SerialNumber { get; set; }
    public int MaxCapacity { get; set; }    
    private Boolean hasDangeurousCargo { get; set; }
    
    public void Load(double Mass)
    {
        if (hasDangeurousCargo)
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
}