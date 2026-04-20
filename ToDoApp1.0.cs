using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Список дел");

        List<string> tasks = new List<string>()
        {
            "Сделать уроки",
            "Купить продукты",
            "Позвонить другу"
        };

        foreach (string task in tasks)
        {
            Console.WriteLine("- " + task);
        }
    }
}


