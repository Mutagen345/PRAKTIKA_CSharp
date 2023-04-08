namespace ZADACHA2.Models
{
    public class Product : Detail
    {
        int count;
        string name_product;
        public Product() : base()
        {
            count = 0;
            name_product = string.Empty;
            Input();
        }
        void Input()
        {
            Console.WriteLine("Введите название изделия");
            name_product = Console.ReadLine();
            Console.WriteLine("Введите количество механизмов в изделии");
            count = Convert.ToInt32(Console.ReadLine());
        }
        public override string Vivod()
        {
            return base.Vivod() + " Название изделия - " + name_product + " Количество механизмов в изделии - " + count + " ";
        }
    }
}
