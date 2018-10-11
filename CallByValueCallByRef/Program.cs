using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValueCallByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int outSiderVal = 10;
            abc obj = new abc();

            obj.callMe(outSiderVal);// outSiderVal = 10
            Console.WriteLine("callMe:-  " + outSiderVal);

            obj.callByRef(ref outSiderVal);// outSiderVal = 20
            Console.WriteLine("callByRef:-  " + outSiderVal);

            obj.callByVal( out outSiderVal);// outSiderVal = 15
            Console.WriteLine("callByVal:-  "+outSiderVal);
            Console.ReadKey();
        }

    }

    class abc
    {
        public void callMe( int insiderval)
        {
            insiderval = insiderval + 10;
        }

        public void callByRef(ref int insiderval)
        {
            insiderval = insiderval + 10;
        }

        public void callByVal(out int insiderval)
        {
            insiderval = 5;
            insiderval = insiderval + 10;
        }
    }
}
