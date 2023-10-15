﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
	/// <summary>
	/// Implementa operações aritméticas.
	/// </summary>
	internal static class Aritmetica
	{
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo=0,
            CelsiusFahrenheit,
            FahrenheitCelsisus
        }

		/// <summary>
		/// Operação de soma
		/// </summary>
		/// <returns>Retorna a soma de dois números</returns>
		public static int Somar(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Operação de subtrair
        /// </summary>
        /// <returns>Retorna a subtração  de dois números</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

        public static double ConverterTemperatura (ConversaoTemperatura conversao, double temperatura)  
        {
            if(conversao==ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao==ConversaoTemperatura.FahrenheitCelsisus) {
                return ((temperatura - 32) / 1.8);
            }
            return -1;
        } 
    }
}

