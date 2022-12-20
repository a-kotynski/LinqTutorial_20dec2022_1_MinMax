using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial_20dec2022_1_MinMax;

public enum PetType
{
    Dog,
    Cat,
    Fish
}

public class PetByTypeComparer : IComparer<Pet>
{
    int IComparer<Pet>.Compare(Pet? x, Pet? y)
    {
        return x.Type.CompareTo(y.Type);
    }
}
public class PetComparerById : IEqualityComparer<Pet>
{
    bool IEqualityComparer<Pet>.Equals(Pet? x, Pet? y)
    {
        return x.Id == y.Id;
    }

    int IEqualityComparer<Pet>.GetHashCode(Pet obj)
    {
        return obj.Id;
    }
}
internal class Pet : IComparable<Pet>
{
    public Pet(int id, string name, PetType type, float weight)
    {
        Id = id;
        Name = name;
        Type = type;
        Weight = weight;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public PetType Type { get; set; }
    public float Weight { get; set; }

    public int CompareTo(Pet? other)
    {
        return Weight.CompareTo(other.Weight);
    }
}
