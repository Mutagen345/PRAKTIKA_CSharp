namespace ZADACHA2.Models
{
    public class Detail
    {
        string name_detail, material;
        int number;
        public Detail()
        {
            this.name_detail = String.Empty;
            this.number = 0;
            this.material = String.Empty;
            Vvod();
        }
        public void Vvod()
        {
            Console.WriteLine("Введите название детали");
            name_detail = Console.ReadLine();
            Console.WriteLine("Введите номер детали");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите материал детали");
            material = Console.ReadLine();
        }
        public virtual string Vivod()
        {
            return "Название детали - " + name_detail + " Номер детали - " + number + "Материал детали -" + material + " ";
        }
    }
}