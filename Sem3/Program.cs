// Напишите программу ,котора принимает на вход координаты точки  (X,Y) , причем x не равен 0 и 
// не равен 0 и выдает номер четверти плоскости, в которой находится эта точка

Console.WriteLine ("введите x");
int x = int.Parse(Console.ReadLine());

Console.WriteLine ("введите y");
int y = int.Parse(Console.ReadLine());

if(x>0 && y>0)
{
    Console.WriteLine("Первая плоскость");
}
else if(x<0 && y>0)
{
    Console.WriteLine("Вторая плоскость");
}
else if(x<0 && y<0)
{
    Console.WriteLine("Третяя плоскость");
}
else if(x>0 && y<0)
{
    Console.WriteLine("Четвёртая плоскость");
}
else 
{
    Console.WriteLine("Координаты не принадлежат пллоскости");
}


