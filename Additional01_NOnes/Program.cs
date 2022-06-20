/* Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
N = 4 -> 1, 1, 1, 1
N = 2 -> 1, 1
*/

Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
int start = 1;

while (start < (a + 1))
{
    if (start < a)
    {
        Console.Write("1, ");
    }
    else
    {
        Console.WriteLine("1");
    }
    start++;
}
