namespace _11._Textanalysatorn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv antingen Hejsan, valfritt + !");
            string textCheck = Console.ReadLine();

            switch (textCheck)
            {
                case string s when s == null:
                    Console.WriteLine("Texten är tom...");
                    break;
                case string s when s.StartsWith("Hejsan"):
                    Console.WriteLine("Hej!" + s);
                    break;
                case string s when s.EndsWith("!"):
                    Console.WriteLine("Du avslutade med utropsteckning");
                    break;
                default:
                    Console.WriteLine("Du skrev " + textCheck);
                    break;
            }
        }
    }
}
