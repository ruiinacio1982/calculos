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

        /// <summary>
        /// Operação de multiplicar
        /// </summary>
        /// <returns>Retorna a multiplicação de dois números</returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }

    }
}

