namespace _5._Medlemsstatus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken medlems nivå är du? \n1: Basic\n2: Standard\n3: Premium\nSkriv antingen siffra eller nivå");
            string medlemsNivå = Console.ReadLine().ToLower();
            string nivå = medlemsNivå switch
            {
                "1" or "basic" => "Basic",
                "2" or "standard" => "Standard",
                "3" or "premium" => "Premium",
                _ => "Skriv enligt instruktionerna bara"
            };
            Console.WriteLine($"Du är nivå: {nivå}");
        }
    }
}
