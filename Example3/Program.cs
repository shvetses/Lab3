namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;                
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();
        }
    }
}
