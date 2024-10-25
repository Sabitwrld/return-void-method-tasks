namespace task1_return_void
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int nums = Convert.ToInt32(Console.ReadLine());

            int sum = sumOfNums(nums);
            Console.WriteLine("Sum of numbers (return method): " + sum);

            printSumNums(nums);
        }
        public static int sumOfNums(int nums)
        {
            int sum = 0;
            for (int i = 1; i <= nums; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static void printSumNums(int nums)
        {
            int sum = 0;
            for (int i = 1; i <= nums; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of numbers (void method): " + sum);
        }
    }
}
