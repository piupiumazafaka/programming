// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine()); //256

// if(num>99 && num<=1000)
// {
// int FirstL1 = num/100; //2
// int num3 = num%10; //6

// int result = FirstL1*10 + num3; // чтобы все сложилось
// System.Console.WriteLine(result);
// }
// else
// {
//     System.Console.WriteLine("Число не трехзначное");
// }

// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

int num = new Random().Next(100, 1000);  // 487
Console.WriteLine(num);

int num2 = num/10 % 10;   // 487 /10= 48   48%10 = 8
int num3= num%10;
int result=1;

while(num3>0)
{
    result = result*num2;
    num3= num3-1;
}

Console.WriteLine(result);