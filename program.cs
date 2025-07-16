using System;
using Newtonsoft.Json;
class Program
{
    static void Main()
    {
        Console.WriteLine("Endor Labs Sample Project!");
        string json = JsonConvert.SerializeObject(new { message = "Hello" });
        Console.WriteLine(json);
    }
}
