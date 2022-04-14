//Uzdevums #1 - greetings console app.
string userName;
Console.WriteLine("Hey, what's your name?");
userName = Console.ReadLine();
Console.WriteLine("Hi {0}", userName);

//Uzdevums #2 - int.Parse
int age;
Console.WriteLine("What is your age?");
age = int.Parse(Console.ReadLine());
Console.WriteLine("Next year you're going to be {0} years old", ++age);

//Uzdevums #3 - Math.Max
int firstNumber, secondNumber;
Console.WriteLine("Please enter 2 numbers to compare and get the biggest of them");
Console.WriteLine("please enter the 1st number:");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the 2nd number:");
secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Bigger of both is {0}", Math.Max(firstNumber, secondNumber));

//Uzdevums #4 - Math.Min
Console.WriteLine("Please enter 2 numbers to compare and get the smallest of them");
Console.WriteLine("please enter the 1st number:");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("please enter the 2nd number:");
secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Smallest of both is {0}", Math.Min(firstNumber, secondNumber));

//Uzdevums #5 - %
Console.WriteLine("Enter 2 numbers to find the remainder of the 2");
Console.WriteLine("please enter the 1st number:");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("please enter the 2nd number:");
secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Remainder of dividing the 2 is: {0}", firstNumber % secondNumber);

//Uzdevums #6 - Odd or even
bool isEven;
Console.WriteLine("Enter a number to determine whether it is odd or even");
firstNumber = int.Parse(Console.ReadLine());
isEven = firstNumber % 2 == 0;
Console.WriteLine("Number {0} is even: {1}", firstNumber, isEven);

//Uzdevums #7 - square area
double sideA, sideB, squareArea;
Console.WriteLine("Square area calculator");
Console.WriteLine("Please enter length of the first side");
sideA = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter length of second side");
sideB = double.Parse(Console.ReadLine());

squareArea = Math.Round((sideA * sideB), 2);
Console.WriteLine("The area of the square is: {0}", squareArea);

//Uzdevums #8 - 45 45 90 triangle area
double triangleArea;
Console.WriteLine("This will calculate an area of a 45 45 90 triangle based on side length");
Console.WriteLine("Please enter length of 1 side");
sideA = double.Parse(Console.ReadLine());

triangleArea = (sideA * sideA) / 2;
Console.WriteLine("The area of the triangle is: {0}", triangleArea);


//Uzdevums #9 - interpolation
Console.WriteLine("Please enter your name:");
userName = Console.ReadLine();
Console.WriteLine("Now enter your age: ");
age = int.Parse(Console.ReadLine());

Console.WriteLine($"Hi {userName}! You are {age} years old");