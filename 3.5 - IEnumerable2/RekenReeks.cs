using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5___IEnumerable2
{
    class RekenReeks : IEnumerable<int>
    {
        int n;
        Func<int, int> f;
        public RekenReeks(int i, Func<int, int> fun){
            n = i;
            f = fun;
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            while (true)
            {
                yield return n;
                n = f(n);
            }
        }
    }
}
