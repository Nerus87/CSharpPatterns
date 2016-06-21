using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace Patterns
{
    public class Iterator
    {
        internal Iterator()
        {
            IEnumerable<string> container = new Container();

            IEnumerator enumerator = container.GetEnumerator();

            while (enumerator.MoveNext())
                WriteLine(enumerator.Current);
        }

        internal class Container : IEnumerable<string>
        {
            public IEnumerator<string> GetEnumerator()
            {
                yield return "With an iterator, ";
                yield return "more than one ";
                yield return "value can be returned.";
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}
