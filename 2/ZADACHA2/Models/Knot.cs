namespace ZADACHA2.Models
{
    public class Knot : Detail
    {
        string name_knot;
        public Knot() : base()
        {
            this.name_knot = String.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название узла ");
            name_knot = Console.ReadLine();
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название узла - " + name_knot + " ";
        }

    }
}