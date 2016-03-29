using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4___IEnumerable
{
    class Reeks : IEnumerable<int>
    {
        

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            int n = 1;

            while (true)
            {
                n *= 2;
                yield return n;
            }
        }
    }
}
