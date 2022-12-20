namespace LinqTutorial_20dec2022_1_MinMax;

internal class Program
{
    static void Main(string[] args)
    {
        var pets = new[]
    {
        new Pet(1, "Hannibal", PetType.Fish, 1.1f),
        new Pet(2, "Anthony", PetType.Cat, 2f),
        new Pet(3, "Ed", PetType.Cat, 0.7f),
        new Pet(4, "Taiga", PetType.Dog, 35f),
        new Pet(5, "Rex", PetType.Dog, 40f),
        new Pet(6, "Lucky", PetType.Dog, 5f),
        new Pet(7, "Storm", PetType.Cat, 0.9f),
        new Pet(8, "Nyan", PetType.Cat, 2.2f)
    };
        var minWeight = pets.Min(pet => pet.Weight);
        Console.WriteLine($"{nameof(minWeight)}: {minWeight}");
        var maxWeight = pets.Max(pet => pet.Weight);
        Console.WriteLine($"{nameof(maxWeight)}: {maxWeight}");

        var minPet = pets.Min();
        Console.WriteLine($"{nameof(minPet)}: {minPet.Name}, {minPet.Weight}");

        var emptyNumbers = new int[0];
        var minimalNumber = emptyNumbers.Min(); /*collection must not be empty!*/

        Console.WriteLine("\n");

        var numbers = new[] { 16, 8, 9, -1, 2 };
        var smallest = numbers.Min(number => number);
        Console.WriteLine($"{smallest}");

        var largest = numbers.Max(number => number);
        Console.WriteLine($"{largest}");

        var largest2 = numbers.Max();
        Console.WriteLine($"{largest2}");

    }
}