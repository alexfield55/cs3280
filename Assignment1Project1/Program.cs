using System;

namespace Assignment1Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0; //delcare first int
            int secondNum = 0; //declare second int
            bool test = true; //establish flag for try catch int testing block
         
            while (test)//allows user to correct input
            {
                try //tests for int input
                {
                    Console.Write("Please Enter First Integer: ");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    test = false;
                }
                catch //allows try again
                {
                    Console.WriteLine("must be int, please try again");
                    test = true;
                }
            }
       
            test = true; //reset flag for second input
                         //

            //same proecss as above, would put in method for future
            while (test)
            {
                try
                {
                    Console.Write("Please Enter Second Integer: ");
                    secondNum = Convert.ToInt32(Console.ReadLine());
                    test = false;
                }
                catch
                {
                    Console.WriteLine("must be int, please try again");
                    test = true;
                }
            }

            //outputs
            Console.WriteLine(firstNum +"+"+ secondNum +"="+ (firstNum+secondNum));
            Console.WriteLine(firstNum + "-" + secondNum + "=" + (firstNum- secondNum));
            Console.WriteLine(firstNum + "*" + secondNum + "=" + (firstNum * secondNum));
            Console.WriteLine(firstNum + "/" + secondNum + "=" + (firstNum / secondNum));
            Console.WriteLine(firstNum + "%" + secondNum + "=" + (firstNum % secondNum));

            if (firstNum > secondNum)
            {
                Console.WriteLine(firstNum + " is greater than " + secondNum);
            }
            else
            {
                Console.WriteLine(firstNum + " is not greater than " + secondNum);
            }
            if (firstNum < secondNum)
            {
                Console.WriteLine(firstNum + " is less than " + secondNum);
            }
            else
            {
                Console.WriteLine(firstNum + " is not less than " + secondNum);
            }
            if (firstNum == secondNum)
            {
                Console.WriteLine(firstNum + " is equal to " + secondNum);
            }
            else
            {
                Console.WriteLine(firstNum + " is not equal to " + secondNum);
            }

        }
    }
}
