using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZADACHA
{
    public struct Aeroflot
    {
        public string name;
        public int nomer;
        public string tip;


        public Aeroflot(string n)
        {
            name = n;
            nomer = 0;
            tip = n;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n\tНазвание пункта назначения - ");
            sb.Append(this.name);
            sb.Append("\n\tНомер рейса - ");
            sb.Append(this.nomer);
            sb.Append("\n\tТип самолета - ");
            sb.Append(this.tip);
            return sb.ToString();

        }
        class Program
        {
            const int a = 7;

            static void Main(string[] args)
            {

                Aeroflot[] rais = new Aeroflot[a];

                for (int i = 0; i < a;)
                {
                    try
                    {
                        Aeroflot fligt = new Aeroflot();
                        Console.WriteLine("Введите название пункта назначения:");
                        fligt.name = Console.ReadLine();
                        Console.WriteLine("Введите номер рейса:");
                        fligt.nomer = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите тип самолета:");
                        fligt.tip = Console.ReadLine();
                        rais[i] = fligt;
                        i++;
                        Console.WriteLine(fligt);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: введено неправильное значение!");
                    }

                }
                Console.WriteLine("\nСписок всех рейсов:");
                IEnumerable<Aeroflot> query = rais.OrderBy(st => st.nomer);
                foreach (Aeroflot st in query)
                {
                    Console.WriteLine(st.ToString());
                }

                Console.ReadKey();
            }
        }
    }
}

