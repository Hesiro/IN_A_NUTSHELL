using Basics;

int x = 12 * 30;
Console.WriteLine(x);

Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100));

int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}

SayHello();

void SayHello()
{
    Console.WriteLine("Hello, world");
}

int @using = 123; //using reserved keyword
Console.WriteLine(@using);/*pritn
                           the reserved keyword*/

Console.WriteLine(1+2+3+4+5+6+7+8+9+10);

const int y = 360;

string message = "Hello world";
string upperMessage = message.ToUpper();
Console.WriteLine(upperMessage);

int x1 = 2022;
message = message + x1.ToString();
Console.WriteLine(message);

bool simpleVar = false;
if (simpleVar)
    Console.WriteLine("This will not print");

int x3 = 5000;
bool lessThanAMile = x3 < 5280;
if (lessThanAMile) 
    Console.WriteLine("This will print");

UnitConverter feetToInchesConverter = new UnitConverter(12);
UnitConverter milesToFeetConverter = new UnitConverter(5280);

Console.WriteLine(feetToInchesConverter.Convert(30));
Console.WriteLine(feetToInchesConverter.Convert(100));

Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));

Panda p1 = new Panda("Pan Dee");
Console.WriteLine(Panda.Population);
Panda p2 = new Panda("Pan Dah");
Console.WriteLine(Panda.Population);

Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);
