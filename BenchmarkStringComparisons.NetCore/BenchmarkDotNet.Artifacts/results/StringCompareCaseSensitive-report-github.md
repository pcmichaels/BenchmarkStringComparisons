``` ini

BenchmarkDotNet=v0.10.6, OS=Windows 10 Redstone 1 (10.0.14393)
Processor=Intel Core i7-3630QM CPU 2.40GHz (Ivy Bridge), ProcessorCount=8
Frequency=2338446 Hz, Resolution=427.6344 ns, Timer=TSC
dotnet cli version=1.0.4
  [Host]     : .NET Core 4.6.25211.01, 64bit RyuJITDEBUG [AttachedDebugger]
  DefaultJob : .NET Core 4.6.25211.01, 64bit RyuJIT


```
 |                 Method |         _string1 |         _string2 |       Mean |     Error |    StdDev |
 |----------------------- |----------------- |----------------- |-----------:|----------:|----------:|
 |       **StandardEquality** | **I am an aardvark** | **I am an aardvark** |   **1.624 ns** | **0.0193 ns** | **0.0171 ns** |
 |         StandardEquals | I am an aardvark | I am an aardvark |   1.478 ns | 0.0722 ns | 0.1355 ns |
 |  StandardEqualsCulture | I am an aardvark | I am an aardvark |   2.109 ns | 0.0853 ns | 0.0913 ns |
 |  StandardEqualsOrdinal | I am an aardvark | I am an aardvark |   2.139 ns | 0.0419 ns | 0.0392 ns |
 |        StandardCompare | I am an aardvark | I am an aardvark |   2.613 ns | 0.0623 ns | 0.0583 ns |
 | StandardCompareOrdinal | I am an aardvark | I am an aardvark |   2.249 ns | 0.0147 ns | 0.0122 ns |
 |      StandardCompareTo | I am an aardvark | I am an aardvark |   2.649 ns | 0.0676 ns | 0.0633 ns |
 |        StandardIndexOf | I am an aardvark | I am an aardvark | 164.118 ns | 3.1310 ns | 3.3502 ns |
 |       **StandardEquality** | **I am an aardvark** |            **test1** |   **2.627 ns** | **0.0153 ns** | **0.0128 ns** |
 |         StandardEquals | I am an aardvark |            test1 |   2.881 ns | 0.0313 ns | 0.0293 ns |
 |  StandardEqualsCulture | I am an aardvark |            test1 | 102.966 ns | 0.5406 ns | 0.4793 ns |
 |  StandardEqualsOrdinal | I am an aardvark |            test1 |   4.773 ns | 0.0921 ns | 0.0862 ns |
 |        StandardCompare | I am an aardvark |            test1 | 101.863 ns | 2.0647 ns | 2.6112 ns |
 | StandardCompareOrdinal | I am an aardvark |            test1 |   4.133 ns | 0.0504 ns | 0.0421 ns |
 |      StandardCompareTo | I am an aardvark |            test1 | 101.398 ns | 1.9848 ns | 1.7595 ns |
 |        StandardIndexOf | I am an aardvark |            test1 | 183.084 ns | 3.6755 ns | 7.3405 ns |
 |       **StandardEquality** | **I am an aardvark** |            **test2** |   **2.701 ns** | **0.0633 ns** | **0.0592 ns** |
 |         StandardEquals | I am an aardvark |            test2 |   2.899 ns | 0.0464 ns | 0.0434 ns |
 |  StandardEqualsCulture | I am an aardvark |            test2 | 102.639 ns | 1.4831 ns | 1.3873 ns |
 |  StandardEqualsOrdinal | I am an aardvark |            test2 |   4.812 ns | 0.0764 ns | 0.0715 ns |
 |        StandardCompare | I am an aardvark |            test2 | 100.951 ns | 1.9753 ns | 2.1136 ns |
 | StandardCompareOrdinal | I am an aardvark |            test2 |   4.133 ns | 0.0339 ns | 0.0317 ns |
 |      StandardCompareTo | I am an aardvark |            test2 | 102.991 ns | 2.0866 ns | 3.1231 ns |
 |        StandardIndexOf | I am an aardvark |            test2 | 179.742 ns | 3.2210 ns | 3.0129 ns |
 |       **StandardEquality** |            **test1** | **I am an aardvark** |   **2.641 ns** | **0.0578 ns** | **0.0513 ns** |
 |         StandardEquals |            test1 | I am an aardvark |   2.878 ns | 0.0451 ns | 0.0400 ns |
 |  StandardEqualsCulture |            test1 | I am an aardvark | 103.319 ns | 1.0023 ns | 0.8885 ns |
 |  StandardEqualsOrdinal |            test1 | I am an aardvark |   4.788 ns | 0.0951 ns | 0.0890 ns |
 |        StandardCompare |            test1 | I am an aardvark | 100.248 ns | 0.7567 ns | 0.6708 ns |
 | StandardCompareOrdinal |            test1 | I am an aardvark |   4.151 ns | 0.0368 ns | 0.0344 ns |
 |      StandardCompareTo |            test1 | I am an aardvark | 100.137 ns | 0.9312 ns | 0.8255 ns |
 |        StandardIndexOf |            test1 | I am an aardvark | 133.716 ns | 1.0923 ns | 0.9683 ns |
 |       **StandardEquality** |            **test1** |            **test1** |   **1.606 ns** | **0.0307 ns** | **0.0287 ns** |
 |         StandardEquals |            test1 |            test1 |   1.331 ns | 0.0226 ns | 0.0200 ns |
 |  StandardEqualsCulture |            test1 |            test1 |   2.045 ns | 0.0070 ns | 0.0050 ns |
 |  StandardEqualsOrdinal |            test1 |            test1 |   2.051 ns | 0.0305 ns | 0.0270 ns |
 |        StandardCompare |            test1 |            test1 |   2.584 ns | 0.0821 ns | 0.0727 ns |
 | StandardCompareOrdinal |            test1 |            test1 |   2.241 ns | 0.0389 ns | 0.0364 ns |
 |      StandardCompareTo |            test1 |            test1 |   2.558 ns | 0.0396 ns | 0.0351 ns |
 |        StandardIndexOf |            test1 |            test1 | 137.983 ns | 2.7378 ns | 3.6549 ns |
 |       **StandardEquality** |            **test1** |            **test2** |   **8.164 ns** | **0.2074 ns** | **0.2697 ns** |
 |         StandardEquals |            test1 |            test2 |   8.280 ns | 0.1653 ns | 0.1546 ns |
 |  StandardEqualsCulture |            test1 |            test2 | 117.481 ns | 2.3654 ns | 3.9520 ns |
 |  StandardEqualsOrdinal |            test1 |            test2 |   9.545 ns | 0.2166 ns | 0.2026 ns |
 |        StandardCompare |            test1 |            test2 | 110.076 ns | 2.2376 ns | 2.1976 ns |
 | StandardCompareOrdinal |            test1 |            test2 |   9.219 ns | 0.1345 ns | 0.1193 ns |
 |      StandardCompareTo |            test1 |            test2 | 113.554 ns | 2.3912 ns | 6.9753 ns |
 |        StandardIndexOf |            test1 |            test2 | 148.642 ns | 1.1302 ns | 1.0571 ns |
 |       **StandardEquality** |            **test2** | **I am an aardvark** |   **2.619 ns** | **0.0144 ns** | **0.0135 ns** |
 |         StandardEquals |            test2 | I am an aardvark |   2.842 ns | 0.0296 ns | 0.0262 ns |
 |  StandardEqualsCulture |            test2 | I am an aardvark | 102.853 ns | 2.3870 ns | 2.1160 ns |
 |  StandardEqualsOrdinal |            test2 | I am an aardvark |   4.954 ns | 0.1433 ns | 0.1533 ns |
 |        StandardCompare |            test2 | I am an aardvark | 106.063 ns | 1.7533 ns | 1.6400 ns |
 | StandardCompareOrdinal |            test2 | I am an aardvark |   4.111 ns | 0.0215 ns | 0.0201 ns |
 |      StandardCompareTo |            test2 | I am an aardvark |  99.451 ns | 0.9816 ns | 0.8702 ns |
 |        StandardIndexOf |            test2 | I am an aardvark | 133.658 ns | 1.3809 ns | 1.2242 ns |
 |       **StandardEquality** |            **test2** |            **test1** |   **7.593 ns** | **0.0745 ns** | **0.0697 ns** |
 |         StandardEquals |            test2 |            test1 |   7.799 ns | 0.0236 ns | 0.0209 ns |
 |  StandardEqualsCulture |            test2 |            test1 | 109.563 ns | 1.1570 ns | 1.0822 ns |
 |  StandardEqualsOrdinal |            test2 |            test1 |   9.041 ns | 0.0351 ns | 0.0293 ns |
 |        StandardCompare |            test2 |            test1 | 104.483 ns | 1.0001 ns | 0.9355 ns |
 | StandardCompareOrdinal |            test2 |            test1 |   8.773 ns | 0.0183 ns | 0.0162 ns |
 |      StandardCompareTo |            test2 |            test1 | 106.442 ns | 0.3640 ns | 0.3039 ns |
 |        StandardIndexOf |            test2 |            test1 | 146.882 ns | 1.4421 ns | 1.2784 ns |
 |       **StandardEquality** |            **test2** |            **test2** |   **1.597 ns** | **0.0163 ns** | **0.0145 ns** |
 |         StandardEquals |            test2 |            test2 |   1.300 ns | 0.0116 ns | 0.0091 ns |
 |  StandardEqualsCulture |            test2 |            test2 |   2.044 ns | 0.0240 ns | 0.0213 ns |
 |  StandardEqualsOrdinal |            test2 |            test2 |   2.071 ns | 0.0751 ns | 0.0703 ns |
 |        StandardCompare |            test2 |            test2 |   2.522 ns | 0.0267 ns | 0.0223 ns |
 | StandardCompareOrdinal |            test2 |            test2 |   2.214 ns | 0.0107 ns | 0.0089 ns |
 |      StandardCompareTo |            test2 |            test2 |   2.592 ns | 0.0287 ns | 0.0224 ns |
 |        StandardIndexOf |            test2 |            test2 | 130.638 ns | 1.0350 ns | 0.9175 ns |
