``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.492 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2437500 Hz, Resolution=410.2564 ns, Timer=TSC
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT


```
|                Method |              Mean |              Error |             StdDev |               Min |               Max |  Gen 0 | Allocated |
|---------------------- |------------------:|-------------------:|-------------------:|------------------:|------------------:|-------:|----------:|
| DeSerializeNewtonSoft | 915,666,878.05 ns | 17,947,057.7287 ns | 28,981,152.8905 ns | 857,685,319.23 ns | 982,230,703.85 ns |      - |       0 B |
|    DeSerializeNetJSON | 888,692,608.55 ns | 17,741,143.6273 ns | 29,641,465.5298 ns | 854,334,978.21 ns | 950,767,183.33 ns |      - |       0 B |
|   SerializeNewtonSoft |          70.01 ns |          1.1071 ns |          0.9814 ns |          68.67 ns |          72.38 ns | 0.0254 |      40 B |
|      SerializeNetJSON |          68.29 ns |          0.8290 ns |          0.7349 ns |          66.54 ns |          69.38 ns | 0.0254 |      40 B |
