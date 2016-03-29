using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1___LINQ
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

//b)	Welk gevaar bestaat er bij het rechtstreeks uitvragen van alle elementen uit bovenstaande LINQ-expressie?
//      Omdat het een oneindige reeks is blijft hij in de loop hangen op zoek naar een waarde die mogelijk ook onder de 1000 zit.