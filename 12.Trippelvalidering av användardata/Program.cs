namespace _12.Trippelvalidering_av_användardata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heltal = int.TryParse(Console.ReadLine(), out int result) 
                ? result 
                : throw new ArgumentException("Nu blev det Fel! kan inte tydas som heltal.");
            switch (result)
               {
                case < 0 when result % 2 == 0:
                    Console.WriteLine("talet är negativt och jämt");
                    break;
                case > 0 when result % 2 == 0:
                    Console.WriteLine("talet är jämt!");
                    break;
                case < 0 when result % 2 != 0:
                    Console.WriteLine("talet är negativt och udda!");
                    break;
                case > 0 when result % 2 != 0:
                    Console.WriteLine("talet är udda!");
                    break;
                case 0:
                    Console.WriteLine("Talet är 0");
                    break;


            }
        }
    }
}
