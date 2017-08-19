using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Indexators
{
    public class Indexator
    {
        int[] arr;
        public int Length;
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value * value; }
        }
        public Indexator(int Size)
        {
            arr = new int[Size];
            Length = Size;
        }
    }


    class Program
    {
        static void Main()
        {
            Indexator i1 = new Indexator(10);
            for (int i = 0; i < i1.Length; i++)
            {
                i1[i] = i;
                Console.WriteLine(i1[i]);
            }
        }
    }

}
