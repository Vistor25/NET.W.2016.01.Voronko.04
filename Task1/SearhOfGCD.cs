using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SearhOfGCD
    {
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
        public static long SearchGCDByClassicalEuclideanAlgorythm(params long[] numbersLongs)
        {
            DateTime start = DateTime.Now;

            if (numbersLongs.Length < 2) return numbersLongs[0];
            long result = SearchGCDByClassicalEuclideanAlgorythm(numbersLongs[0], numbersLongs[1]); 
            for (int i = 1; i < numbersLongs.Length - 1; i++)
            {
                 result = SearchGCDByClassicalEuclideanAlgorythm(result, numbersLongs[i + 1]);

            }
            TimeSpan time = DateTime.Now - start;
            return result;
        }

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
        public static long SearchGCDByBinaryAlgorythm(params long[] numLongs)
        {
            DateTime start = DateTime.Now;
            if (numLongs.Length < 2) return numLongs[0];
            long result = SearchGCDByBinaryAlgorythm(numLongs[0], numLongs[1]);
            for (int i = 1; i < numLongs.Length - 1; i++)
            {
                result = SearchGCDByBinaryAlgorythm(result, numLongs[i + 1]);

            }
            TimeSpan time = DateTime.Now - start;

            return result;
        }
    }
}
