using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {

        public static void insertionSort(int[] a)
        {
            int i, j, key;

            for(j=1; j<a.Length; j++) {
                key = a[j];
                i = j - 1;

                while(i >= 0 && a[i]>key)
                {
                    a[i + 1] = a[i--];
                }
                a[i+1]= key;
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 5,4,6,12,9,2,5,91,241,12,64,241,83,20,71,41};

            foreach(int i in array)
            {
                Console.Write(i+" ");               
            }

            insertionSort(array);

            Console.WriteLine("\n\nSorted array is: \n");

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
