using System;

namespace IndexerAndPropertyDemo
{
    class IntArray
    {
        private int[] array;
        private int length;

        // Property for accessing array length (read-only)
        public int Length
        {
            get { return length; }
        }

        // Class constructor
        public IntArray(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Array size must be greater than 0");

            array = new int[size];
            length = size;
        }

        // Indexer with array bounds checking
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= length)
                    throw new IndexOutOfRangeException("Index is out of array bounds");
                return array[index];
            }
            set
            {
                if (index < 0 || index >= length)
                    throw new IndexOutOfRangeException("Index is out of array bounds");
                array[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an array of size 5
                IntArray myArray = new IntArray(5);

                // Fill the array using the indexer
                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i] = i * 10;
                }

                // Display array length through the property
                Console.WriteLine($"Array length: {myArray.Length}");

                // Display array elements
                Console.WriteLine("Array elements:");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine($"myArray[{i}] = {myArray[i]}");
                }

                // Attempt to access out-of-bounds element (will throw exception)
                Console.WriteLine("Attempt to access non-existent element:");
                Console.WriteLine(myArray[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}