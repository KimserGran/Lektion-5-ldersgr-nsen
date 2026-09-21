using System.Runtime.CompilerServices;

namespace _14.Mönstermatchning_med_Switch_och_Property_matching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt användarnamn");
            string användare = Console.ReadLine();
            int i = 0;
            i = användare == "Admin" ? 1 : 0;
            User user = new User(i, användare);
            Console.WriteLine( user.IsAdmin == true 
                ? "Du är en Admin"
                : "Du är en User");

        }
    }
    class User
    {
        string name;
        public bool IsAdmin { get; }

         public User(int i, string name)
        {
            IsAdmin = (i == 1);
            this.name = name;

        }
    }
}
