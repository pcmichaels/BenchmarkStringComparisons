using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkStringComparisons
{
    public class StringCompareCaseInsensitive
    {        
        [Params("test1", "test2", "I am an aardvark")]
        public string _string1;

        [Params("test1", "Test2", "I Am an AARDVARK")]
        public string _string2;

        [Benchmark]        
        public bool StandardEqualityUpper()
        {
            return _string1.ToUpper() == _string2.ToUpper();
        }

        [Benchmark]
        public bool StandardEqualityLower()
        {
            return _string1.ToLower() == _string2.ToLower();
        }

        [Benchmark]
        public bool StandardEqualsOrdinalIgnoreCase()
        {
            return _string1.Equals(_string2, StringComparison.OrdinalIgnoreCase);
        }

        [Benchmark]
        public bool StandardEqualsCurrentCultureIgnoreCase()
        {
            return _string1.Equals(_string2, StringComparison.CurrentCultureIgnoreCase);
        }

        [Benchmark]
        public bool StandardCompareIgnoreCase()
        {
            return (string.Compare(_string1, _string2, true) == 0);
        }

        [Benchmark]
        public bool StandardIndexOfOrdinalIgnoreCase()
        {
            return (_string1.IndexOf(_string2, 0, StringComparison.OrdinalIgnoreCase) != -1);
        }

    }
}
