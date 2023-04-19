namespace ProgramSpaceTwo
{
    public enum Post
    {
        Accountant = 164,
        Engineer = 180,
        Electrician = 150,
        Mechanic = 154,
        Agronomist = 170,
        Programmer = 160,
        Builder = 100
    }

    public class Accauntant
    {
        private int hours;
        // конструктор
        public Accauntant()
        {
            hours = 0;
        }
        public void Foreaching()
        {
            foreach (string post in Enum.GetNames(typeof(Post)))
            {
                Console.Write($"Введите, cколько времени проработал за этот месяц {post}: ");
                hours = Convert.ToInt32(Console.ReadLine());
                Enum.TryParse<Post>(post, true, out Post postEnum);
                Console.WriteLine($"Полагается ли {post} премия: {AskForBonus(postEnum, hours)}");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Решени, начислять бонус или нет
        /// </summary>
        /// <param name="worker"> Перечисление профессий </param>
        /// <param name="hours"> Время работы работника </param>
        /// <returns></returns>
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Legacy : Accauntant
    {
        private int d;
        // конструктор
        public Legacy()
        {
            d = 0;

        }
        public int Legacy_Result()
        {
            int a = 12;
            int b = 0;
            int oneYers = 0;
            int[] enums = (int[])Enum.GetValues(typeof(Post));
            int sizeEnum = Enum.GetNames(typeof(Post)).Length;
            for (int i = 0; i < sizeEnum; i++)
            {
                d = enums[i];
                oneYers += a * (b + d);
            }
            return oneYers;

        }
    }

    public class ProgramMain
    {
        public static void Main()
        {
            Accauntant acc = new Accauntant();
            acc.Foreaching();

            Legacy l = new Legacy();
            Console.WriteLine($"{l.Legacy_Result()} Часов в год на работников.");
        }
    }
}
