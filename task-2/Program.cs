//Дано словник. Видалити пробіли в значеннях його ключів

using System.Text.Json;

Dictionary<int, string> dic = new Dictionary<int, string>()
{
    [1] = "group IK-34",
    [2] = "  group IK- 31",
    [3] = "gro up IA-44  ",
    [4] = "    hejrbfhe wjrfnj wjfn   "
};

Console.WriteLine("Initial Dictionary:");
foreach (var key in dic)
{
    Console.WriteLine($"num -> {key.Key}, Name -> {key.Value}");
}

dic = Remover(dic);
JSON(dic);

Dictionary<int, string> Remover(Dictionary<int, string> dic)
{
    for (int i = 1; i < dic.Count + 1; i++)
    {
        dic[i] = dic[i].Replace(" ", string.Empty);
    }

    Console.WriteLine("\nNew Dictionary:");
    foreach (var key in dic)
    {
        Console.WriteLine($"num -> {key.Key}, Name -> {key.Value}");
    }
    return dic;
}

string[] JSON(Dictionary<int, string> dic)
{
    string json = JsonSerializer.Serialize(dic);
    string filePath = "dic.json";
    File.WriteAllText(filePath, json);
    string[] reader = File.ReadAllText(filePath).Split(',');

    Console.WriteLine("\nJSON file:");
    foreach (string line in reader)
    {
        Console.WriteLine(line);
    }

    string currentDirectory = Path.GetFullPath(filePath);
    Console.WriteLine("\n File location:\n" + currentDirectory);
    return reader;
}