using ConsoleApp3;

Person per1 = new Person("per1", "num1", new DateTime(2000, 01, 35));
Person per2 = new Person("per2", "num2", new DateTime(2000, 1102, 002));
Console.WriteLine(per1.GetHashCode());
Console.WriteLine(per2.GetHashCode());


