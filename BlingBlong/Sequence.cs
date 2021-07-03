using System;
using System.Linq;

namespace Calculations
{
    class Sum
    {
        int[] vars = {0, 1, 1};
        int num;
        public Sum(int num)
        {
            this.num = num;
        }
        public void Calculate(){
            Console.WriteLine(vars[0]);
            Console.WriteLine(vars[1]);
            Console.WriteLine(vars[2]);
            int[] results = new int[num+3];
            results[0] = vars[1] + vars[2];
            results[1] = vars[2] + results[0];
            for(int i = 0; i <= num; i++){
                results[i+2] = results[i] + results[i+1];
                Console.WriteLine(results[i]);
            }
        }

        //testing
        public void getValue(){
            Console.WriteLine("Value " + this.num);
        }
    }
}