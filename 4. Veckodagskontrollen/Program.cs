namespace _4._Veckodagskontrollen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv ett heltal mellan 1-7 för veckans dagar");
            int dag = int.Parse(Console.ReadLine());
            string veckansDagar = dag switch
            {
                1 => "Måndag",
                2 => "Tisdag",
                3 => "Onsdag",
                4 => "Torsdag",
                5 => "Fredag",
                6 => "Lördag",
                7 => "Söndag",
                _=> "Bara heltal mellan 1-7"
            };
            Console.WriteLine(veckansDagar);
        }
    }
}
