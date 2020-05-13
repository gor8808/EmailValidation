using System;

namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("Enter customer email adrass");
            string enteredEmail = Console.ReadLine();
            car.Email = enteredEmail;
            string emailAddress = car.Email;
            if (emailAddress == string.Empty)
            {
                Console.WriteLine($"email addrass you entered is invalid {enteredEmail}");
            }
            else
                Console.WriteLine($"email addrass you entered is vald -- {emailAddress}");
        }
    }
}