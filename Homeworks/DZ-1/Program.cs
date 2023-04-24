//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine ("Введите 1 число"); 
// int Number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число");
// int Number2 = Convert.ToInt32(Console.ReadLine());
// if(Number1 > Number2)
// {
//         Console.WriteLine($"a = {Number1}; b = {Number2} -> Max = {Number1}");}
// else
// {
//     Console.WriteLine($"a = {Number1}; b = {Number2} -> Max = {Number2}");}


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
// Console.WriteLine ("Введите 1 число"); 
// int Number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число");
// int Number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 3 число");
// int Number3 = Convert.ToInt32(Console.ReadLine());

// if(Number1 > Number2)
// {
//         if (Number1 > Number3)
//              {Console.WriteLine($"{Number1}, {Number2}, {Number3}  -> Max = {Number1}");}
//     else
//        {Console.WriteLine($"{Number1}, {Number2}, {Number3}  -> Max = {Number3}");}}
//   else if (Number2 > Number3)
//    {Console.WriteLine($"{Number1}, {Number2}, {Number3} -> Max = {Number2}");} 
//     else 
//      {Console.WriteLine($"{Number1}, {Number2}, {Number3}  -> Max = {Number3}");} 
  
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine ("Введите число"); 
int Number = Convert.ToInt32(Console.ReadLine());

if(Number % 2 == 0)
{
        Console.WriteLine($" {Number} -> Да");}
else
{
    Console.WriteLine($"{Number}-> Нет");}