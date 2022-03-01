//Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2,
// b1 k1 и b2 и k2 заданы

float FindY(float k, float x, float b)

{
    float y = (k * x) + b;
    return y;
}

Random randomizer = new Random();

float k1 = randomizer.Next(1,11);

float k2 = randomizer.Next(1,11);

float b1 = randomizer.Next(1,11);

float b2 = randomizer.Next(1,11);

float x;
float y1;
float y2;

x = (b2 - b1)/(k1-k2);
y1 = FindY(k1, x, b1);
Console.WriteLine($"y1 = {y1}");
y2 = FindY(k2, x, b2);
Console.WriteLine($"y2 = {y2}");


Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2}");


if(y1 == y2 && (k1 != k2))
{
    float y = y1;

    Console.WriteLine($"Точки пересечения x = {x}, y = {y}");
}
else
{
    Console.WriteLine("Точек пересечения нет");
}

