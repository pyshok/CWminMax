using System;
using System.Collections.Immutable;

namespace CWminMax
{
    class Program
    {
        public static int[] minMax(int[] lst){
            int[] arr = new int[2];
            Array.Sort(lst);
            int min = lst[0];
            //Console.WriteLine(min);
            Array.Reverse(lst);
            int max = lst[0];
            //Console.WriteLine(max);
            arr[0] = min;
            arr[1] = max;
           
            return arr;
        }
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            int[] thearr = {4,7,1,9,5};
           minMax(thearr);
        }
    }
}
