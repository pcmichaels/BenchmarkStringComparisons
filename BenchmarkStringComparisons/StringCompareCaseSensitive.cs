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
        [Benchmark]
        public bool StandardEquality(string string1, string string2)
        {
            return string1 == string2;
        }

        [Benchmark]
        public bool StandardEquals(string string1, string string2)
        {
            return string1.Equals(string2);
        }

        [Benchmark]
        public bool StandardCompare(string string1, string string2)
        {
            return (string.Compare(string1, string2) == 0);
        }

        [Benchmark]
        public bool StandardCompareOrdinal(string string1, string string2)
        {
            return (string.CompareOrdinal(string1, string2) == 0);
        }

        [Benchmark]
        public bool StandardCompareTo(string string1, string string2)
        {
            return (string1.CompareTo(string2) == 0);
        }

        [Benchmark]
        public bool StandardIndexOf(string string1, string string2)
        {
            return (string1.IndexOf(string2) != -1);
        }

    }
}
