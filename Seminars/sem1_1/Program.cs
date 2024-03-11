// System.Console.Write("Input first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number2 * number2 == number1)
// {
//     System.Console.WriteLine("True");
// }
// else
// {
//     System.Console.WriteLine("False");
// }

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = -n;
// while(start <= n)
// {
//     System.Console.Write(start + " ");
//     start++;
// }

System.Console.WriteLine("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999) //456
{
    int ed = num % 10; // вывод остатка от деления (отделяем единицы) = здесь хранится 6
    int sot = num % 100; // целочисленное деление (отделение сотни) = здесь хранится 4
    System.Console.WriteLine($"{num} -> {ed + sot}");
}
else 
{
    System.Console.WriteLine("You have input not three-digit number");
}