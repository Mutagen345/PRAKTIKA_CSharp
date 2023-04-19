public class Animal
{
    public int K { get; protected set; }
    public string Alias { get; private set; }
    public double Height { get; private set; }
    public Animal(string alias, double height, int k) { Alias = alias; Height = height; K = k; }
    public double GetWeight() => K * Height;
    public override string ToString() => $"Кличка: '{Alias}'; Рост: {Height}м., Вес: {GetWeight()}кг.";
}
public class Cat : Animal
{
    public string Breed { get; private set; }
    public Cat(string breed, string alias, double height) : base(alias, height, 15) => Breed = breed;
    public double GetWeightInGrams() => GetWeight() * 1000;
    public override string ToString() => $"Кошка. Порода: '{Breed}'; {base.ToString()}; Вес в граммах: {GetWeightInGrams()}г.";
    static void Main(string[] args)
    {
        Console.WriteLine(new Animal("Некто", 0.1, 13) + "\n" + new Cat("Шерстяная", "СобакаСутулая", 0.3));
        Console.ReadLine();
    }
}