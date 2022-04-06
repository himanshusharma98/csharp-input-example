using System;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------");
            Console.WriteLine("Enter Your Username:-");
            Console.WriteLine("Enter Your Email:-");
            string userName = Console.ReadLine();
            string email = Console.ReadLine();  
            Console.WriteLine("Username is:-" + userName);
            Console.WriteLine("Email is:-" + email);
            Console.WriteLine("---------------------");
        }
    }
}
