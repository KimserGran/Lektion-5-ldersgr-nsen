namespace _2._Dörrvakten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("Du är tillräckligt gammal");
            else Console.WriteLine("Du är inte gammal nog");
        }
    }
    a
}
