using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteiBank
{
    class ATM
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;//allows you to exit section
            int attempts;
            int count = 0;
            bool exitMenu = false;

            do//includes all of the application
            {
                Console.WriteLine("Login");

                Console.WriteLine("Enter your account number?:\n ");
                string username = Console.ReadLine().ToUpper().ToLower();
                count++; //increment the attempts below
                attempts = 4 - count; //stops the count after 3 attempts but allows initial attempts to equal 4

                switch (username)
                {
                    case "987654321":
                        Console.WriteLine("\nYou have gained access!\n");
                        do
                        
                        

                            Console.WriteLine("Enter your PIN: \n");
                            string PIN = Console.ReadLine();
                            if (PIN == "1234")
                            {
                                Console.WriteLine("\nWelcome!\n");
                                isAdmin = true;
                                double balance = 0;
                                do
                                {
                                    Console.WriteLine("What would you like to do today?: \n" + "Deposit: D\n"
                                       + "Withdrawal: W\n"
                                       + "Check Balance: B\n"
                                       + "Exit: X\n");
                                    string userAnswer = Console.ReadLine().ToLower().ToUpper();
                                    string additionalTransactions;
                                    switch (userAnswer)
                                    {
                                        case "DEPOSIT":
                                        case "D":
                                            Console.WriteLine("How much would you like to deposit? ");
                                            double depositAmount = Convert.ToDouble(Console.ReadLine());
                                            balance += depositAmount;
                                            Console.WriteLine("The amount of $" + depositAmount + " will be deposited into your account. Would you like to make another transaction? Y/N ");
                                            additionalTransactions = Console.ReadLine().ToLower().ToUpper();
                                            if (additionalTransactions == "N")
                                            {
                                                exitMenu = true; //allows you to exit the loop and exit app
                                                Console.WriteLine("Thank you for choosing Mantei Bank! ");
                                                break;
                                            }
                                            break;

                                        case "W":
                                        case "WITHDRAWAL":
                                            Console.WriteLine("How much would you like to withdrawal? ");
                                            double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                                            balance -= withdrawalAmount;
                                            Console.WriteLine("The amount of $" + withdrawalAmount + " will be withdrawn from your account. Would you like to make another transaction? Y/N ");
                                            additionalTransactions = Console.ReadLine().ToLower().ToUpper();
                                            if (additionalTransactions == "N")
                                            {
                                                exitMenu = true;//allows you to exit the loop and exit the app
                                                Console.WriteLine("Thank you for choosing Mantei Bank! ");
                                                break;
                                            }
                                            break;

                                        case "B":
                                        case "CHECK BALANCE":
                                            Console.WriteLine("Your balance is: $" + balance + "\nWould you like to make another transaction? Y/N ");
                                            additionalTransactions = Console.ReadLine().ToLower().ToUpper();
                                            if (additionalTransactions == "N")
                                            {
                                                exitMenu = true;//allows you to exit the loop and exit the app
                                                Console.WriteLine("Thank you for choosing Mantei Bank! ");
                                                break;
                                            }
                                            break;

                                        case "Y": //allows you back into the do while
                                        case "YES":
                                            Console.WriteLine("I will send you back up to the menu!");//WHAT IS HAPPENING???
                                            break;

                                        case "EXIT"://allows you to exitmenu and exit app
                                        case "X":
                                        case "E":

                                            Console.WriteLine("Thank you for choosing Mantei Bank!");
                                            exitMenu = true;
                                            break;

                                        default://allows you to enter back into loop
                                            Console.WriteLine(" That was not an option. Please try again. ");
                                            break;

                                    }
                                } while (exitMenu == false);
                                break;
                            }
                            else
                            if (count <= 3)//if not right, shoots to this section
                            {
                                Console.WriteLine("\nYou have " + attempts + " more attempts to enter your correct PIN before being locked out. Would you like to continue? Y/N \n");
                                string response1 = Console.ReadLine().ToUpper().ToLower();


                                switch (response1)//allows you to start back over to the top of the loop
                                {
                                    case "y":
                                    case "Y":
                                        break;

                                    default:

                                        Console.WriteLine("Thank you for choosing Mantei Bank. Goodbye. ");
                                        isAdmin = true;

                                        break;
                                }
                            }
                            if (count == 4)//will kick you out of loop and app
                            {
                                Console.WriteLine("You have run out of attempts. Goodbye!");
                                isAdmin = true;
                                break;
                            }

                            count++;
                            attempts = 4 - count;

                        } while (isAdmin == false);
                        break;

                        /*default: (REPEAT OF ABOVE)
                            if (count <= 3)
                            {
                                Console.WriteLine("\nLog in failed! You have " + attempts + " more attempts before being locked out. Would you like to try again? Y/N \n");
                                string response = Console.ReadLine().ToUpper().ToLower();
                                switch (response)
                                {
                                    case "Y":
                                    case "y":
                                        break;
                                    default:
                                        Console.WriteLine("\nGoodbye.");

                                        isAdmin = true;
                                        break;
                                }
                            }
                            if (count == 4)
                            {
                                Console.WriteLine("You have run out of attempts. Goodbye");
                                isAdmin = true;
                                break;
                            }
                            break; */
                }
            } while (isAdmin == false);

        }//end Main()
    }//end class
}//end namespace
