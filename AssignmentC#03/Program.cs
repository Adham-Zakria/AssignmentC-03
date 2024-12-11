using System;

namespace AssignmentC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Enter a num");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 || num % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region Q2
            //Console.WriteLine("Enter a num");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else if (num < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("num equal zero");
            //}
            #endregion

            #region Q3
            //Console.WriteLine("Enter a first num");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a second num");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a third num");
            //int num3 = int.Parse(Console.ReadLine());
            //int[] max = new int[3];
            //max[0] = num1;
            //max[1] = num2;
            //max[2] = num3;

            //int[] min = new int[3];
            //min[0] = num1;
            //min[1] = num2;
            //min[2] = num3;
            //Console.WriteLine($"the max element : {max.Max()}");
            //Console.WriteLine($"the min element : {min.Min()}");
            #endregion

            #region Q4
            //Console.WriteLine("enter a num");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else if (num % 2 != 0)
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion

            #region Q5
            //Console.WriteLine("enter a character");
            //char enterd = char.Parse(Console.ReadLine());

            //switch (enterd)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}
            #endregion

            #region Q6
            //Console.WriteLine("enter a num");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q7
            //Console.WriteLine("enter a num");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 01; i <= 12; i++)
            //{
            //    Console.WriteLine(num * i);
            //}
            #endregion

            #region Q8
            //Console.WriteLine("enter a num");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Q9
           // Console.WriteLine("enter a num");
           // int num = int.Parse(Console.ReadLine());
           // Console.WriteLine("enter the power");
           // int power = int.Parse(Console.ReadLine());
           // int res = 1;
           // for (int i = 1; i <= power; i++)
           // {
           //     res *= num;
           // }
           // Console.WriteLine(res);

           //// -------OR-------- -

           //Console.WriteLine("enter a num");
           // int num1 = int.Parse(Console.ReadLine());
           // Console.WriteLine("enter the power");
           // int power1 = int.Parse(Console.ReadLine());
           // Console.WriteLine(Math.Pow(num1, power1));
            #endregion

            #region Q10
            //int[] x = new int[5];
            //Console.WriteLine("enter the five markers");
            //int sum = 0;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());
            //    sum += x[i];
            //}
            //double Percentage = (double)(sum / 500.00) * 100;
            //Console.WriteLine($"Total Markes : {sum}");
            //Console.WriteLine($"average Markes : {sum / 5}");
            //Console.WriteLine($"Percentage  : {Percentage} %");
            #endregion

            #region Q11
            //Console.WriteLine("Enter the month number (1-12)");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("days = 31");
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine(" days = 30");
            //        break;

            //    case 2:
            //        Console.WriteLine("Enter the year:");
            //        int year = int.Parse(Console.ReadLine());

            //        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //        {
            //            Console.WriteLine(" days = 29"); // Leap year
            //        }
            //        else
            //        {
            //            Console.WriteLine(" days = 28"); // Non-leap year
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("enter a vaild month number");
            //        break;
            //}
            #endregion

            #region Q12
            //Console.WriteLine("Enter the first number");
            //int num1=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the second number");
            //int num2=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the operator + - * / % ");
            //string O= Console.ReadLine();

            //switch (O)
            //{
            //    case "+":
            //        Console.WriteLine(num1 + num2);
            //        break;
            //    case "-":
            //        Console.WriteLine(num1 - num2);
            //        break;
            //    case "*":
            //        Console.WriteLine(num1 * num2);
            //        break;
            //    case "/":
            //        Console.WriteLine(num1 / num2);
            //        break;
            //    case "%":
            //        Console.WriteLine(num1 % num2);
            //        break;
            //    default:
            //        Console.WriteLine("choose one of the previous operators");
            //        break;
            //}
            #endregion
        }
    }
}
