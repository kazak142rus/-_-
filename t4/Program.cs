// Напишите программу, которая на вход 
// принимает натуральное число N, а на выходе 
// показывает его цифры через запятую, в обратном порядке.

Console.WriteLine("Введите любое натуральное число.");
int num = Convert.ToInt32(Console.ReadLine());
int result =0;
while (num >10){
    result = num%10;
    Console.Write($"{result},");
    num/=10;
}
num%=10;
Console.Write($"{num}.");