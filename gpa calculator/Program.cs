using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gpa_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           int Num1, Num2,Num3,Num4,Num5,Num6,total;

       float percentage;

         char option;

                Console.WriteLine("Enter the Marks of all subjects: ");

              Console.Write("Enter the Subject1 Marks : ");

                  Num1 = Convert.ToInt32(Console.ReadLine());

                 Console.Write("Enter the Subject2 Marks : ");

                  Num2 = Convert.ToInt32(Console.ReadLine());

                     Console.Write("Enter the Subject3 Marks : ");

                      Num3 = Convert.ToInt32(Console.ReadLine());

                          Console.Write("Enter the Subject4 Marks : ");

                       Num4 = Convert.ToInt32(Console.ReadLine());

                               Console.Write("Enter the Subject5 Marks : ");

                       Num5 = Convert.ToInt32(Console.ReadLine());

                     Console.Write("Enter the Subject6 Marks : ");

                         Num6 = Convert.ToInt32(Console.ReadLine());

                         total = Num1 + Num2 + Num3 + Num4 + Num5 + Num6;

                         percentage = total / 6;

                   if (percentage > 75)

                  {

                  option = '1';

                        }

                       else if (percentage > 60)

                      {

                       option = '2';

                  }

                   else if (percentage > 50)

                          {

                          option = '3';

                           }

                      else if (percentage >= 35)

                       {

                            option = '4';

                     }

                            else

                         {

                          option = '5';

                         }

                         Console.WriteLine("The RESULT of Student with GRADE :");

                         Console.WriteLine("Subject1 Marks : {0}", Num1);

                         Console.WriteLine("Subject2 Marks : {0}", Num2);

                          Console.WriteLine("Subject3 Marks : {0}", Num3);

                             Console.WriteLine("Subject4 Marks : {0}", Num4);

                           Console.WriteLine("Subject5 Marks : {0}", Num5);

                            Console.WriteLine("Subject6 Marks : {0}", Num6);

                            Console.WriteLine("TOTAL Marks : {0}", total);

                                Console.WriteLine("PERCENTAGE : {0}", percentage);

                                 switch (option)

                            {

                                   case '1':

                                         Console.WriteLine("Grade: First Class with Distinction");

                                         break;

                                   case '2':

                                         Console.WriteLine("Grade: First Class");

                                       break;

                                       case '3':

                                       Console.WriteLine("Grade: Second Class");

                                        break;

                                       case '4':

                                           Console.WriteLine("Grade: Third Class");

                                            break;

                                          case '5':

                                              Console.WriteLine("F A I L");

                                            break;

                                                  default:

                                               Console.WriteLine("Invalid GRADE");

                                                 break;

                                                  }

                                                 Console.ReadLine();

                                     }
                                }
 }