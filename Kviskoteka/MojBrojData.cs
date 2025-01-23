using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviskoteka
{
    public class MojBrojData
    {
        public List<int> baraniBroevi;
        public List<List<int>> ponudeniBroevi;
        public List<string> tocnaFormula;

        public MojBrojData()
        {
            baraniBroevi = new List<int> { 205, 862, 591, 725, 397, 298, 711, 761, 923, 222 };
            ponudeniBroevi = new List<List<int>> {
                new List<int>{2,5,8,6,15,50},
                new List<int>{5,7,3,8,20,25},
                new List<int>{1,9,7,5,20,25},
                new List<int>{4,2,7,1,15,25},
                new List<int>{6,8,1,9,20,100},
                new List<int>{5,7,5,9,10,75},
                new List<int>{5,3,3,2,10,50},
                new List<int>{9,6,3,3,10,25},
                new List<int>{4,7,1,9,15,75},
                new List<int>{3,6,9,5,20,100}
            };
            tocnaFormula = new List<string>
            {
                "50 * (6-2) + 5 = 205",
                "(5 * 25 - 3) * 7 + 8 = 862",
                "25 * (20 + 5 - 1) - 9 = 591",
                "(4 * 7 + 1) * 25 = 725",
                "(6 + 8 - 1 + 20) * 9 + 100 = 397",
                "(9 - 5) * 75 - (7 - 5) = 298",
                "(50 * 5 - 3 - 10) * 3 = 711",
                "10 * 25 * 3 + 9 + 6 / 3 = 761",
                "(4 + 7) * (9 + 75) - 1 = 923",
                "(6 * 9 + 20) * 3 = 222"
            };
        }
    }
}
