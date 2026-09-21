namespace _8._Åldersgränser_på_bio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange din ålder för att få en ålderskategori");
            int age = int.Parse(Console.ReadLine());
            if(age >= 0 && age <= 6)
                Console.WriteLine("du tillhör Barntillåten kategori");
            else if(age >= 7 && age <= 10)
                Console.WriteLine("du tillhör 7 års kategori");
            else if (age >= 11 && age <= 14)
                Console.WriteLine("du tillhör 11 års kategori");
            else if (age >= 15)
                Console.WriteLine("tillhör 15 års kategori");
            else Console.WriteLine("Du har inte skrivit ett positivt heltal till din ålder");

        }
    }
}
