using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LearnDSAlgorithms
{
    class DSAlgorithm
    {
        public void calculateIterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }

        public void calculateRecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                calculateRecursive(n - 1);
            }
        }

        public void calculateRecursiveTail(int n)
        {
            if (n > 0)
            {
                calculateRecursiveTail(n - 1);
                int k = n * n;
                Console.WriteLine();
            }
        }

        public int RecursiveSumOfN(int n)
        {
            if (n == 1) return 1;
            return RecursiveSumOfN(n - 1) + n;
        }

        public int linearSearch(int[] A, int key)
        {
            var index = 0;
            while (index < A.Count())
            {
                if (A[index] == key)
                    return index;
                index++;
            }
            return -1;
        }

        public int binarySearch(int[] A, int key)
        {
            int left = 0;
            int right = A.Count();
            Array.Sort(A);
            A.ToList().ForEach(x => Console.WriteLine(x));
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    right = mid - 1;
                else if (key > A[mid])
                    left = mid + 1;
            }
            return -1;
        }

        public int binaryRecursiveSearch(int[] A, int key, int left, int right)
        {
            Array.Sort(A);
            if (left > right)
                return -1;
            else
            {
                int mid = (left + right) / 2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    return binaryRecursiveSearch(A, key, left, mid - 1);
                else if (key > A[mid])
                    return binaryRecursiveSearch(A, key, mid + 1, right);
            }
            return -1;
        }

        public int intDivideBy2(int a)
        {
            Console.WriteLine("Divide by 2 ans: " + (a / 2));
            return a / 2;
        }

        public void display(int[] intArray)
        {
            foreach (var i in intArray)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        public void selectionSort(int[] intArray)
        {
            var n = intArray.Length;
            for (var i = 0; i < n; i++)
            {
                int position = i;
                for (int j = i + 1; j < n; j++)
                    if (intArray[j] < intArray[position])
                        position = j;
                int temp = intArray[i];
                intArray[i] = intArray[position];
                intArray[position] = temp;
            }
        }

        public void insertionSort(int[] intArray)
        {
            for (int i = 1; i < intArray.Length; i++)
            {
                int temp = intArray[i];
                int position = i;
                while (position > 0 && intArray[position - 1] > temp)
                {
                    intArray[position] = intArray[position - 1];
                    position--;
                }
                intArray[position] = temp;
            }
        }

        static void Main(string[] args)
        {
            DSAlgorithm r = new DSAlgorithm();

            int[] a = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            r.display(a);
            r.insertionSort(a);
            Console.WriteLine("Sorted Array: ");
            r.display(a);

            //int[] a = { 3, 5, 8, 9, 6, 2 };
            //Console.WriteLine("Original Array: ");
            //r.display(a);
            //r.selectionSort(a);
            //Console.WriteLine("Sorted Array: ");
            //r.display(a);

            //r.intDivideBy2(7);

            //int[] a = { 15, 21, 47, 84, 96 };
            //int found = r.binaryRecursiveSearch(a, 96, 0, 4);
            //Console.WriteLine("Result: " + found);

            //int[] a = { 84, 21, 47, 25, 36, 33, 55, 82, 91, 23, 11, 435, 96 };
            //int[] a = { 84, 21, 47, 96, 15 };
            //int found = r.binarySearch(a, 96);
            //Console.WriteLine("Result: " + found);

            //int[] a = { 84, 21, 47, 96, 15 };
            //int found = r.linearSearch(a, 96);
            //Console.WriteLine("Result: " + found);

            //r.calculateIterative(4);
            //r.calculateRecursive(4);
            //Console.WriteLine(r.RecursiveSumOfN(25));

            Console.ReadKey();
        }
    }
}