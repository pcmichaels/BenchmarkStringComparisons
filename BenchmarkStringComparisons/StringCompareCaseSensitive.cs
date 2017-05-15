using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkStringComparisons
{
    public class StringCompareCaseSensitive
    {        
        [Params("test1", "test2", "I am an aardvark")]
        public string _string1;

        [Params("test1", "test2", "I am an aardvark")]
        public string _string2;

        [Benchmark]        
        public bool StandardEquality()
        {
            return _string1 == _string2;
        }

        [Benchmark]
        public bool StandardEquals()
        {
            return _string1.Equals(_string2);
        }

        [Benchmark]
        public bool StandardEqualsCulture()
        {
            return _string1.Equals(_string2, StringComparison.CurrentCulture);
        }

        [Benchmark]
        public bool StandardEqualsInvariantCulture()
        {
            return _string1.Equals(_string2, StringComparison.InvariantCulture);
        }

        [Benchmark]
        public bool StandardEqualsOrdinal()
        {
            return _string1.Equals(_string2, StringComparison.Ordinal);
        }

        [Benchmark]
        public bool StandardCompare()
        {
            return (string.Compare(_string1, _string2) == 0);
        }

        [Benchmark]
        public bool StandardCompareOrdinal()
        {
            return (string.CompareOrdinal(_string1, _string2) == 0);
        }

        [Benchmark]
        public bool StandardCompareTo()
        {
            return (_string1.CompareTo(_string2) == 0);
        }

        [Benchmark]
        public bool StandardIndexOf()
        {
            return (_string1.IndexOf(_string2) != -1);
        }

    }
}
