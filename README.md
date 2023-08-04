# System.Math_Demo

**What is the System.Math class in C# and what are its common use cases?**

The System.Math class in C# provides mathematical functions and constants for performing common mathematical operations, such as arithmetic,
trigonometry, logarithms, and rounding. It is commonly used for performing mathematical calculations and operations in various scientific, 
financial, and statistical applications.

**Explain the difference between Math.Floor(), Math.Ceiling(), and Math.Round() methods in C#.**

In C#, Math.Floor() method returns the largest integer less than or equal to a specified number, 
Math.Ceiling() method returns the smallest integer greater than or equal to a specified number, and Math.Round() method rounds a specified number to the nearest integer
or to a specified number of decimal places, using rounding rules.

For example:

double number = 3.7;
double floorResult = Math.Floor(number); // 3
double ceilingResult = Math.Ceiling(number); // 4
double roundResult = Math.Round(number); // 4

**How can you perform advanced mathematical operations in C# using the System.Math class?**

The System.Math class in C# provides a wide range of mathematical functions for performing advanced mathematical operations.
Here are some examples of commonly used System.Math functions:

Calculating square root:

double num = 25;
double squareRoot = Math.Sqrt(num);

Calculating power:

double baseNumber = 2;
double exponent = 3;
double result = Math.Pow(baseNumber, exponent);

Rounding numbers:

double number = 3.7;
int rounded = (int)Math.Round(number);

Generating random numbers:

Random random = new Random();
int randomNumber = random.Next(1, 101); // generates a random number between 1 and 100

Trigonometric functions:

double angle = Math.PI / 4; // 45 degrees in radians
double sine = Math.Sin(angle);
double cosine = Math.Cos(angle);
double tangent = Math.Tan(angle);

Converting degrees to radians and vice versa:

double degrees = 45;
double radians = Math.PI * degrees / 180; // convert degrees to radians
double convertedDegrees = radians * 180 / Math.PI; // convert radians to degrees

Other mathematical functions:

The System.Math class also provides many other mathematical functions, such as logarithmic functions, exponential functions, absolute value,
ceiling, floor, etc. You can refer to the official Microsoft documentation for a comprehensive list of System.Math functions and their usage.
