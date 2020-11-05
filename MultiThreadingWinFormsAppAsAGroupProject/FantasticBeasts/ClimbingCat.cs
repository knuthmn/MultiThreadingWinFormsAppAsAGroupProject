/*
 * Meghan Knuth
 * mknuth1216@gmail.com
 * Assignment 07
 * IT 3045
 * Citations: https://stackoverflow.com/questions/2535251/c-finding-the-largest-prime-factor-of-a-number,
 * https://stackoverflow.com/questions/35494314/whats-the-best-way-to-find-the-largest-prime-factor-of-a-number/35494643,
 * https://www.geeksforgeeks.org/find-largest-prime-factor-number/
 * Description: This class simulates a fantastic beast called "ClimbingCat" and calculates the largest
 * prime factor of a number
 * Due Date: 11/ 5/ 20
 * Anything Else Pertinent: I'm not sure what fantastic beasts have to do with prime numbers lol.
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class ClimbingCat : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello! My name is:  "+ GetType());
         
         }
        public override void RunThread()
        {
            long num = Convert.ToInt64(request);
            long maxfa = maxPrimeFactor(num);
            response = Convert.ToString(maxfa);
        }

        static long maxPrimeFactor(long n)
        { 
            long maxPrime = -1;
 
            while (n % 2 == 0)
            {
                maxPrime = 2;
                n >>= 1;
            }
            for (int x = 3; x <= Math.Sqrt(n); x = x + 2)
            {
                while (n % x == 0)
                {
                    maxPrime = x;
                    n = n / x;
                }
            }
            if (n > 2)
            {
                maxPrime = n;
            }
                else
                {
                    throw new Exception("n is not the largest prime factor");
                }
            return maxPrime;
        }
    
    }

}

