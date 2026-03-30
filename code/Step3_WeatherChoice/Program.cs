// See https://aka.ms/new-console-template for more informatio
Console.WriteLine("Выбор одежды по погоде");
Console.Write("Введите текущею температуру(С):");
int temperature =  Convert.ToInt32(Console.ReadLine());
if(temperature >= 20)
{
    Console.WriteLine("Наденьте легкую одежду");
}
else
{
    Console.WriteLine("Наденьте тёплую одежду");
}
Console.WriteLine("Хорошего дня!");
