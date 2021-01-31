using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Goblinfactory.Delimited
{
    public abstract class DelimBase : IEnumerable<string>
    {
        public virtual string[] Values { get; }

        List<string> _enumerable = null;
        public DelimBase(string[] values)
        {
            Values = values;
        }

        public abstract override string ToString();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (_enumerable ?? (_enumerable = Values.ToList())).GetEnumerator();
        }

        public IEnumerator<string> GetEnumerator()
        {
            return (_enumerable ?? (_enumerable = Values.ToList())).GetEnumerator();
        }


        public string this[int i]
        {
            get
            {
                return Values[i];
            }
        }
    }
}
