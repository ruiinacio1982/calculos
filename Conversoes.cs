﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão.
    /// </summary>
    internal class Conversoes
    {

        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsisus
        }

        /// <summary>
        /// Tipo de conversão de distâncias
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }

        /// <summary>
        /// Conversão de temperaturas
        /// </summary>
        /// <param name="conversao">A conversão a efetuar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão da temperatura.</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsisus)
            {
                return ((temperatura - 32) / 1.8);
            }
            return -1;
        }

        /// <summary>
        /// Conversão de distancias
        /// </summary>
        /// <param name="conversao">A conversão a efetuar</param>
        /// <param name="distancia">A distância a converter</param>
        /// <returns>Retorna o resultado da conversão da distância.</returns>
        public static double ConverterDIstancias(ConversaoDistancia conversao, double distancia)
        {
            if (conversao == ConversaoDistancia.MetrosMilhas)
            {
                return (distancia * 0.0006213712);
            }
            else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return (distancia * 1609.344);
            } 
            return -1;
        }
    }
}
