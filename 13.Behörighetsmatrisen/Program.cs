namespace _13.Behörighetsmatrisen
{
    internal class Program
    {
        [Flags]
        enum Användarroller 
        {
            None = 0,
            Read = 1,
            Write = 2,
            Execute = 4

        }
        static void Main(string[] args)
        {
            Användarroller rollEtt = Användarroller.Read | Användarroller.Write;

            if(rollEtt.HasFlag(Användarroller.Read) && rollEtt.HasFlag(Användarroller.Write))
                Console.WriteLine("Rollen har både Read och Write rättigheter");
          
        }
    }
}
