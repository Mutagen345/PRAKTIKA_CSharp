namespace ZADACHA2.Models
{
    public class Mechanism : Detail
    {
        string name_mechanism;
        public Mechanism() : base()
        {
            this.name_mechanism = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название механизма");
            name_mechanism = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название механизма - " + name_mechanism + " ";
        }
    }
}