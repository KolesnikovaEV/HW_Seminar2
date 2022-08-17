// Как работает Split
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Select(point => (point.x * 10, point.y ))
                .ToArray();
for (int i = 0; i<data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
}
