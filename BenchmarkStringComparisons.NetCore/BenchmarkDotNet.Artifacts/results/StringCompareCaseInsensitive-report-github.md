``` ini

BenchmarkDotNet=v0.10.6, OS=Windows 10 Redstone 1 (10.0.14393)
Processor=Intel Core i7-3630QM CPU 2.40GHz (Ivy Bridge), ProcessorCount=8
Frequency=2338446 Hz, Resolution=427.6344 ns, Timer=TSC
dotnet cli version=1.0.4
  [Host]     : .NET Core 4.6.25211.01, 64bit RyuJITDEBUG [AttachedDebugger]
  DefaultJob : .NET Core 4.6.25211.01, 64bit RyuJIT


```
 |                                 Method |         _string1 |         _string2 |       Mean |     Error |    StdDev |
 |--------------------------------------- |----------------- |----------------- |-----------:|----------:|----------:|
 |                  **StandardEqualityUpper** | **I am an aardvark** | **I Am an AARDVARK** | **319.606 ns** | **3.7076 ns** | **2.8946 ns** |
 |                  StandardEqualityLower | I am an aardvark | I Am an AARDVARK | 302.285 ns | 2.5274 ns | 2.1105 ns |
 |        StandardEqualsOrdinalIgnoreCase | I am an aardvark | I Am an AARDVARK |  45.049 ns | 0.1980 ns | 0.1654 ns |
 | StandardEqualsCurrentCultureIgnoreCase | I am an aardvark | I Am an AARDVARK | 161.694 ns | 1.8390 ns | 1.7202 ns |
 |              StandardCompareIgnoreCase | I am an aardvark | I Am an AARDVARK | 157.725 ns | 2.0446 ns | 1.9126 ns |
 |       StandardIndexOfOrdinalIgnoreCase | I am an aardvark | I Am an AARDVARK | 146.288 ns | 0.9208 ns | 0.8162 ns |
 |                  **StandardEqualityUpper** | **I am an aardvark** |            **Test2** | **271.607 ns** | **2.1348 ns** | **1.9969 ns** |
 |                  StandardEqualityLower | I am an aardvark |            Test2 | 280.052 ns | 2.0334 ns | 1.9020 ns |
 |        StandardEqualsOrdinalIgnoreCase | I am an aardvark |            Test2 |   4.631 ns | 0.0734 ns | 0.0686 ns |
 | StandardEqualsCurrentCultureIgnoreCase | I am an aardvark |            Test2 | 100.359 ns | 0.3625 ns | 0.3214 ns |
 |              StandardCompareIgnoreCase | I am an aardvark |            Test2 |  96.427 ns | 1.3061 ns | 1.2218 ns |
 |       StandardIndexOfOrdinalIgnoreCase | I am an aardvark |            Test2 | 176.646 ns | 0.5957 ns | 0.4651 ns |
 |                  **StandardEqualityUpper** | **I am an aardvark** |            **test1** | **293.157 ns** | **3.5753 ns** | **3.3443 ns** |
 |                  StandardEqualityLower | I am an aardvark |            test1 | 271.676 ns | 1.8168 ns | 1.6105 ns |
 |        StandardEqualsOrdinalIgnoreCase | I am an aardvark |            test1 |   4.636 ns | 0.0498 ns | 0.0441 ns |
 | StandardEqualsCurrentCultureIgnoreCase | I am an aardvark |            test1 |  99.267 ns | 2.0061 ns | 2.0601 ns |
 |              StandardCompareIgnoreCase | I am an aardvark |            test1 |  97.043 ns | 0.6652 ns | 0.5554 ns |
 |       StandardIndexOfOrdinalIgnoreCase | I am an aardvark |            test1 | 187.515 ns | 0.7206 ns | 0.6388 ns |
 |                  **StandardEqualityUpper** |            **test1** | **I Am an AARDVARK** | **286.400 ns** | **3.0705 ns** | **2.7219 ns** |
 |                  StandardEqualityLower |            test1 | I Am an AARDVARK | 273.860 ns | 4.7271 ns | 4.4217 ns |
 |        StandardEqualsOrdinalIgnoreCase |            test1 | I Am an AARDVARK |   4.647 ns | 0.0207 ns | 0.0162 ns |
 | StandardEqualsCurrentCultureIgnoreCase |            test1 | I Am an AARDVARK | 101.252 ns | 0.7667 ns | 0.6403 ns |
 |              StandardCompareIgnoreCase |            test1 | I Am an AARDVARK |  98.854 ns | 0.5244 ns | 0.4094 ns |
 |       StandardIndexOfOrdinalIgnoreCase |            test1 | I Am an AARDVARK | 124.869 ns | 0.7258 ns | 0.5248 ns |
 |                  **StandardEqualityUpper** |            **test1** |            **Test2** | **249.013 ns** | **1.0111 ns** | **0.8963 ns** |
 |                  StandardEqualityLower |            test1 |            Test2 | 250.603 ns | 4.8250 ns | 4.7388 ns |
 |        StandardEqualsOrdinalIgnoreCase |            test1 |            Test2 |  21.924 ns | 0.1902 ns | 0.1779 ns |
 | StandardEqualsCurrentCultureIgnoreCase |            test1 |            Test2 | 110.176 ns | 2.1517 ns | 2.1132 ns |
 |              StandardCompareIgnoreCase |            test1 |            Test2 | 110.052 ns | 0.3650 ns | 0.3048 ns |
 |       StandardIndexOfOrdinalIgnoreCase |            test1 |            Test2 | 140.122 ns | 2.5025 ns | 2.3408 ns |
 |                  **StandardEqualityUpper** |            **test1** |            **test1** | **250.130 ns** | **3.2454 ns** | **2.8769 ns** |
 |                  StandardEqualityLower |            test1 |            test1 | 246.583 ns | 1.4610 ns | 1.2200 ns |
 |        StandardEqualsOrdinalIgnoreCase |            test1 |            test1 |   2.040 ns | 0.0373 ns | 0.0349 ns |
 | StandardEqualsCurrentCultureIgnoreCase |            test1 |            test1 |   2.038 ns | 0.0261 ns | 0.0218 ns |
 |              StandardCompareIgnoreCase |            test1 |            test1 |   2.526 ns | 0.0130 ns | 0.0109 ns |
 |       StandardIndexOfOrdinalIgnoreCase |            test1 |            test1 | 119.565 ns | 1.6019 ns | 1.4985 ns |
 |                  **StandardEqualityUpper** |            **test2** | **I Am an AARDVARK** | **269.551 ns** | **1.9057 ns** | **1.6894 ns** |
 |                  StandardEqualityLower |            test2 | I Am an AARDVARK | 271.723 ns | 1.1885 ns | 1.0536 ns |
 |        StandardEqualsOrdinalIgnoreCase |            test2 | I Am an AARDVARK |   4.635 ns | 0.0496 ns | 0.0464 ns |
 | StandardEqualsCurrentCultureIgnoreCase |            test2 | I Am an AARDVARK |  99.094 ns | 2.0139 ns | 1.9780 ns |
 |              StandardCompareIgnoreCase |            test2 | I Am an AARDVARK |  98.126 ns | 0.1872 ns | 0.1659 ns |
 |       StandardIndexOfOrdinalIgnoreCase |            test2 | I Am an AARDVARK | 123.307 ns | 2.2801 ns | 2.1328 ns |
 |                  **StandardEqualityUpper** |            **test2** |            **Test2** | **257.007 ns** | **1.9925 ns** | **1.8638 ns** |
 |                  StandardEqualityLower |            test2 |            Test2 | 247.765 ns | 2.2530 ns | 1.9972 ns |
 |        StandardEqualsOrdinalIgnoreCase |            test2 |            Test2 |  22.488 ns | 0.2499 ns | 0.2337 ns |
 | StandardEqualsCurrentCultureIgnoreCase |            test2 |            Test2 | 111.778 ns | 0.7673 ns | 0.5991 ns |
 |              StandardCompareIgnoreCase |            test2 |            Test2 | 108.411 ns | 1.2181 ns | 1.0799 ns |
 |       StandardIndexOfOrdinalIgnoreCase |            test2 |            Test2 | 119.322 ns | 0.6958 ns | 0.6508 ns |
 |                  **StandardEqualityUpper** |            **test2** |            **test1** | **247.509 ns** | **3.5000 ns** | **3.2739 ns** |
 |                  StandardEqualityLower |            test2 |            test1 | 248.980 ns | 2.1990 ns | 1.9494 ns |
 |        StandardEqualsOrdinalIgnoreCase |            test2 |            test1 |  21.653 ns | 0.0745 ns | 0.0538 ns |
 | StandardEqualsCurrentCultureIgnoreCase |            test2 |            test1 | 107.922 ns | 0.5395 ns | 0.4782 ns |
 |              StandardCompareIgnoreCase |            test2 |            test1 | 103.616 ns | 1.6301 ns | 1.5248 ns |
 |       StandardIndexOfOrdinalIgnoreCase |            test2 |            test1 | 144.512 ns | 0.3192 ns | 0.2492 ns |
