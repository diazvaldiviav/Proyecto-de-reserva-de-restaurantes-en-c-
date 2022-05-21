class Payment
{
    public string[] card;
           int paypal;
   public string type;
  

    public void cardOrPaypal()
    {
        Payment typeOfPay = new Payment();

        System.Console.WriteLine("How would you like want to pay paypal or card (Write in lowercase please): ");
        typeOfPay.type = System.Console.ReadLine();

        if(typeOfPay.type == "card")
        {
            typeOfPay.card = new string[1]{""};
            int index = 0;
            int longitudArray = typeOfPay.card.Length;
            System.Console.WriteLine("Write the number of your card please\n");
            
                 while (index < longitudArray)
                   {
                    typeOfPay.card[index] = System.Console.ReadLine();
                    System.Console.WriteLine($"Your card number is {typeOfPay.card[index]}, \n Would you like to pay(yes or not): \n");

                    string pagar = System.Console.ReadLine();
                     
                    if(pagar == "yes")
                {
                    System.Console.WriteLine("Thanks for reserve with us. \n\n");
                }
                else
                {
                    System.Console.WriteLine("You have not reserved.");
                    System.Environment.Exit(0);
                }

                index++;
                     
                   }


                 








        }

    }
}