using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SessionFour_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task

            /*
             Student Age Checker (Using Relational Patterns with Switch)
             Let the user enter a student's age.
             Use switch with relational pattern to check:
             
             If age > 25 : print "Older Student"
             If age between 18–25 : print "University Student"     
             If age < 18 : print "School Student"
                   
             Use switch expression / relational pattern / when keyword
            */
            //int age;
            //bool isAgeParsed;
            //do
            //{
            //    Console.WriteLine("Enter the Student's Age");
            //    isAgeParsed = int.TryParse(Console.ReadLine(), out age);
            //}while (!isAgeParsed);

            //string msg = age switch
            //{
            //    > 25 => "Older Student",
            //    >= 18 and <= 25 => "University Student",
            //    < 18 => "School Student"
            //};
            //Console.WriteLine(msg);
            #endregion

            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            /*
             Example (1)
             Input: 12 
             Output: Yes
             Example (2)
             Input: 9 
             Output: No
             */
            //int number;
            //bool isPrased, res = true;
            //do
            //{
            //    Console.WriteLine($"Please Enter number can divided by 3 and 4\n");
            //    isPrased = int.TryParse(Console.ReadLine(), out number);
            //}while( !isPrased );
            //Console.WriteLine($"Input number is : {number}");
            //if (isPrased)
            //{
            //    if (number % 3 == 0 && number % 4 == 0)
            //    {
            //        Console.WriteLine($"Output : {res}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Output : {!res}");
            //    }
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            /*
             Example (1)
             Input: -5
             Output: negative
             Example (2)
             Input: 10
             Output: positive
             */

            //int number;
            //bool isPrased;
            //do 
            //{ 
            //Console.WriteLine($"Please Enter number\n");
            //isPrased = int.TryParse(Console.ReadLine(), out number);
            //}while(!isPrased);
            //Console.WriteLine($"Input number is : {number}");
            //if (isPrased)
            //{
            //    if (number > 0)
            //    {
            //        Console.WriteLine($"Output : Postive \n");
            //    }
            //    else if (number < 0)
            //    {
            //        Console.WriteLine($"Output : Negative \n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("number is Zero");
            //    }
            //}
            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            /*
             Example (1)
             Input:7,8,5
             Output:
             max element = 8
             min element = 5
             Example (2)
             Input: 3 6 9
             Outputs:
             Max element = 9
             Min element = 3
             */
            //int number , number2 , number3 , max, min;
            //bool isnumberPrased , isnumber2Prased , isnumber3Prased;
            //do
            //{
            //    Console.WriteLine($"Please Enter number1\n");
            //    isnumberPrased = int.TryParse(Console.ReadLine(), out number);
            //} while ( !isnumberPrased );
            //do
            //{
            //    Console.WriteLine($"Please Enter number2\n");
            //    isnumber2Prased = int.TryParse(Console.ReadLine(), out number2);
            //} while (!isnumber2Prased);
            //do
            //{
            //    Console.WriteLine($"Please Enter number3\n");
            //    isnumber3Prased = int.TryParse(Console.ReadLine(), out number3);

            //} while (!isnumber3Prased);

            //max = number;
            //if (number2 > max)
            //{ max = number2; }
            //if (number3 > max)
            //{ max = number3; }

            //min = number;

            //if (number2 < min)
            //{ min = number2; }
            //if (number3 < min)
            //{ min = number3; }

            //Console.WriteLine($"Max Number is = {max}\n");
            //Console.WriteLine($"Min Number is = {min}\n");

            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //int number;
            //bool isPrased;
            //do
            //{
            //    Console.WriteLine($"Please Enter number\n");
            //    isPrased = int.TryParse(Console.ReadLine(), out number);
            //} while (!isPrased);
            //Console.WriteLine($"Input number is : {number}");
            //if (isPrased)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine($"Number is : Even  \n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Number is : Odd");
            //    }
            //}
            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            /*
             Example (1)
             Input: O
             Output: vowel
             Example (2)
             Input: b
             Output: Consonant
             */
            //char character;
            //bool isParsed;
            //do 
            //{ 
            //Console.WriteLine($"Please Enter Character \n");
            //isParsed = char.TryParse(Console.ReadLine(), out character);
            //} while ( !isParsed );
            //switch (character)
            //{
            //    case 'a':
            //    case 'A':
            //        Console.WriteLine("Vowel Character");
            //        break;
            //    case 'e':
            //    case 'E':
            //        Console.WriteLine("Vowel Character");
            //        break;
            //    case 'i':
            //    case 'I':
            //        Console.WriteLine("Vowel Character");
            //        break;
            //    case 'o':
            //    case 'O':
            //        Console.WriteLine("Vowel Character");
            //        break;
            //    case 'u':
            //    case 'U':
            //        Console.WriteLine("Vowel Character");
            //        break;
            //    default:
            //        Console.WriteLine("Constant Character");
            //        break;
            //}
            #endregion

            #region 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            /*
             Example 
             Input: 5
             Output: 1, 2, 3, 4, 5
             */
            //int number;
            //bool isPrased;
            //do
            //{
            //    Console.WriteLine($"Please Enter number\n");
            //    isPrased = int.TryParse(Console.ReadLine(), out number);
            //} while (!isPrased);
            //Console.WriteLine($"\nInput : {number}\n");
            //Console.Write("Output : ");
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i < number)
            //    {
            //        Console.Write($"{i}, ");
            //    }
            //    else
            //    {
            //        Console.Write($"{i}");
            //    }
            //}
            //Console.WriteLine();
            #endregion

            #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            /*
             Example
             Input: 5
             Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
            */
            //int number;
            //bool isPrased;
            //do
            //{
            //    Console.WriteLine($"Please Enter number\n");
            //    isPrased = int.TryParse(Console.ReadLine(), out number);
            //} while (!isPrased);
            //Console.WriteLine($"\nInput : {number}\n");
            //Console.Write("Output : ");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($"{number*i} ");
            //}
            //Console.WriteLine();
            #endregion

            #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /*
             Example:
             Input: 15
             Output: 2 4 6 8 10 12 14
             */
            //int number;
            //bool isPrased;
            //do
            //{
            //    Console.WriteLine($"Please Enter number\n");
            //    isPrased = int.TryParse(Console.ReadLine(), out number);
            //} while (!isPrased);
            //Console.WriteLine($"\nInput : {number}\n");
            //Console.Write("Output : ");
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{i} ");
            //    }

            //}
            //Console.WriteLine();
            #endregion

            #region 9- Write a program that takes two integers then prints the power.
            /*
             Example:
             Input: 4 3
             Output: 64
             Hint: how to calculate 4^3 = 4 * 4 * 4 =64          
             */
            //int number , power , result;
            //bool isnumberPrased, isnumber2Prased;
            //do
            //{
            //    Console.WriteLine($"Please Enter number\n");
            //    isnumberPrased = int.TryParse(Console.ReadLine(), out number);
            //} while (!isnumberPrased);
            //do
            //{
            //    Console.WriteLine($"Please Enter Power\n");
            //    isnumber2Prased = int.TryParse(Console.ReadLine(), out power);
            //} while (!isnumber2Prased);
            //Console.WriteLine($"Input : {number} {power} ");
            //result = number;
            //for (int i = 1; i < power; i++)
            //{
            //    result *= number; 
            //}
            //Console.WriteLine($"Output : {number}^{power} = {result}");
            //Console.WriteLine();
            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            /*
             Example
             Input: - Enter Marks of five subjects: 95 76 58 90 89
             Output: Total marks = 408
                     Average Marks = 81
                      Percentage = 81
             */
            //float[] marks = new float[5];
            //float totalmarks = 0f , avgmarks , precentage;
            //for (int i = 0; i < marks.Length;)
            //{
            //    Console.WriteLine($"Subject {i + 1} : ");
            //    bool isParsed = float.TryParse(Console.ReadLine(), out marks[i]);
            //    if (isParsed)
            //    { 
            //        totalmarks += marks[i];
            //        i++; 
            //    }
            //}
            //Console.Clear();
            //for (int i = 0; i < marks.Length;i++)
            //{
            //    Console.WriteLine($"Subject {i + 1} : {marks[i]} ");

            //}
            //avgmarks = totalmarks / marks.Length;
            //precentage = avgmarks;
            //Console.WriteLine($"Total Marks = {totalmarks} ");
            //Console.WriteLine($"Average Marks = {avgmarks} ");
            //Console.WriteLine($"Precentage = {precentage} % ");
            //Console.WriteLine();

            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.
            /*
             Example
             Input: Month Number: 1
             Output: Days in Month: 31
             */
            //int monthnumber , days = 0;
            //bool isPrased;
            //do
            //{
            //    Console.WriteLine($"Please Enter monthnumber\n");
            //    isPrased = int.TryParse(Console.ReadLine(), out monthnumber);
            //} while (!isPrased);
            //Console.WriteLine($"Month Number : {monthnumber}");
            //switch(monthnumber)
            //{
            //    case 1: // January
            //    case 3: // March
            //    case 5: // May
            //    case 7: // July
            //    case 8: // August
            //    case 10: // October
            //    case 12: // December
            //        days = 31;
            //        break;
            //    case 4: // April
            //    case 6: // June
            //    case 9: // September
            //    case 11: // November
            //        days = 30;
            //        break;
            //    case 2: // February
            //        int year;
            //        bool isyearParsed;
            //        do
            //        {
            //            Console.Write("Enter year to check for leap year: ");
            //             isyearParsed = int.TryParse(Console.ReadLine(), out year);
            //        }while (!isyearParsed);

            //        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            //        {
            //            days = 29;
            //        }
            //        else
            //        {
            //            days = 28;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month Number.");
            //        break;
            //}
            //Console.WriteLine($"Days in Month : {days}");
            //Console.WriteLine();
            #endregion

            #region 12- Write a program to create a Simple Calculator.
            //float num1, num2;
            //double result;
            //char sign;
            //bool isSignParsed , isNum1Parsed , isNum2Parsed ;
            //do
            //{
            //    Console.WriteLine("Enter fisrt number : ");
            //        isNum1Parsed = float.TryParse(Console.ReadLine(), out num1);
            //} while (!isNum1Parsed);
            //do
            //{
            //    Console.WriteLine("Enter second number : ");
            //    isNum2Parsed = float.TryParse(Console.ReadLine(), out num2);
            //} while (!isNum2Parsed);


            //    Console.WriteLine("Enter sign operation : ");
            //    isSignParsed = char.TryParse(Console.ReadLine(), out sign);


            //switch (sign)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine($"Result for : {num1} + {num2} = {result} ");
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine($"Result for : {num1} - {num2} = {result} ");
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine($"Result for : {num1} * {num2} = {result} ");
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine($"Result for : {num1} / {num2} = {result} ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Can not make division by zero");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Not vaild sign operator");
            //        break;
            //}
            #endregion

            #region 13- Write a program to allow the user to enter a string and print the REVERSE of it.
            //string input , reverse = "";
            //Console.WriteLine("Enter a string");
            //input = Console.ReadLine();

            //for (int i = input.Length - 1 ; i >= 0; i--)
            //{
            //    reverse = reverse + input[i];
            //}

            //Console.WriteLine($"Reversed string is : {reverse}");
            #endregion

            #region 14- Write a program to allow the user to enter int and print the REVERSED of it.
            //int input , reverse = 0 , digit;
            //bool isPrased;
            //do
            //{
            //    Console.WriteLine($"Please Enter number\n");
            //    isPrased = int.TryParse(Console.ReadLine(), out input);
            //} while (!isPrased);
            //while(input != 0)
            //{
            //    digit = input % 10;
            //    reverse = reverse * 10 + digit;
            //    input = input / 10;
            //}
            //Console.WriteLine($"Reversed number is : {reverse}");
            #endregion

            #region 15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            /*
             Test Data :
             Input starting number of range: 1
             Input ending number of range : 50
             
             Expected Output :
             The prime number between 1 and 50 are :
             2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
             */

            //int start, end;
            //bool isStartPrased, isendParsed;
            //do
            //{
            //    Console.WriteLine($"Please Enter start number to start range :\n");
            //    isStartPrased = int.TryParse(Console.ReadLine(), out start);
            //} while (!isStartPrased);
            //do
            //{
            //    Console.WriteLine($"Please Enter end number to end range\n");
            //    isendParsed = int.TryParse(Console.ReadLine(), out end);
            //} while (!isendParsed);
            //Console.Clear();
            //Console.WriteLine($"Input starting number of range : {start}\n");
            //Console.WriteLine($"Input ending number of range : {end}\n");
            //Console.WriteLine($"Expected Output :");
            //Console.WriteLine($"The prime number between {start} and {end} are : \n");

            //for (int i = start; i <= end; i++) 
            //{
            //    bool prime = true;

            //    if (i <= 1)
            //    {
            //        prime = false;
            //    }
            //    else
            //    {
            //        for (int j = 2; j < i;j++)
            //        {
            //            if ( i % j == 0 )
            //            {
            //                prime = false;
            //                break;
            //            }
            //        }
            //    }
            //    if ( prime )
            //    {
            //        Console.Write(i + " " );
            //    }
            //}
            //Console.WriteLine();


            #endregion

            #region 16- Write a program in C# Sharp to convert a decimal number into binary without using an array.
            /*
             Test Data :
             Enter a number to convert : 25
             Expected Output :
             The Binary of 25 is 11001.
             */

            //int number , place = 1;
            //bool isPrased;
            //int binary = 0;
            //do
            //{
            //    Console.WriteLine($"Please Enter number to convert to binary :\n");
            //    isPrased = int.TryParse(Console.ReadLine(), out number);
            //} while (!isPrased);
            //Console.WriteLine($"Enter a number to convert : {number}");
            //Console.WriteLine("Expected Output : ");
            //if (number == 0)
            //{
            //    binary = 0;
            //}
            //else
            //{
            //    int temp = number;
            //    while (temp > 0)
            //    {
            //        int reminder = temp % 2;
            //        binary = binary + reminder*place;
            //        place *= 10;
            //        temp = temp / 2;
            //    }
            //}
            //Console.WriteLine($"The Binary of {number} is : {binary}");

            #endregion

            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //int x1,x2,x3,y1,y2,y3;
            //bool isx1Prased, isx2Prased, isx3Prased, isy1Prased, isy2Prased, isy3Prased;

            //do
            //{
            //    Console.WriteLine($"Please Enter point x1 :\n");
            //    isx1Prased = int.TryParse(Console.ReadLine(), out x1);
            //} while (!isx1Prased);
            //do
            //{
            //    Console.WriteLine($"Please Enter point x2 :\n");
            //    isx2Prased = int.TryParse(Console.ReadLine(), out x2);
            //} while (!isx2Prased);
            //do
            //{
            //    Console.WriteLine($"Please Enter point x3 :\n");
            //    isx3Prased = int.TryParse(Console.ReadLine(), out x3);
            //} while (!isx3Prased);
            //do
            //{
            //    Console.WriteLine($"Please Enter point y1 :\n");
            //    isy1Prased = int.TryParse(Console.ReadLine(), out y1);
            //} while (!isy1Prased);
            //do
            //{
            //    Console.WriteLine($"Please Enter point y2 :\n");
            //    isy2Prased = int.TryParse(Console.ReadLine(), out y2);
            //} while (!isy2Prased);
            //do
            //{
            //    Console.WriteLine($"Please Enter point y3 :\n");
            //    isy3Prased = int.TryParse(Console.ReadLine(), out y3);
            //} while (!isy3Prased);

            //bool colinear = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);

            //if (colinear)
            //{
            //    Console.WriteLine("The points lie on the same straight line");
            //}
            //else
            //{
            //    Console.WriteLine("The points do NOT lie on the same line");
            //}

            #endregion

            #region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.- If the worker takes 3 to 4 hours, they are instructed to increase their speed.- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.- If the worker takes more than 5 hours, they are required to leave the company.To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            //double time;
            //bool isparsed;
            //do
            //{
            //    Console.WriteLine($"Please Enter time :\n");
            //    isparsed = double.TryParse(Console.ReadLine(), out time);
            //} while (!isparsed);
            //if (time >= 2 && time <= 3)
            //    Console.WriteLine("Highly efficient");
            //else if (time > 3 && time <= 4)
            //    Console.WriteLine("Improve your speed");
            //else if (time > 4 && time <= 5)
            //    Console.WriteLine("Training required");
            //else if (time > 5)
            //    Console.WriteLine("Leave the company");

            #endregion

            #region 19- Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //int n;
            //bool isparsed;
            //do
            //{
            //    Console.WriteLine($"Please Enter matrix size (n) :\n");
            //    isparsed = int.TryParse(Console.ReadLine(), out n);
            //} while (!isparsed);
            //Console.WriteLine($"\n Identitiy Matrix is : \n");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1");
            //        }
            //        else
            //        {
            //            Console.Write("0");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 20- Write a program in C# Sharp to find the sum of all elements of the array.
            //int n , sum = 0;
            //bool isparsed;
            //do
            //{
            //    Console.WriteLine($"Please Enter size (n) of Array :\n");
            //    isparsed = int.TryParse(Console.ReadLine(), out n);
            //} while (!isparsed);
            //int[]arr = new int[n];
            //for (int i = 0; i < n;)
            //{
            //    Console.Write($"Element {i+1} :  ");
            //    bool parsed = int.TryParse(Console.ReadLine(),out arr[i]);
            //    if (parsed )
            //    {
            //        i++;
            //    }
            //}
            //for (int i = 0;i < n;i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine($"Sum of elements is : {sum}");
            #endregion

            #region 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int n;
            //bool isparsed;
            //do
            //{
            //    Console.WriteLine($"Please Enter size (n) of Array :\n");
            //    isparsed = int.TryParse(Console.ReadLine(), out n);
            //} while (!isparsed);
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];
            //int[] mergarr = new int[n*2];
            //for (int i = 0; i < n;)
            //{
            //    Console.Write($"Element for arr1 {i + 1} :  ");
            //    bool parsed = int.TryParse(Console.ReadLine(), out arr1[i]);
            //    if (parsed)
            //    {
            //        i++;
            //    }
            //}
            //for (int i = 0; i < n;)
            //{
            //    Console.Write($"Element for arr2 {i + 1} :  ");
            //    bool parsed = int.TryParse(Console.ReadLine(), out arr2[i]);
            //    if (parsed)
            //    {
            //        i++;
            //    }
            //}
            //int h = 0,j=0,k=0;
            //for (h = 0;h < n;h++)
            //{
            //    mergarr[h] = arr1[h];
            //}
            //for (j = 0; j  < n; j ++)
            //{
            //    mergarr[n + j] = arr2[j];
            //}
            //for (k = 0; k < (n*2)-1; k ++)
            //{
            //    for (int g = k+1; g < n*2 ; g ++)
            //    {
            //        if (mergarr[k] >  mergarr[g])
            //        {
            //            int temp = mergarr[k];
            //            mergarr[k] = mergarr[g];
            //            mergarr[g] = temp;
            //        }
            //    }
            //}


            //Console.WriteLine("Merged Array (soreted ascending) : ");
            //for (int m = 0; m < n*2; m++)
            //{
            //    Console.Write(mergarr[m] + " ");
            //}

            #endregion

            #region 22- Write a program in C# Sharp to count the frequency of each element of an array.
            //int n , count = 0 ;
            //bool isparsed;
            //do
            //{
            //    Console.WriteLine($"Please Enter size (n) of Array :\n");
            //    isparsed = int.TryParse(Console.ReadLine(), out n);
            //} while (!isparsed);
            //int[] arr = new int[n];
            //for (int i = 0; i < n;)
            //{
            //    Console.Write($"Element for arr {i + 1} :  ");
            //    bool parsed = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (parsed)
            //    {
            //        i++;
            //    }
            //}
            //int[] visited = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    visited[i] = 0; // 0 for not visited, 1 for visited
            //}

            //Console.WriteLine("Frequency of each element:");
            //for (int i = 0; i < n; i++)
            //{
            //    if (visited[i] == 1)
            //    {
            //        continue; // Already processed this element
            //    }

            //     count = 1;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            visited[j] = 1; // Mark as visited
            //        }
            //    }
            //    Console.WriteLine(arr[i] + " occurs " + count + " time(s)");
            //}

            #endregion

            #region 23- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length;)
            //{
            //    Console.Write($"Element for arr1 {i + 1} :  ");
            //    bool parsed = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (parsed)
            //    {
            //        i++;
            //    }
            //}
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0; i < 5; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];

            //    if (arr[i] < min)
            //        min = arr[i];
            //}

            //Console.WriteLine($"Maximum value = {max}" );
            //Console.WriteLine($"Minimum value = {min}" );

            #endregion

            #region 24- Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = new int[5];

            //for (int i = 0; i < arr.Length;)
            //{
            //    Console.Write($"Element for arr1 {i + 1} :  ");
            //    bool parsed = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (parsed)
            //    {
            //        i++;
            //    }
            //}
            //int first = arr[0];
            //int second = arr[0] ;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > first)
            //    {
            //        second = first;
            //        first = arr[i];
            //    }
            //    else if (arr[i] < first && arr[i] > second)
            //    {
            //        second = arr[i];
            //    }
            //}
            //Console.WriteLine($"Second largest element = {second}" );

            #endregion

            #region 25- Consider an Array of Integer values with size N, having values as in this Example
            /*
             7	   0	0	0	0	5	6	7	5	0	7	5	3

             write a program find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).

             In the example above, the longest distance is between the first 7 and the
             10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st
             And the 10th 7s.

             Note:
             - Array values will be taken from the user
             - If you have input like 1111111 then the distance is the number of
             Cells between the first and the last cell.
             */
            //int n;
            //bool isparsed;
            //do
            //{
            //    Console.WriteLine($"Please Enter size (n) of Array :\n");
            //    isparsed = int.TryParse(Console.ReadLine(), out n);
            //} while (!isparsed);
            //int[]arr= new int[n];
            //for (int i = 0; i < arr.Length;)
            //{
            //    Console.Write($"Element for arr1 {i + 1} :  ");
            //    bool parsed = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (parsed)
            //    {
            //        i++;
            //    }
            //}
            //int maxdistance = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = n-1; j > i ; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i -1;
            //            if (distance > maxdistance)
            //            {
            //                maxdistance = distance;
            //            }
            //        }

            //    }
            //}
            //Console.WriteLine($"Longest distance between two equal values = {maxdistance}");

            #endregion

            #region 26- Given a list of space separated words, reverse the order of the words.
            /*
             Input: this is a test		Output: test a is this
             Input: all your base		Output: base your all
             Input: Word			Output: Word
             Note : 
             Check the Split Function (Member in String Class) Output will be a Single Console.WriteLine Statement
             */
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');  // Split sentence into words using space

            //Console.WriteLine("Reversed sentence:");

            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(words[i]);

            //    if (i > 0)
            //        Console.Write(" ");  // Add space between words
            //}
            //Console.WriteLine();

            #endregion

            #region 27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //int row , column;
            //bool isrowparsed , iscolumnparsed;
            //do
            //{
            //    Console.WriteLine($"Please Enter size of (row) of Array :\n");
            //    isrowparsed = int.TryParse(Console.ReadLine(), out row);
            //} while (!isrowparsed);
            //do
            //{
            //    Console.WriteLine($"Please Enter size of (column) of Array :\n");
            //    iscolumnparsed = int.TryParse(Console.ReadLine(), out column);
            //} while (!iscolumnparsed);

            //int[,] arr1 = new int[row , column];
            //int[,] arr2 = new int[row , column];
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1);)
            //    {
            //        Console.Write($"Element for arr1 [ {i} , {j} ] :  ");
            //        bool parsed = int.TryParse(Console.ReadLine(), out arr1[i , j]);
            //        if (parsed)
            //        {
            //            j++;
            //        }
            //    }
            //}

            //for (int i = 0;i < arr1.GetLength(0);i++)
            //{
            //    for(int j = 0;j < arr1.GetLength(1);j++)
            //    {
            //        arr2[i,j] = arr1[i,j];
            //    }
            //}
            //Console.Clear();

            //Console.Write("\nElements of the first array : ");
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j =0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.Write(arr1[i,j] + " ");
            //    }
            //}
            //Console.Write("\nElements of the second array that copied from fisrt array : ");
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //}

            #endregion

            #region 28- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] arr = new int[5];

            //for (int i = 0; i < arr.Length;)
            //{
            //    Console.Write($"Element for arr1 {i + 1} :  ");
            //    bool parsed = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (parsed)
            //    {
            //        i++;
            //    }
            //}
            //Console.Write("Array in reverse order : ");
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region 29- Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            //int temperature;
            //bool isparsed;
            //do
            //{
            //    Console.WriteLine($"Please Enter Temperature in degree :\n");
            //    isparsed = int.TryParse(Console.ReadLine(), out temperature);
            //} while (!isparsed);
            //string result = (temperature < 10) ? "Just Cold" : (temperature > 30) ? "Just Hot" : "Just Good";
            //Console.WriteLine($"The Temperature is {temperature} that's mean : {result}");
            #endregion

            #region 30- What will be the output of the C# code given below?
            /*
             int num = 1, z = 5;

             if (!(num <= 0))
                 Console.WriteLine( ++num + z++ + " " + ++z ); 
             else
                 Console.WriteLine( --num + z-- + " " + --z ); 

             a.	5 6
             b.	6 5
             c.	6 6
             d.	7 7
             */

            // ++num = 2
            // z++ = 5 then increament to be 6 
            // ++num + z++ = 2 + 5 = 7
            // ++z = 7 becuase z from last opertion incremented to 6
            // ==> Result will be d --> 7 7
            #endregion

        }
    }
}
