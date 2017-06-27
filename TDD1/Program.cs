using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD1
{
    class Program
    {
        static void Main(string[] args)
        {
            //閉区間[6, 12] を生成
           ClosedRange range = new ClosedRange(6, 12);
            // [3,8] の下端点は 3
            int lowerEndpoint = range.getLowerEndpoint(); // => 6
                                                          // [6,12] の上端点は 8
            int upperEndpoint = range.getUpperEndpoint(); // => 12

            //1-1
            System.Diagnostics.Debug.Print(lowerEndpoint.ToString());
            System.Diagnostics.Debug.Print(upperEndpoint.ToString());
            //1-2
            System.Diagnostics.Debug.Print(range.toString());
        }
    }
}
