int x = 12 * 30;
Console.WriteLine(x);

Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100));
SayHello();

int @using = 123; //using reserved keyword
Console.WriteLine(@using);/*pritn
                           the reserved keyword*/

Console.WriteLine(1+2+3+4+5+6+7+8+9+10);

const int y = 360;

int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}

void SayHello()
{
    Console.WriteLine("Hello, world");
}