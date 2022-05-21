using System;

namespace Restaurant10TablesReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string decision;
         
 
            Person personUno = new Person();
            Console.WriteLine("Welcome to our restaurant, What is your name: \n");
            personUno.Nombre = Console.ReadLine();

            Console.WriteLine("What is your ID: \n");
            personUno.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your email: \n");
            personUno.email = Console.ReadLine();

            Console.WriteLine("How meny people are you: \n");
            personUno.cantidad =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Are you agree: (write not if you are not agree or write yes if you are agree)");
            decision = Console.ReadLine();

            if (decision == "yes")
            {
                Payment payment = new Payment();
                payment.cardOrPaypal();
                personUno.dataPerson();
            }
          
          

          
        }

       

    }
}
