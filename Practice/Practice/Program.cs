
using Practice;

Console.WriteLine("main method started");

AsyncClass asyncClass = new AsyncClass();
asyncClass.SomeMethod();
Console.WriteLine("main method end");
for (int i = 0; i <= 200; i++)
{
    Console.WriteLine(i);
}
Console.ReadKey();