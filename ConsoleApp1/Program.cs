using ConsoleApp1;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

MyDate startDate = new MyDate(2023, 9, 2, 10, 30);
Console.WriteLine($"Дата відправлення: {startDate.getYear()}.{startDate.getMonth()}.{startDate.getDay()}  {startDate.getHours()}:{startDate.getMinutes()}");

MyDate finishDate = new MyDate(2023, 12, 23, 16, 45);
Console.WriteLine($"Дата прибуття: {finishDate.getYear()}.{finishDate.getMonth()}.{finishDate.getDay()}  {finishDate.getHours()}:{finishDate.getMinutes()}");

Airplane flight = new Airplane("Житомир", "Париж", startDate, finishDate);

Console.WriteLine($"Час польоту: {flight.GetTotalTime()} хвилин");
Console.WriteLine($"Прибув сьогодні? {flight.IsArrivingToday()}");