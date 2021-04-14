using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleVsFirst
{
    class Program
    {
        static List<int> Numbers = new List<int> { 12, 42, 1, 10, 12 };

        static void Main(string[] args)
        {
            First();
            FirstOrDefault();
            Single();
            SingleOrDefault();
        }

        private static void First()
        {            
            var firstValueWhenMultipleMatch = Numbers.First(x => x == 12); //return first occured value in list then stop searching list
            Console.WriteLine(firstValueWhenMultipleMatch);

            try
            {
                var firstValueWhenDoesntExists = Numbers.First(x => x == 0); //throw exception - Sequence contains no matching element
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Throw exception: {exception.Message}");
            }            
        }

        private static void FirstOrDefault()
        {
            var firstValueWhenMultipleMatch = Numbers.FirstOrDefault(x => x == 12); //return first occured value in list then stop searching list
            Console.WriteLine(firstValueWhenMultipleMatch);

            var firstValueWhenDoesntExists = Numbers.FirstOrDefault(x => x == 0); //return default value of int = 0
            Console.WriteLine(firstValueWhenDoesntExists);
        }

        private static void Single()
        {
            try
            {
                var firstValueWhenMultipleMatch = Numbers.Single(x => x == 12); //throw exception - Sequence contains more than one matching element
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Throw exception: {exception.Message}");
            }


            try
            {
                var firstValueWhenDoesntExists = Numbers.Single(x => x == 0); //throw exception - Sequence contains no matching element
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Throw exception: {exception.Message}");
            }                       
        }

        private static void SingleOrDefault()
        {
            try
            {
                var firstValueWhenMultipleMatch = Numbers.SingleOrDefault(x => x == 12); //throw exception - Sequence contains more than one matching element
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Throw exception: {exception.Message}");
            }

            var firstValueWhenDoesntExists = Numbers.SingleOrDefault(x => x == 0); //return default value of int = 0
            Console.WriteLine(firstValueWhenDoesntExists);
        }
    }
}
