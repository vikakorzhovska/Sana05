using ConsoleApp1;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
MyDate date1 = new MyDate();
Console.WriteLine($"Дата за замовчуванням: {date1.getYear()}.{date1.getMonth()}.{date1.getDay()}  {date1.getHours()}:{date1.getMinutes()}");

MyDate date2 = new MyDate(2005, 12, 29, 12, 30);
Console.WriteLine($"Дата з параметрами: {date2.getYear()}.{date2.getMonth()}.{date2.getDay()}  {date2.getHours()}:{date2.getMinutes()}");

MyDate date3 = new MyDate(date2);
Console.WriteLine($"Скопійована дата: {date3.getYear()}.{date3.getMonth()}.{date3.getDay()}   {date3.getHours()}:{date3.getMinutes()}");