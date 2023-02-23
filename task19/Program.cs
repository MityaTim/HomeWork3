string? readStr = Console.ReadLine();
if (!int.TryParse(readStr, out int _)) throw new Exception(readStr + " is not number");
if (readStr.Length != 5) throw new Exception("number length is not 5");
Console.WriteLine(readStr == new string(readStr.Reverse().ToArray()) ? "Да" : "Нет");
