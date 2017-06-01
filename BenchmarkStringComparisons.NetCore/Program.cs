﻿using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkStringComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StringCompareCaseSensitive>();
            BenchmarkRunner.Run<StringCompareCaseInsensitive>();

            Console.ReadLine();
        }


    }
}
