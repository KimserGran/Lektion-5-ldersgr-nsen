namespace _7._Rabattväljaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Är du student? ja/nej");
            string ärStudent = Console.ReadLine();
            if (ärStudent == "ja")
            {
                Console.WriteLine("har du mecenatkort? ja/nej");
                string harKort = Console.ReadLine();
                if (harKort == "ja")
                    Console.WriteLine("Du får 20% rabatt");
                else Console.WriteLine("Du får 10% rabatt");
            }
            else
                Console.WriteLine("Du är inte berättigad rabatt");
        }
    }
}
