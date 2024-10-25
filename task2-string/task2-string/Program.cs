namespace task2_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = " Code Academy ";

            Console.WriteLine(removeSpaces(name));
            
        }
        static string removeSpaces(string space)
        {
            string nonSpace = "";

            for (int i = 0; i < space.Length; i++)
            {

                char a =space[i];

                if (space[i] != ' ')
                {
                  nonSpace += a;
                }
            }
                 return nonSpace;           
        }
    }
}
