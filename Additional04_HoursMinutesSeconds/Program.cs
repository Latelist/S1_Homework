/* Дано N секунд. Вывести время в формате часы:минуты:секунды.
N = 72334 -> 20:5:34 
*/

Console.WriteLine("Input number of seconds: ");
int N = Convert.ToInt32(Console.ReadLine());
int hours = N / 3600;
int minutes = (N % 3600) / 60;
int seconds = (N % 3600) % 60;

Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);