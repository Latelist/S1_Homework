/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a % 2) > 0)
{
    Console.WriteLine("No, the number isn't even");
}
else
{
    Console.WriteLine("Yes, the number is even");
}