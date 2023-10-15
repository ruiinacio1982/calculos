 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
            Console.WriteLine($"4 + 2 = {Aritmetica.Somar(4,2)}");
            Console.WriteLine($"4 - 2 = {Aritmetica.Subtrair(4, 2)}");

            double temp1 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double temp2 = Conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.FahrenheitCelsisus, 100);

            Console.WriteLine($"36ºC = {temp1}º Fahrneight");
            Console.WriteLine($"100ºF = {temp2}º Celsius");
            Console.ReadKey();
        }
    }
}
