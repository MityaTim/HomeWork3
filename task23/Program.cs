string? readStr = Console.ReadLine();
if (!int.TryParse(readStr, out int n)) throw new Exception(readStr + "is not number");
for (int i = 1; i <= n; i ++)
    Console.Write(i * i * i + " ");
