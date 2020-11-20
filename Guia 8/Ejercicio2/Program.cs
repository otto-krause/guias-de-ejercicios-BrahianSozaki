using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString;
            jsonString = JsonSerializer.Serialize(weatherForecast);
            File.WriteAllText(filename, jsonString);
            using (FileStream fs = File.Create(fileName))
            {
                await JsonSerializer.SerializeAsync(fs, weatherForecast);
            }
        }
    }
}
