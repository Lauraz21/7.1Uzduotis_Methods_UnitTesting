using System;

namespace _7._1Uzduotis_Methods_UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("email: ");
            string email = Console.ReadLine();
            Console.WriteLine(IsEmailValid(email));
        }
        public static bool IsEmailValid(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}