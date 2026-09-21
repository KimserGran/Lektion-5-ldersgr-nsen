namespace _6._Inloggningskontroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt användarnamn");
            string användarNamn = Console.ReadLine();
            Console.WriteLine("Skriv ditt lösenord");
            string användarLösen = Console.ReadLine();


            if (användarNamn == "admin" && användarLösen == "hemligt123")
                Console.WriteLine("Inloggning lyckades");
            else Console.WriteLine("Fel namn eller lösen");
        }
    }
}
