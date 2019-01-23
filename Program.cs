using System;

namespace w02
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Welcome to Doctor's advice!!!");
            var name = "";
            var age = 0;
            var issue = "";
            var visit = "";
            var temp = 0.0;
            var feedback = 'n';
            var rate = 0.0m;
            var fee=0.0;
            var discount=0.0;
            var visit_before = false;
            while (name == "")
            {

                Console.WriteLine("Enter your name");
                name = Console.ReadLine();

            }

            Console.WriteLine($"Hi {name} ");

            while (age == 0)
            {

                Console.WriteLine("Enter your age");
                age = Convert.ToInt32(Console.ReadLine());

            }

            if (age <= 5)
            {
                Console.WriteLine("You need to consult doctor directly!!");

            }

            if (age > 5)
            {
                Console.WriteLine("What is the health issue you are suffering with?");
                issue = Console.ReadLine();
                switch (issue)
                {
                    case "fever":
                        Console.WriteLine("You need to take paracetomol tablets twice a day!");
                        break;
                    case "cough":
                        Console.WriteLine("You need to take KUF-Q tablets twice a day!");
                        break;
                    case "cold":
                        Console.WriteLine("You need to take crocin tablets twice a day!");
                        break;
                  default:
                        Console.WriteLine("\n You need to take advil tablets twice a day!");
                        break;
                }
                Console.WriteLine("What is your body present temperature?");
                temp = Convert.ToDouble(Console.ReadLine());
                if(temp <= 99.0 ){
                 Console.WriteLine("You need to take total of 4 tablets in  two days after your meal!");
                }
                if(temp > 99.0){

                    Console.WriteLine("You need to take total of 8 tablets in  four days after your meal!");
                }
            
            
            
            Console.WriteLine("Have you used this app before? yes/no");
            visit = Console.ReadLine();
            if(visit=="yes")
            {
                discount=100;
                visit_before = true;
                fee=500-discount;
            }
            else{

                visit_before = false;
                fee=500;
            }
            Console.WriteLine($"Your fee is {fee}");
           
            Console.WriteLine("Was Doctor's Advice useful? y/n");
            feedback = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("How would you like to rate us?");
            rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Thank you!");
        }
    }
}

