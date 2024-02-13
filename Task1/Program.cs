// Task 1: Напишите программу,
// которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
int n1 = 7;
int n2 = 23;
Console.WriteLine("Введите целое положительное число.");
int num = Convert.ToInt32(Console.ReadLine());
if (num % n1 == 0 && num % n2 == 0)
{
    Console.WriteLine($"Число {num} кратно 7 и 23.");
}
else
{
    Console.WriteLine($"Число {num} не кратно 7 и 23.");
}
