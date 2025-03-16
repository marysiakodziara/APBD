using System.ComponentModel;

namespace Ex1;

public class Containership
{
    List<Container> containers { get; set; }
    int MaxSpeed  { get; set; }
    int MaxNumberOfContainers  { get; set; }
    int WeightCapacity  { get; set; }
}