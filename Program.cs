/*
 DAVID WILKINS
 GRAND CIRCUS PRE WORK
 MATH CHALLENGE
 01/04/18

 IN THIS PROGRAM THE USER IS PROMPTED TO ENTER AN INTEGER, AND THEN A SECOND INTEGER
 THAT HAS THE SAME NUMBER OF DIGITS. IF THE USER ENTERS ANYTHING OTHER THAN AN INTEGER
 IT WILL TELL THEM THEY MADE A MISTAKE AND START OVER. IF THE TWO NUMBERS GIVEN ARENT THE
 SAME NUMBER OF DIGITS, IT WILL TELL THEM THEY MADE A MISTAKE AND START OVER.

IF THE USER ENTERS VALID INTEGERS, THE PROGRAM WILL ADD THE FIRST DIGIT, SECOND DIGIT, ETC,
AND CHECK IF ALL THE SUMS ARE THE SAME. IF THEY ARE NOT IT WILL PRINT OUT 'FALSE' , IF THEY 
ARE THE SAME IT WILL PRINT OUT 'TRUE'.


 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathChallenge
{
    class Program
    {
        //METHOD CALLED BY MAIN THAT HAS THE USER PROMPTS AND VALIDATION, AND RESULT CHECK 
        public static void challenge()
        {
            //USES A TRY/CATCH BLOCK, SO IF THE USERS ENTERS BAD DATA IT WILL CATCH THE EXCEPTION AND PROMPT THEMM FOR A 
            //NEW ENTRY


            {
                try
                {
                    Console.Write("Please enter an integer: ");
                    int firstInt = Convert.ToInt32(Console.ReadLine());  //MAKES SURE THE ENTRY CAN BE CONVERTED TO AN INT
                    string first = firstInt.ToString(); //CONVERTS ENTRY TO A STRING 

                    Console.WriteLine();
                    Console.Write("Please enter another integer with the same number of digits: ");
                    int secondInt = Convert.ToInt32(Console.ReadLine());

                    string second = secondInt.ToString();

                    if (first.Length != second.Length) //CHECKS THAT BOTH INPUTS ARE THE SAME LENGTH 'IE NUMBER OF DIGITS
                    {
                        Console.WriteLine("The two integers must have the same number of digits. Please try again.");
                        challenge();
                    }
                    else
                    {
                        char[] charFirst; //CREATE CHAR ARRAY
                        char[] charSecond;
                        Boolean challengeResult = true; //RESULT OF THE TEST
                        charFirst = first.ToCharArray(); //CONVERT FIRST INPUT TO A CHAR ARRAY SO IT CAN BE ITERATED THROUGH
                        charSecond = second.ToCharArray();
                        char[] charResult = first.ToCharArray();

                        for (int i = 0; i < charFirst.Length; i++) //ITERATE THROUGH CHAR ARRAY AND GET THE SUM OF EACH DIGIT PLACE
                        {
                            charResult[i] = Convert.ToChar(Convert.ToInt32(charFirst[i]) + Convert.ToInt32(charSecond[i]));

                        }

                        for (int i = 0; i < charResult.Length - 1; i++) //ITERATE THRU RESULT ARRAY, AND IF ANY OF THE RESULTS
                        {                                               //DONT MATCH THE OTHERS, SET RESULT TO FALSE.
                            if (charResult[i] != charResult[i + 1])
                            {
                                challengeResult = false;
                            }
                        }

                        Console.WriteLine(challengeResult); //DISPLAY THE RESULT BACK TO USER
                        Console.WriteLine();

                        Console.Write("Press 'y' to try again, or any other key to exit: "); //LETS USER ENTER A Y TO RESTART THE PROGRAM
                        string input = Console.ReadLine();                            //OR ANOTHER KEY TO EXIT. MOSTLY FOR FASTER TESTING
                        input  = input.ToLower();
                        if (input == "y")
                        {
                            challenge();
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("You must enter an integer. It cannot contain letters or decimal places.");
                    challenge();
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("       MATH CHALLENGE ");
            Console.WriteLine("******************************");

            challenge(); //CALLS THE METHOD THAT CONTAINS THE REST OF THE PROGRAM
        }
    }
}
