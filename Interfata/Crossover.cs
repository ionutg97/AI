/**************************************************************************
 *                                                                        *
 *  Copyright:   (c) 2016, Florin Leon                                    *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ia.htm              *
 *  Description: Evolutionary Algorithms                                  *
 *               (Artificial Intelligence lab 9)                          *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;

namespace EvolutionaryAlgorithm
{
    /// <summary>
    /// Clasa care reprezinta operatia de incrucisare
    /// </summary>
    public class Crossover
    {
        private static Random _rand = new Random();

        public static Chromosome Arithmetic(Chromosome mother, Chromosome father, double rate)
        {
            throw new Exception("Aceasta metoda trebuie implementata");
        }
    }
}