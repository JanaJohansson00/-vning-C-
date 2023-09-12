namespace Övning_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, vad heter du?");

            string name = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur lång är du?");

            double length = double.Parse(Console.ReadLine());

            if ((age >= 18 && age <= 40) && length >= 1.60)
            {
                Console.WriteLine("Du får komma på evenemanget!");
            }
            else if ((age < 18 || age > 40) && length < 1.60)
            {
                Console.WriteLine("Du får tyvärr inte komma på evenemanget");
            }
        }

        

        
    }
}