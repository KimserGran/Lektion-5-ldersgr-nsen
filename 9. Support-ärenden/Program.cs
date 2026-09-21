namespace _9._Support_ärenden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n100-199 = Hårdvarufel\n200-299 = Mjukvarufel");
            Console.Write("Ange felkod: ");
            int felkod = int.Parse(Console.ReadLine());

            string felpåkoden = felkod switch
            {
                >= 100 and <= 199 => "Hårdvarufel",
                >= 200 and <= 299 => "Mjukvarufel",
                _ => "Okänt fel"
            };

            Console.WriteLine(felpåkoden);
        }
    }
}
