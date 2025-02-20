namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int absoluteValue = number;
            if (number < 0)
            {
                absoluteValue = -number;
            }
            Console.WriteLine(absoluteValue);
            Console.ReadKey();
        }
    }
}
