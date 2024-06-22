using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesDemo
{
    public class LambdaDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------func Lambda---------------------");
            Func<int, int> square = no =>
            {
                int ans = no * no;
                return ans;
            };
            int sq_ans=square(100);
            Console.WriteLine(sq_ans);
            Console.WriteLine("-----------------Action Lambda---------------------");

            Action<int, int> multiplay = (i, j) =>
            {
                int ans = i * j;
                Console.WriteLine(ans);
            };
            multiplay(11, 23);
            Console.WriteLine("-----------------peridicate Lambda---------------------");
            Predicate<int> checkIfNumberIspositive = i =>
            {
                return i > 0;
            };
            bool ans=checkIfNumberIspositive(2);
            Console.WriteLine(ans);
        }
    }
}
