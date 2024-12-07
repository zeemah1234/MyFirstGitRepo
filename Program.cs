/*
//code challenge
using System.Collections;
using System.ComponentModel;

string CreatePhoneNumber(int[] numbers)
{
    string countryCode = $"({numbers[0]}{numbers[1]}{numbers[2]}) ";
    string rest = $"{numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
    return countryCode + rest;
}


Console.WriteLine(CreatePhoneNumber(new int[]{1,2,3,4,5,6,7,8,9,0}));



//what are Methods
//methods are a way to organize code into reusable blocks.


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Welcome to our Simple Calculator App");
Console.BackgroundColor = ConsoleColor.White;
Console.ResetColor();
Console.WriteLine("Enter 1 to Multiply\nEnter 2 to Add\nEnter 3 to Subtract\nEngter 4 to Divide\nEnter 5 for Modulo");
bool userInput = int.TryParse(Console.ReadLine(), out int value);
if (userInput == false)
{
    Console.WriteLine("Wetin be this!!");
    Console.WriteLine("Gimme number boboyi");
}
else if (value > 5 || value > 1){
    Console.WriteLine("Read the instruction");
}
else 
{
    Console.WriteLine("Your head dey there");
}


switch (value)
{
   case 1: 
         int input = Prompt("Enter Your First Number: ");
         int input2 = Prompt("Enter Your Second Number: ");
         float multiplyResult = Multiply(input, input2);
         Console.WriteLine("The result is {0}", multiplyResult);
         break;
    case 2: 
          int add1 = Prompt("Enter Your First Number: ");
          int add2 = Prompt("Enter Your Second Number: ");
          int addResult = Add(add1, add2);
          Console.WriteLine("The reault is {0}", addResult);
          break;
    case 3:
          int subtract1 = Prompt("Enter Your First Number: ");
          int subtract2 = Prompt("Enter Your Second Number: ");
          int subtractResult = Subtract(subtract1, subtract2);
          Console.WriteLine("The result is {0}", subtractResult);
          break;
    case 4:
         int nominator = Prompt("Enter Your First Number: ");
         int denominator = Prompt("Enter Your Second Number: ");
         decimal divideNums = Divide(nominator, denominator);
         Console.WriteLine(divideNums);
         break;
    case 5: 
         int modulo = Prompt("Enter Your First Number: ");
         int moduloSecondNum = Prompt("Enter Your Secod Number: ");
         int remainder = Modulo(modulo, moduloSecondNum);
         Console.WriteLine(remainder);
         break;
    default:
        Console.WriteLine("Not Found");
        break;
}

// Multiplication --> Float
float Multiply(int a, int b)
{
    return a * b;
}

// Addition --> int
int Add(int a, int b)
{ 
   return a + b;
}
//Subtraction --> int
int Subtract(int a, int b)
{
    return a - b;
}
//Divison --> decimal
decimal Divide(int a, int b)
{
    return a / b;
}
// Modulo --> int 
int Modulo(int a, int b)
{
    return a % b;
}

int Prompt(string text)
{
    Console.Write(text);
    bool value = int.TryParse(Console.ReadLine(), out int result);
    while (value == false)
    {
        if (value == false)
        {
            Console.Write("Enter a Valid Number: ");
        }
        value = int.TryParse(Console.ReadLine(), out result);


    }
    return result;

}


//Two Arrays from the user
// Equality -->
// if length is the same or all elements at the same index are equal



bool Question2()
{
    bool result = true;
    Console.WriteLine("Enter length of the first input (array): ");
    bool lengthOfFirstArray = int.TryParse(Console.ReadLine(), out int valueofLengthOfFirstArray);
    if (lengthOfFirstArray == false)
    {
        Console.Write("Please Input a valid Number");
    }
    else 
    {
        Console.WriteLine("your head dey there");
        Console.Write("Enter length of the second input(array): ");
        bool lengthOfSecondArray = int.TryParse(Console.ReadLine(), out int valueOfLengthOfSecondArray);
        if (lengthOfSecondArray == false)
        {
            Console.WriteLine("Please Input a valid number");
        }
         else 
         {
             if (valueofLengthOfFirstArray != valueOfLengthOfSecondArray)
             {
                 return false;
             }
             var firstArray = new int[valueofLengthOfFirstArray];
             var secondArray = new int[valueOfLengthOfSecondArray];

            for (int i = 0; i < valueofLengthOfFirstArray; i++)
            {
                Console.WriteLine($"Enter value for first array for the index {i}: ");
                firstArray[i] = int.Parse(Console.ReadLine()!);
            }
                for (int j = 0; j < valueOfLengthOfSecondArray; j++)
            {
               Console.Write($"Enter value for second array for index {j}: ");
              secondArray[j] = int.Parse(Console.ReadLine()!);
    
            }
             int pointer = 0;
             while (result)
             {
                 if (firstArray[pointer] == secondArray[pointer])
                 {
                   if (pointer < firstArray.Length -1)
                     {
                         pointer++;

                    }
                    else{
                        return result;
                   }
                
                }
                else
               {
                   result= false;
               }

                
          }
           

       }

          
 }
  return result;

 }

 var result = Question2();
switch (result)
 {
     case true:
                Console.WriteLine("The arrays are equal ");
           break;
     case false:
          Console.WriteLine("The arrays are not equal ");
                    break;
     default:
         break;    
 }
*/



 //Reverse string
 void Reversed()
{
    char[] myName = ['A', 'W', 'W','A', 'L',];
     char[]reversed = new
    char[myName.Length];
    int i, j =0;
     for (i = myName.Length - 1; i >= 0; i--)
    {
        reversed[j] = myName[i];
        j++;
    }

        foreach (var item in reversed)
        {
           Console.Write(item);
        }

}
    
 



 // Refactored
  string ReverseImplementation(string word)
 {
   char[] reversed = new char[word.Length];
    int i, j = 0;
    for (i = word.Length -1; i >= 0;i--)
   {
     reversed[j] = word[i];
     j++;
    }

       return new string(reversed);
 }

    var secondAttempt =  ReverseImplementation("Awwal");
    Console.WriteLine(secondAttempt);


