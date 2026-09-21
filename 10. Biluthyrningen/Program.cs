namespace _10._Biluthyrningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur länge har du haft körkort?");
            int körkortsTid = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if(körkortsTid >= 3 && ålder >= 25)
                Console.WriteLine("Du får hyra en sportbil!");
        }
    }
}
