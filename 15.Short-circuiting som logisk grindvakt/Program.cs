namespace _15.Short_circuiting_som_logisk_grindvakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = null;
            if (text1 != null && text1.Length > 5)
                Console.WriteLine("Not null");
            else throw new NullReferenceException("Null Reference");
            if (text1.Length > 5 && text1 != null)
                Console.WriteLine("Not Null");
            else throw new NullReferenceException("a");

        }
    }
}
