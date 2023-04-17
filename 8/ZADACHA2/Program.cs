namespace Task_2
{
    public enum Post
    {
        Gardener = 150,
        Loader = 121,
        Uchitel = 150,
        Agronomist = 11,
        Programmer = 540,
        Builder = 7345,
        Analyst = 362,
    }
    public class Program
    {
        public static void Main()
        {
            foreach (string post in Enum.GetNames(typeof(Post)))
            {
                Console.Write($"Сколько времени проработал работник {post}: ");
                int hours = int.Parse(Console.ReadLine());
                Enum.TryParse<Post>(post, true, out Post postEnum);
                Console.WriteLine($"{post} премия: {GetBonusLoc(postEnum, hours)}");
                Console.WriteLine();
            }
        }
        public static string GetBonusLoc(Post worker, int hours)
        {
            Accauntant acc = new Accauntant();
            if (acc.AskForBonus(worker, hours))
            {
                return "Положена премия";
            }
            else
            {
                return "Не положена премия";
            }
        }
    }
    public class Accauntant
    {
        public Accauntant()
        {
        }
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
}
