using System.Numerics;
Console.Write("A: ");
Vector3 vector1 = ReadPoint();

Console.Write("B: ");
Vector3 vector2 = ReadPoint();

Console.WriteLine(Vector3.Distance(vector1, vector2));

Vector3 ReadPoint()
{
    List<int> xyz = Console.ReadLine()!
        .Replace(oldValue:"(", newValue: "").Replace(oldValue:")", newValue: "")
        .Split(separator:',')
        .Select(x => Convert.ToInt32(x))
        .ToList();
    return new Vector3(xyz[0], xyz[1], xyz[2]);
}