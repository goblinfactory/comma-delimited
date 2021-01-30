using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Goblinfactory.Delimited
{
    public class DelimBase : IEnumerable<string>
    {
        protected string[] _values;
        protected List<string> _enumerable = null;
        public IEnumerator<string> GetEnumerator()
        {
            return (_enumerable ?? (_enumerable = _values.ToList())).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (_enumerable ?? (_enumerable = _values.ToList())).GetEnumerator();
        }
    }
}
