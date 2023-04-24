//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine ("Введите 1 число"); 
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int Number2 = Convert.ToInt32(Console.ReadLine());

if(Number1 > Number2)
{
        Console.WriteLine($"a = {Number1}; b = {Number2} -> Max = {Number1}");}
else
{
    Console.WriteLine($"a = {Number1}; b = {Number2} -> Max = {Number2}");}
