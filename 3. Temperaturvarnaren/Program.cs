namespace _3._Temperaturvarnaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är dagens temperatur?");
            double temp = int.Parse(Console.ReadLine());
            if (temp < 0)
                Console.WriteLine($"Det är minusgrader ute {temp}°C");
            else Console.WriteLine($"Det är plusgrader ute {temp}°C");
        }
    }
}
