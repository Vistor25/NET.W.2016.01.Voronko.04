using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SearhOfGCD
    {

        private static long Search(long a, long b, Func<long, long, long> algorythmFunc)=> algorythmFunc(a, b);

        private static long Search(long a, long b, out long ticks, Func<long, long, long> algorythmFunc)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            long result = Search(a, b, algorythmFunc);
            timer.Stop();
            ticks = timer.ElapsedTicks;
            return result;
        }

        private static long Search(Func<long, long, long> algorythmFunc, params long[] parameters)
        {
            long result = 0;
            foreach (var VARIABLE in parameters)
            {
                result = Search(result, VARIABLE, algorythmFunc);
            }
            return result;
        }

        private static long Search(out long ticks, Func<long, long, long> algorythmFunc, params long[] parameters)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            long result = Search(algorythmFunc, parameters);
            timer.Stop();
            ticks = timer.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Searches the GCD of 2 numbers by standart Euclidean algorythm 
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>the greatest commin divisor</returns>
        public static long EuclideanSearch(long a, long b) => Search(a, b, SearchGCDByClassicalEuclideanAlgorythm);
        /// <summary>
        /// Searches the GCD of 2 numbers by standart Euclidean algorythm with calculating the time of execution the algorythm
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <param name="ticks">number of elapsed ticks</param>
        /// <returns>the greatest commin divisor</returns>
        public static long EuclideanSearch(long a, long b, out long ticks) => Search(a, b, out ticks, SearchGCDByClassicalEuclideanAlgorythm);
        /// <summary>
        /// Searches the GCD of N-numbers by standart Euclidean algorythm
        /// </summary>
        /// <param name="parameters">the array of numbers</param>
        /// <returns>the greatest commin divisor</returns>
        public static long EuclideanSearch(params long[] parameters) => Search(SearchGCDByClassicalEuclideanAlgorythm, parameters);
        /// <summary>
        /// Searches the GCD of N-numbers by standart Euclidean algorythm with calculating the time of execution the algorythm
        /// </summary>
        /// <param name="ticks">number of elapsed ticks</param>
        /// <param name="parameters">the array of numbers</param>
        /// <returns>the greatest commin divisor</returns>
        public static long EuclideanSearch(out long ticks, params long[] parameters) => Search(out ticks, SearchGCDByClassicalEuclideanAlgorythm, parameters);

        /// <summary>
        /// Searches the GCD of 2 numbers by binary Euclidean algorythm 
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>the greatest commin divisor</returns>
        public static long BinaryEuclideanSearch(long a, long b) => Search(a, b, SearchGCDByBinaryAlgorythm);
        /// <summary>
        /// Searches the GCD of 2 numbers by binary Euclidean algorythm with calculating the time of execution the algorythm
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <param name="ticks">number of elapsed ticks</param>
        /// <returns>the greatest commin divisor</returns>
        public static long BinaryEuclideanSearch(long a, long b, out long ticks) => Search(a, b, out ticks, SearchGCDByBinaryAlgorythm);
        /// <summary>
        /// Searches the GCD of N-numbers by binary Euclidean algorythm
        /// </summary>
        /// <param name="parameters">the array of numbers</param>
        /// <returns>the greatest commin divisor</returns>
        public static long BinaryEuclideanSearch(params long[] parameters) => Search(SearchGCDByBinaryAlgorythm, parameters);
        /// <summary>
        /// Searches the GCD of N-numbers by binary Euclidean algorythm with calculating the time of execution the algorythm
        /// </summary>
        /// <param name="ticks">number of elapsed ticks</param>
        /// <param name="parameters">the array of numbers</param>
        /// <returns>the greatest commin divisor</returns>
        public static long BinaryEuclideanSearch(out long ticks, params long[] parameters) => Search(out ticks, SearchGCDByBinaryAlgorythm, parameters);

        private static long SearchGCDByClassicalEuclideanAlgorythm(long a, long b)
        {
            
            while (b!=0)
            {
                b = a%(a = b);
            }
           
            return Math.Abs(a);
            
        }
        /// <summary>
        /// Searches GCD of n nubers by standart euclidean algorythm. 
        /// </summary>
        /// <param name="numbersLongs">Numbers</param>
        /// <returns>Returns the GCD of n numbers</returns>
      

        private static long SearchGCDByBinaryAlgorythm(long a, long b)
        {
            

            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if ((a == 1) || (b == 1)) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * SearchGCDByBinaryAlgorythm(a>>1, b>>1);
            if ((a % 2 == 0) && (b % 2 != 0)) return SearchGCDByBinaryAlgorythm(a>>1, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return SearchGCDByBinaryAlgorythm(a, b>>1);
            

            return SearchGCDByBinaryAlgorythm(b, (long)Math.Abs(a - b));
        }
        /// <summary>
        /// Searches GCD of n nubers by binary euclidean algorythm. 
        /// </summary>
        /// <param name="numbersLongs">Numbers</param>
        /// <returns>Returns the GCD of n numbers</returns>
       
    }
}
