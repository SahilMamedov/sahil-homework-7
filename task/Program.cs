using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
          Console.WriteLine("Please enter your name");
            user.username = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            user.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your password");
            user.password = Console.ReadLine();
          
          
            
            

        }
    }
}
