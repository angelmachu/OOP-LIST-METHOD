// Marcos, Angel Matthew D.
// BSCPE 1 - 1 
// loop + correct flow after macheck ni maam yesterday
// Nakapag add na po ng list for subjects in method


using System;
using System.Collections.Generic;

namespace IntroToCSharp
{
    class Program
    {
        static void Main()
        {
            bool loop1 = true; // 1st loop
            bool loop2 = true; // 2nd loop
            bool loop3 = true; // 3rd loop
            string subjectChoice = "";
            string gradeChoice = "";

            while (loop1)
            {
                Console.WriteLine("Welcome User! This program will determine the equivalent grade of the percentage that you will choose below as well as its description.");
                Console.WriteLine();

                ListSubjects();
                Console.WriteLine();

                Console.Write("Press any key to continue or type \"exit\" to stop the program: ");
                subjectChoice = Console.ReadLine();

                if (subjectChoice == "exit")
                {
                    loop1 = false;
                }
                else
                {
                    while (loop2)
                    {
                        Console.WriteLine("Choose one of the five subjects below or type \"exit\" to stop the program");
                        Console.WriteLine();

                        Console.WriteLine("1. Object Oriented Programming");
                        Console.WriteLine("2. Computer Hardware Fundamentals");
                        Console.WriteLine("3. Programming Logic and Design");
                        Console.WriteLine("4. Discrete Mathematics");
                        Console.WriteLine("5. Engineering Data Analysis");

                        subjectChoice = Console.ReadLine();
                        switch (subjectChoice)
                        {
                            case "exit":
                                loop1 = false;
                                loop2 = false;
                                break;
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                                while (loop3)
                                {
                                    Console.WriteLine("Choose your grade in this subject or type \"exit\" to stop the program");
                                    Console.WriteLine();

                                    Console.WriteLine("1. 97 - 100");
                                    Console.WriteLine("2. 94 - 96");
                                    Console.WriteLine("3. 91 - 93");
                                    Console.WriteLine("4. 88 - 90");
                                    Console.WriteLine("5. 85 - 87");
                                    Console.WriteLine("6. 82 - 84");
                                    Console.WriteLine("7. 79 - 81");
                                    Console.WriteLine("8. 76 - 78");
                                    Console.WriteLine("9. 75");
                                    Console.WriteLine("10. 65 - 74");
                                    Console.WriteLine("11. Inc");
                                    Console.WriteLine("12. W");
                                    Console.WriteLine("13. D");

                                    gradeChoice = Console.ReadLine();
                                    switch (gradeChoice)
                                    {
                                        case "exit":
                                            loop1 = false;
                                            loop2 = false;
                                            loop3 = false;
                                            break;
                                        case "1":
                                            Console.WriteLine("Your Grade is 1.0 and its description is Excellent");
                                            loop3 = false;
                                            break;
                                        case "2":
                                            Console.WriteLine("Your Grade is 1.25 and its description is Excellent");
                                            loop3 = false;
                                            break;
                                        case "3":
                                            Console.WriteLine("Your Grade is 1.5 and its description is Very Good");
                                            loop3 = false;
                                            break;
                                        case "4":
                                            Console.WriteLine("Your Grade is 1.75 and its description is Very Good");
                                            loop3 = false;
                                            break;
                                        case "5":
                                            Console.WriteLine("Your Grade is 2.0 and its description is Good");
                                            loop3 = false;
                                            break;
                                        case "6":
                                            Console.WriteLine("Your Grade is 2.25 and its description is Good");
                                            loop3 = false;
                                            break;
                                        case "7":
                                            Console.WriteLine("Your Grade is 2.5 and its description is Satisfactory");
                                            loop3 = false;
                                            break;
                                        case "8":
                                            Console.WriteLine("Your Grade is 2.75 and its description is Satisfactory Good");
                                            loop3 = false;
                                            break;
                                        case "9":
                                            Console.WriteLine("Your Grade is 3.0 and its description is Passed");
                                            loop3 = false;
                                            break;
                                        case "10":
                                            Console.WriteLine("Your Grade is 5.0 and its description is Failure");
                                            loop3 = false;
                                            break;
                                        case "11":
                                            Console.WriteLine("Your Grade in this subject is Incomplete");
                                            loop3 = false;
                                            break;
                                        case "12":
                                            Console.WriteLine("Withdrawn");
                                            loop3 = false;
                                            break;
                                        case "13":
                                            Console.WriteLine("Dropped");
                                            loop3 = false;
                                            break;
                                        default: // for final case
                                            Console.WriteLine("Invalid input, choose between number 1 - 13 or type \"exit\" to stop the program");
                                            break;
                                    }
                                }
                                loop3 = true;
                                break;
                            default: // for loop2 cases
                                Console.WriteLine("Invalid input, choose between number 1 - 5 or type \"exit\" to stop the program");
                                break;
                        }
                    }
                    loop2 = true;
                }
            }
        }

        static void ListSubjects()
        {
            List<string> subjectsLists = new List<string>();
            
            Console.WriteLine("These are the subjects available:");
            
            subjectsLists.Add("1. Object Oriented Programming");
            subjectsLists.Add("2. Computer Hardware Fundamentals");
            subjectsLists.Add("3. Programming Logic and Design");
            subjectsLists.Add("4. Discrete Mathematics");
            subjectsLists.Add("5. Engineering Data Analysis");
            
            foreach (string ListSubjects in subjectsLists)
        {
            Console.WriteLine(ListSubjects);
        }
        }
    }
}
