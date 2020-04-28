using System;
using System.Collections.Generic;

namespace EvenFibonacciNumbers
{
    class Program
    {//By considering the terms in the Fibonacci sequence whose values do not exceed four million, this will find the sum of the even-valued terms.
        static void Main(string[] args)
        {
            int[] sequence = { 1, 2, 3 };//I used an array however you could just as easily use variables. THe Fibonacci Sequence takes the previous two terms and adds them together to make the next term.
            int nextValue = 0;
            int evenSum = 2;
            while (sequence[2] < 4000000 )
            {
                if (sequence[2] % 2 == 0)
                {//Checks if the value is even. If so, adds it to the sum.
                    evenSum += sequence[2];
                }
                nextValue = sequence[1] + sequence[2];
                sequence[0] = sequence[1];
                sequence[1] = sequence[2];
                sequence[2] = nextValue;
            }
            Console.WriteLine(evenSum);
        }
    }
}
