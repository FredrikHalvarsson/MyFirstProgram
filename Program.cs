namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 15;
            if (num > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj, Lågt tal!");
            }

            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine($"Hej {namn}!");

            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}