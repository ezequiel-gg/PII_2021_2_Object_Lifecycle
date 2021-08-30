//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            /// <summary>
            /// contador para la iteración de creacion de instancias de la clase train
            /// </summary>
            int count = 0;

            ///
            /// 
            /// en caso de superar la memoria disponible, c# destruye los objectos instanciados fuera de uso (caso de 10M)
            while (count < 100)
            {
                new Train(count.ToString());
                Console.WriteLine(Train.Count.ToString());
                count++;
            }

            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");

            ///en ningun caso deberia cumplirse la igualdad, dado a que los objetos pertenecen a instancias diferentess entre si

            if (t1 == t2)
            {
                Console.WriteLine("t1 igual t2");
            }
            else
            {
                Console.WriteLine("t1 distinto a t2");
            }
            if (t2 == t3)
            {
                Console.WriteLine("t2 igual t3");
            }
            else
            {
                Console.WriteLine("t2 distinto a t3");
            }
        }
    }
}