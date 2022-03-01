// Написать программу масштабирования фигуры
// k = 5

using System.Linq;
string squareCoordinates = "(20,20) (20,25) (25,20) (25,25)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine(squareCoordinates);
var data = squareCoordinates.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: double.Parse(e[0]), y: double.Parse(e[1])))
                .Select(point => (point.x * 5, point.y * 5))
                .ToArray();
for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}