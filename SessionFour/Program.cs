using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SessionFour_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conditional statements - Example 2 [Age > 22]
            //Console.WriteLine("Please Enter a number");
            //int.TryParse(Console.ReadLine(), out int age);
            //if (age > 22)
            //{
            //    Console.WriteLine("Age > 22");
            //}
            //else if (age < 22)
            //{
            //    Console.WriteLine("Age < 22");
            //}
            //else
            //{
            //    Console.WriteLine("Age = 22");
            //}

            //switch (age)   // Relational pattern : No jump table will be created 
            //{
            //    case (> 22):
            //        Console.WriteLine("Age > 22");
            //        break;
            //    case (< 22):
            //        Console.WriteLine("Age < 22");
            //        break;
            //    default:
            //        Console.WriteLine("Age = 22");
            //        break;
            //}
            #endregion

            #region Conditional statements - Example 3 [Name - Hello Name]
            //Console.WriteLine("Please Enter your name");
            //string name = Console.ReadLine();
            //if (name == "Mariam")
            //    Console.WriteLine("Hello Mariam");
            //else if (name == "Omar")
            //    Console.WriteLine("Hello Omar");
            //else
            //    Console.WriteLine("Hello Person");

            //if (name == "Mariam")
            //    Console.WriteLine("Hello Mariam");
            //if (name == "Omar")
            //    Console.WriteLine("Hello Omar");
            //else
            //    Console.WriteLine("Hello Person");

            //switch (name)
            //{
            //    case "Mariam":
            //    case "mariam":   // make this to match if user write Mariam or mariam because C3 is case sensitive
            //        Console.WriteLine("Hello Mariam");
            //        break;
            //    case "Omar":
            //        Console.WriteLine("Hello Omar");
            //        break;
            //    default:
            //        Console.WriteLine("Hello Person");
            //        break;
            //}
            #endregion

            #region Conditional statements - Example 4 [Budget] - [Switch with goto] - [Goto without switch]
            //1000 ==> Option 1
            //2000 ==> Option 2 , Option 1
            //3000 ==> Option 3 , Option 2 , Option 1
            //Console.WriteLine("Please enter the budget");
            //int.TryParse(Console.ReadLine(), out int budget);
            //if (budget == 1000)
            //{
            //    Console.WriteLine("Option 1");
            //}
            //else if (budget == 2000)
            //{
            //    Console.WriteLine("Option 2");
            //    Console.WriteLine("Option 1");
            //}
            //else if (budget ==3000)
            //{
            //    Console.WriteLine("Option 3");
            //    Console.WriteLine("Option 2");
            //    Console.WriteLine("Option 1");
            //}
            //else
            //{
            //    Console.WriteLine("Unkown Option");
            //}

            //switch (budget)
            //{
            //    case 1000:
            //        Console.WriteLine("Option 1");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 2");
            //        Console.WriteLine("Option 1");
            //        break;
            //    case 3000:
            //        Console.WriteLine("Option 3");
            //        Console.WriteLine("Option 2");
            //        Console.WriteLine("Option 1");
            //        break;
            //    default:
            //        Console.WriteLine("Unkown Option");
            //        break;
            //}

            // using GOTO this prevent use break in case that have GOTO and case not have GOTO then
            // use break in this case
            //switch (budget)
            //{
            //    case 1000:
            //        Console.WriteLine("Option 1");
            //        break;
            //    case 2000:
            //        Console.WriteLine("Option 2");
            //        //Console.WriteLine("Option 1");
            //        goto case 1000;
            //        //break;
            //    case 3000:
            //        Console.WriteLine("Option 3");
            //        //Console.WriteLine("Option 2");
            //        // Console.WriteLine("Option 1");
            //        goto case 2000;
            //       // break;
            //    default:
            //        Console.WriteLine("Unkown Option");
            //        break;
            //}

            // how to use GOTO outside switch 
            // make block of code but give name for this block of code like that 
            // this will make infinty loop not end even you close it 
            //Basha:
            //    Console.WriteLine("Hello Basha");

            //    Console.WriteLine("Please Enter a number");
            //    int.TryParse(Console.ReadLine(), out int number);
            //    goto Basha;
            #endregion

            #region Switch C# 7.0 [Pattern matching - When keyword] 

            #region Pattern matching
            //////[Object , integer , double ]
            //object obj; // ==> allocate 4 bytes in stack
            //obj = 10; // ==> Boxig
            //switch (obj)
            //{
            //    case int x: //==> UNBOXING
            //        Console.WriteLine("Integer");
            //        break;
            //    case float x:
            //        Console.WriteLine("Float");
            //        break;
            //    case double x:
            //        Console.WriteLine("Double");
            //        break;
            //    default:
            //        Console.WriteLine("Unkown datatype");
            //        break;
            //}

            #endregion

            #region Case guard [When]
            ////[Object , integer , double ]
            //object obj; // ==> allocate 4 bytes in stack
            //obj = 9; // ==> Boxig
            //switch (obj)
            //{
            //    case int x when x < 10 && x >= 5: //==>UnBoxing
            //        Console.WriteLine("Integer");
            //        break;
            //    case float x:
            //        Console.WriteLine("Float");
            //        break;
            //    case double x:
            //        Console.WriteLine("Double");
            //        break;
            //    default:
            //        Console.WriteLine("Unkown datatype");
            //        break;
            //}
            #endregion

            #region User defined data type
            ////[Person]
            //object obj = new Person(); // if write this only ,
            // it will intialize parts of person with default value
            // if int will be 0 if string will be null and so on
            // method new make this 
            // new make 4 parts 
            // 1. save number of bytes that allocated in heap
            // 2.Initialized defualt value
            // 3.call user defined costructor
            // 4.assign reference for object where this object is in heap
            //object obj = new Person() { Id = 1 , Name = "Mariam" , Age = 20};
            //switch (obj)
            //{
            //    case int input:
            //        Console.WriteLine("Integer Value");
            //        break;
            //    case float input:
            //        Console.WriteLine("Float Value");
            //        break;
            //    case Person input:
            //        Console.WriteLine("Person Value");
            //        break;
            //    default:
            //        Console.WriteLine("Unkown datatype");
            //        break;
            //}

            // using when 

            //object obj = new Person() { Id = 1, Name = "Mariam", Age = 20 };
            //switch (obj)
            //{
            //    case int input:
            //        Console.WriteLine("Integer Value");
            //        break;
            //    case float input:
            //        Console.WriteLine("Float Value");
            //        break;
            //    case Person input when input.Name == "Mariam":
            //        Console.WriteLine("Person Value");
            //        break;
            //    default:
            //        Console.WriteLine("Unkown datatype");
            //        break;
            //}
            #endregion

            #endregion

            #region Switch C# 8.0 [Pattern matching without alias - switch expression - property pattern...]

            #region Pattern matching without alias
            ////[Object , Integer , double]
            //// we have 3 patterns
            //// 1. Constant Pattern ==> like treat with something constant like number , string , char
            //// 2. Discard Pattern ==> defualt
            //// 3. Property Pattern ==> like treat with properties which inside user defined datatype 

            //object obj = 10;
            //switch (obj) 
            //{
            //    case int:
            //        Console.WriteLine("Integer");
            //        break;
            //    case float:
            //        Console.WriteLine("Float");
            //        break;
            //    default:
            //        Console.WriteLine("Unkown datatype");
            //        break;
            //}

            // using when and making casting

            //object obj = 10;
            //switch (obj)
            //{
            //    case int when (int)obj<=10: // we can't make this obj <= 10 becuase obj is object and 10 is int 
            //                          // malo4 da3wa hwa el obj 4ayel eh hwa object hwa leh da3wa bel datatype bta3toh bel reference
            //                          // bs fa lazem 23ml casting
            //                          // hateb2a (int)obj <= 10
            //        Console.WriteLine("Integer");
            //        break;
            //    case float:
            //        Console.WriteLine("Float");
            //        break;
            //    default:
            //        Console.WriteLine("Unkown datatype");
            //        break;
            //}
            #endregion

            #region switch case before pattern matching
            //// 1==> Msg = Option 1
            //int number;
            //string result;
            //Console.WriteLine("Please enter the number [1 , 2 , 3]");
            //int.TryParse(Console.ReadLine(), out number);
            //switch (number)
            //{
            //    case 1:
            //        result = "Option 1";
            //        break;
            //    case 2:
            //        result = "Option 2";
            //        break;
            //    case 3:
            //        result = "Option 3";
            //        break;
            //    default:
            //        result = "Unkown Option";
            //        break;
            //}
            // lets make improvment on this code using switch expression in next region
            //Console.WriteLine(result);
            #endregion

            #region switch expression [Constant pattern - discard pattern]
            //// 1==> Msg = Option 1
            //int number;
            //Console.WriteLine("Please enter the number [1 , 2 , 3]");
            //int.TryParse(Console.ReadLine(), out number);
            //string result = number switch
            //{
            //    1 => "Option 1", // Constant Pattern becuase make case on constant number like 1
            //    2 => "Option 2",
            //    3 => "Option 3",
            //    // to make default case make that :
            //    // called Discard Pattern
            //    _ => "Unkown Option" // Discard Pattern because using ( _ )
            //};
            //Console.WriteLine(result);


            #endregion

            #region Property pattern
            // using with switch expression 

            ////[Person]
            //Person person_user = new Person() { Id = 10 , Name = "Mariam" , Age = 20};
            //string result = person_user switch
            //{
            //    // to select property from inside user definied datatype use {}
            //    { Age: 30 } => "Age = 30",
            //    { Id: 10, Age: 20, Name: "Mariam" } => "Hello Mariam",
            //    { Id : 10} => "Hello Mariam with id 10" ,
            //    { Id : 300} => "Id is 300",
            //    _ => "Hello Person"
            //};
            //Console.WriteLine(result);
            #endregion

            #region Nullable type - relational pattern
            //// int?
            //// any value type can not assign for that null 
            //// if you need to assign null for that use ( ? )

            //int? number = null;
            //string result = number switch
            //{
            //    null => "Null",
            //    int x when x > 0 => "Postivie number", // when use nullable type we can't make this number > 0
            //                                           // we should use alias name like that int x when x > 0
            //    int x when x < 0 => "Negative number",
            //    _ => "Zero number"
            //};
            //Console.WriteLine(result);

            // not all relational pattern supported , supoorted relationl pattern lik < and >
            #endregion

            #endregion

            #region Switch C# 9.0 [Relational pattern - logical pattern - enhanced property pattern]

            #region Relational Pattern
            // num < 10 , between 10 and 20 , > 20
            //Console.WriteLine("Please enter a number");
            //int.TryParse(Console.ReadLine(), out int number);
            //string result = number switch
            //{
            //    // in C3 9 not need to use alias name
            //    < 10 => "Number < 10",
            //    > 20 => "Number > 20",
            //    >=10 and <=20 => "Number between 10 , 20"
            //    // don't need to use discard pattern [defualt in switch] ( _ ) becuase we handle all casese
            //    // if you try to put discard pattern will give error becuase we didn't need if becuase we handle all cases
            //};
            //Console.WriteLine(result);
            #endregion

            #region Enhanced Property Pattern
            ////Person is samy & age > 10
            ////Person is omar & age between 20 and 30
            ////Person's age is between 40 and 50
            ////Else ==> Unkown

            //Person person = new Person() { Id = 1, Name = "Mariam", Age = 20 };
            //string result = person switch
            //{
            //    { Name: "samy", Age: > 10 } => "Hello Samy",
            //    { Name: "omar", Age: >= 20 and <= 30 } => "Hello Omar",
            //    { Age: >= 40 and <= 50 } => "Age between 40 and 50",
            //    _ => "Unknown Person"
            //};
            //Console.WriteLine(result);

            #endregion

            #endregion

            #region Lopping statements [for - foreach]

            #region Intro
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);


            #endregion

            #region For - Foreach
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 100; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            ////0, 1, 2, 3, 4, 5 ==> Index based on 0
            //// Size / Length => 6
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(numbers[5]);
            //Console.WriteLine(numbers[6]); // => Invalid will make exception error

            //// static length
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //// daynamic length
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //// for each use virtual array not real array 
            //// so we can't update on array if you try will give error like that :
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //    //numbers += 10; // not valid becuase for each use virtual data from array not real
            //}

            //// but can make this in for becuase for use real data from array direct

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i] += 10);
            //}

            //Person[] people = new Person[] { new Person { Id = 10, Age = 20, Name = "Mariam" }, new Person { Id = 100, Age = 200, Name = "Ahmed" } };

            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //    // output will be ==> SessionFour_Demo.Person
            //    //                ==> SessionFour_Demo.Person
            //}

            // to make o/p appear id name age should make override in person class first 
            // the after making override in person 

            //Person[] people = new Person[] { new Person { Id = 10, Age = 20, Name = "Mariam" }, new Person { Id = 100, Age = 200, Name = "Ahmed" } };

            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //    // output will be ==> Id = 10 , Name = Mariam , Age = 20
            //    //                ==> Id = 100 , Name = Ahmed , Age = 200
            //}

            // using Continue
            //for (int i = 0; i < 10; i++) 
            //{
            //    if (i == 3)
            //        continue;
            //    Console.WriteLine(i);
            //}
            //// using break
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 3)
            //        break;
            //    Console.WriteLine(i);
            //}
            #endregion

            // break ==> used inside Loops and Switch statements / Doesn't return a value
            //       ==> will stop the loop but continue the Method
            //       
            // return ==> used inside methods{functions} / can return a value [Optional]
            //        ==> will stop the loop and the method

            #endregion

            #region Lopping statements [while - do while]

            #region do while
            //// let user enter even number 
            //// if value odd or it's not a number ==> enter value again
            //// else ==> print the even number
            //int number;
            //bool isnumberParsed;
            //do { 
            //Console.WriteLine("Please enter an even number");
            //isnumberParsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!isnumberParsed || number % 2 != 0); // or number % 2 == 1
            ////if isnumberParsed false ==> then !false ==> True 
            ////if isnumberParsed true ==> then !true ==> false 
            //// if number % 2 != 0 ==> true this mean number that entered is odd not even
            //Console.WriteLine(number);


            // use do while when you can not know how itteration can you loop 
            // if you know how iteration will happen then use while 
            // do while used when you know or didn't know number of itteration

            #endregion

            #region while
            // take a number from user and print
            // a sequence of number from number enterd to 10
            // 5 => 5,6,7,8,9,10
            // 2 => 2,3,4,5,6,7,8,9,10

            //int number;
            //bool isnumberParsed;
            //Console.WriteLine("Please enter a number <= 10");
            //isnumberParsed = int.TryParse(Console.ReadLine(), out number);
            //Console.Clear();
            //if (isnumberParsed) 
            //{
            //    while (number <= 10)
            //    {
            //        Console.WriteLine(number);
            //        number++;
            //    }
            //}


            // if you have 1 condtion and you know that will check about this condition 1 try only then use if condition
            // not put condtion that you nned to chek for 1 try only not put in while or do while
            // make it alone in if condition then use while or  do while 
            // like in the example above in isnumberParsed
            #endregion

            #endregion

            #region String
            // Is a Built in Class [Reference Data Type ] and represente
            // They are immutable mean 8er kabl ll ta8er [once a string object is created , its ]
            // Any Operation that modifies a string actually creates a 
            // Internally is represented as an array of characters .
            // Each character in the string corresponds to a single char

            // zero based

            #region Examples
            //string name = new string("Mariam");
            ////or
            //name = "Ahmed"; // syntax sugar
            ////or
            //String name2 = "Ahmed";

            //Console.WriteLine(name);
            //Console.WriteLine($"{name.GetHashCode()}\n");
            //Console.WriteLine(name2);
            //Console.WriteLine($"{name2.GetHashCode()} \n\n");
            //name2 = "Basha";
            //Console.WriteLine(name);
            //Console.WriteLine($"{name.GetHashCode()}\n");
            //Console.WriteLine(name2);
            //Console.WriteLine($"{name2.GetHashCode()} \n\n");

            //string name = "Hello";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //name += " Ahmed";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            #endregion

            #region String Methods
            //// we have 2 types of methods ==>
            //// 1. Static Method or Class member method ==> you can reach it direct from name of class like string class like ==> string. choose method
            //// 2. Non Static Method or Object member method ==> you can reach it from instance that you created from class like name that created from class string like name. choose method
            //string name = "Hello Mariam";
            //string name2 = "               Hello Ahmed             ";

            //// we focus on non static method now 

            //Console.WriteLine(name.Length); // number of characters based on 1 not 0 and count space if exist 
            //                                // put lenght ==> is property not method 

            //Console.WriteLine(name.ToLower()); // return string in lower case
            //Console.WriteLine(name.ToUpper()); // return string in upper case

            //Console.WriteLine(name.Replace("Hello" , "Hey")); // can replace char by char or string by string
            //                                                  // but take care about case sensitivity
            //Console.WriteLine(name.Replace("a","m"));
            //// if you need to ignore case sensitivty make this 
            //Console.WriteLine(name.Replace("hello" , "hey" , StringComparison.OrdinalIgnoreCase));

            //Console.WriteLine(name.Remove( 0 /*start index to remove*/, 6 /*end index to stop remove*/));

            //Console.WriteLine(name2.Trim()); // remove all spaces from left and right
            //                                 // but if have space in middle don't remove it
            //                                 // becuase it thought that you put it by your self

            //Console.WriteLine(name2.TrimEnd());// remove space from end or from left
            //Console.WriteLine(name2.TrimStart());// remove space from start or from right


            #endregion

            #endregion

            #region StringBuilder
            // IS a built in class [Reference data type ] and represente
            // Mutable string mean ==> law 7abet 23dl fe el string bta3y ana ba3dl fe nafs el mkan
            // LinkedList of characters ==> me4 bet5azn el data wara ba3d kolha
            //                          ==> me4 bet5zenha fe sequence wara ba3d zay el array kdah la2 
            //                          ==> 2wl node by4awr 3aleh me4 bett8yer nha2y
            //                          ==> bedalel kol mara hatgeb el hashcode hatl2eh hwa hwa sabt

            // to use Stringbuilder should first use namespace of string builder which is 
            // ==> using System.Text;

            #region Examples

            //StringBuilder name; // alocte 4 bytes in stack for reference
            //name = new StringBuilder("Mariam"); // ==> vailde
            ////or
            ////name = "Ahmed"; ==> Invalid

            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());

            ////name += "Shindy"; // ==> Invalid

            //// if you need to add then use function or method append that add in last place in string

            //name.Append(" Shindy");
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());


            //StringBuilder name = new StringBuilder("Mariam");
            //StringBuilder name2 = new StringBuilder();

            //name2.Append("Mariam");

            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());
            //Console.WriteLine();

            //Console.WriteLine("Change name1");
            //name = name2;

            //Console.WriteLine();
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine(name2);
            //Console.WriteLine(name2.GetHashCode());

            #endregion

            #region StringBuilder Method
            //StringBuilder name = new StringBuilder("Mariam");
            //StringBuilder msg = new StringBuilder("Mariam");
            //int age = 20;

            //Console.WriteLine(name.Length);

            //name.AppendLine(" Shindy"); // append string in end and betnzel satr or line
            //name.Append("Hello");
            //Console.WriteLine(name);

            //// make like append but with sperator and many values
            //name.AppendJoin("," /*take sperator*/, " Yasser"/*values*/, "Omar"/*values*/ , "Shindy" /*values*/);
            //Console.WriteLine(name);

            //msg.AppendFormat(" Your age is {0}" , age);
            //Console.WriteLine(msg);

            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());
            //msg.Clear(); // reomve charcter from place in heap but place in heap still reserved 
            //            // and to proof that see hashcode
            //Console.WriteLine(msg);
            //Console.WriteLine(msg.GetHashCode());

            //Console.WriteLine(name.Remove(0,2)); // like the method in string

            //Console.WriteLine(name.Replace("m" , "j")); // like the method in string
            //Console.WriteLine(name.Replace("Mariam", "ahmed")); // like the method in string

            //Console.WriteLine(name.Insert(0 /*start index to insert on it*/, "Hey" /*value that you will insert it*/));

            #endregion

            #endregion

            #region String Vs StringBuilde
            /*
             simple and few concatenations ==> use string
             Large loops or frequent changes ==> use StringBuilder
             You care about Performance ==> use StringBuilder
             You care about code simplicity ==> use string
             */
            #endregion

            #region 1D Array

            //Array arr = new Array(); //==> Invalid becuase array is abstract can not make instance from it

            // then use syntax sugar
            //int[] numbers; // allocte 4 bytes in stack 

            //numbers = new int[4]; // new make 4 somethings
            //                      //1. allocate required bytes in heap ==> [4 for size * 4 for int] = 16 bytes
            //                      //2. initialize defualt values in int = 0
            //                      //3. Call user fedined constructor if exist
            //                      //4. Assign reference that exist in stack to instance that exist in heap

            //// to put data make these :
            //int[] numbers1;
            //numbers1 = new int[4] {1,2,3,4};

            //// or remove size and he will know the size from data 
            //int[] numbers2;
            //numbers2 = new int[] { 1, 2, 3, 4 };

            //// or
            //int [] numbers3 = {1 ,2 ,3 ,4};
            ////not make this becuase not valid
            ////int [] numbers3 ;
            ////numbers3 = {1 ,2 ,3 ,4};

            //// or use [] instead of {}
            //int[] numbers4 = [ 1, 2, 3, 4 ];

            ////or
            //int[] numbers5 = new int[4];
            //numbers5[0] = 1;
            //numbers5[1] = 2;
            //numbers5[2] = 3;
            //numbers5[3] = 4;

            ////or
            //int [] numbers6 = new int[4];
            //Array.Fill(numbers6, 5); // it will but number 5 4 times in array o/p will be {5,5,5,5}
            //                         // this method used if you need to reapet element in array

            ////or
            //// should the return value recieve it in array
            //Array arr = Array.CreateInstance (typeof(int)/*type of array*/, 4 /*length or size*/);
            ////to put data in arr
            //arr.SetValue (1 /*value the will store it*/,0 /*index that will store value on it*/);
            //arr.SetValue(2 /*value the will store it*/, 1 /*index that will store value on it*/);
            //arr.SetValue(3 /*value the will store it*/, 2 /*index that will store value on it*/);
            //arr.SetValue(4 /*value the will store it*/, 3 /*index that will store value on it*/);
            ////to get value or see it 
            //Console.WriteLine(arr.GetValue ( 0 /*index*/));
            //Console.WriteLine(arr.GetValue ( 1 ));
            //Console.WriteLine(arr.GetValue ( 2 ));
            //Console.WriteLine(arr.GetValue ( 3 ));

            //// make array of object have different data type 
            //object[] data = new object[3] { 1, "Ahmed", true };
            //// to print data
            //foreach ( var item in data )
            //{  Console.WriteLine(item); };


            //int[]numbers7 = new int[4] {1,2,3,4};

            //// static
            //for (int i = 0; i < 4; i++)
            //{ Console.WriteLine(numbers7[i]); }
            //// dynamic
            //for ( int i = 0; i < numbers7.Length; i++ )
            //{ Console.WriteLine(numbers7[i]); };


            //int[] numbers8 = new int[5];
            //// To enter data from user
            //for (int i = 0; i < numbers8.Length ; )
            //{
            //    Console.WriteLine($"Please enter the array element {i+1}");
            //    bool isParsed = int.TryParse(Console.ReadLine(), out numbers8[i]);
            //    if ( isParsed)
            //    {
            //        i++;
            //    }
            //};
            //// to print data that user enter
            //for (int i = 0;i < numbers8.Length; i++ )
            //{ Console.WriteLine(numbers8[i]); }

            //int [] numbers9 = new int[5] {1,2,3,4,5};
            //foreach (var number in numbers9)
            //{
            //    Console.WriteLine(number);

            //}

            ////**************** Note ***************

            ////defualt of char is ( \0 )
            //char[] characters = new char[3];

            //char m = default;
            //Console.WriteLine(m); // o/p will be default value that is empty
            //Console.WriteLine((int)m); // o/p will be default value that is 0 becuase making casting to int


            //Console.WriteLine(numbers9.Length); // return size of array
            //Console.WriteLine(numbers9.Rank); // return deminsion 1D or 2D

            #region Array advantages and disadvantages
            //Advantges :-
            //1] Fast Access, is O(1) time.

            //Disadvantage :-
            //1] Fixed Size
            #endregion

            #endregion

            #region 2D Array

            //int[,] marks = new int[2 /*rows*/ , 5 /*columns*/];
            //marks[0, 0] = 100;
            //marks[0, 1] = 200;
            //marks[0, 2] = 300; 
            //marks[0, 3] = 400;
            //marks[0, 4] = 500;
            //marks[1, 0] = 600;
            //marks[1, 1] = 700;
            //marks[1, 2] = 800;
            //marks[1, 3] = 900;
            //marks[1, 4] = 1000;
            //Console.WriteLine(marks[0, 0]);
            //Console.WriteLine(marks[0, 1]);
            //Console.WriteLine(marks[0, 2]);
            //Console.WriteLine(marks[0, 3]);
            //Console.WriteLine(marks[0, 4]);
            //Console.WriteLine(marks[1, 0]);
            //Console.WriteLine(marks[1, 1]);
            //Console.WriteLine(marks[1, 2]);
            //Console.WriteLine(marks[1, 3]);
            //Console.WriteLine(marks[1, 4]);

            //or

            //allocte 2*5*4 = 40 bytes in stack
            //int[,] data = new int[2, 5] { {100,200,300,400,500 }, {600,700,800,900,1000 } };
            //Console.WriteLine(data[0, 0]);
            //Console.WriteLine(data[0, 1]);
            //Console.WriteLine(data[0, 2]);
            //Console.WriteLine(data[0, 3]);
            //Console.WriteLine(data[0, 4]);
            //Console.WriteLine(data[1, 0]);
            //Console.WriteLine(data[1, 1]);
            //Console.WriteLine(data[1, 2]);
            //Console.WriteLine(data[1, 3]);
            //Console.WriteLine(data[1, 4]);

            ////static
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine(data[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            ////dynamic
            //for (int i = 0; i < data.GetLength(0)/* 0 mean row*/; i++)
            //{
            //    for (int j = 0; j < data.GetLength(1)/* 1 mean column*/; j++)
            //    {
            //        Console.WriteLine(data[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine(data.Length); // 10 = 2*5
            //Console.WriteLine(data.Rank); // 2D

            // to take data from user
            //int[,] data = new int[2, 5];

            //for (int i = 0; i < data.GetLength(0)/* 0 mean return number of row*/; i++)
            //{
            //    Console.WriteLine($"Please enter student number {i + 1} info");
            //    for (int j = 0; j < data.GetLength(1)/* 1 mean return number of column*/;)
            //    {
            //        Console.WriteLine($"Please enter the grade for subject{j + 1}");
            //        bool isParsed = int.TryParse(Console.ReadLine(), out data[i, j]);
            //        if (isParsed)
            //        {
            //            j++;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.Clear();

            ////To print data 
            //for (int i = 0; i < data.GetLength(0)/* 0 mean return number of row*/; i++)
            //{
            //    Console.WriteLine($"Info for student number {i + 1}");
            //    for (int j = 0; j < data.GetLength(1)/* 1 mean return number of column*/; j++)
            //    {
            //        Console.Write($"{data[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}



            // How to loop through 2D array using one loop
            #endregion
        }
    }
}


