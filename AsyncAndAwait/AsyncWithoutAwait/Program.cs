

using AsyncWithoutAwait;

Console.WriteLine("main method started");

AsyncClass asyncClass = new AsyncClass();
asyncClass.SomeMethod();
Console.WriteLine("main method end");

Console.ReadKey();