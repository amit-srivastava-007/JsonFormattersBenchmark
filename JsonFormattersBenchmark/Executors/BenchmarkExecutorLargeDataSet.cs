using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using JsonFormattersBenchmark.Candidate;
using JsonFormattersBenchmark.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonFormattersBenchmark
{
    [MinColumn, MaxColumn]
    [MarkdownExporter, AsciiDocExporter, HtmlExporter, CsvExporter, RPlotExporter]
    [MemoryDiagnoser]
    public class BenchmarkExecutorLargeDataSet
    {
        readonly IBenchmarkCandidate<SFCityLots> newtonSoftLargeDataSet;
        readonly IBenchmarkCandidate<SFCityLots> netJsonLargeDataSet;
        readonly string sourceFilePath = Path.Combine(Environment.CurrentDirectory, @"SampleData/citylots.json");

        public BenchmarkExecutorLargeDataSet()
        {
            newtonSoftLargeDataSet = new NetJson<SFCityLots>(sourceFilePath);
            netJsonLargeDataSet = new NetJson<SFCityLots>(sourceFilePath);
        }

        [Benchmark]
        public SFCityLots DeSerializeNewtonSoft() => newtonSoftLargeDataSet.DeSerialize();

        [Benchmark]
        public SFCityLots DeSerializeNetJSON() => netJsonLargeDataSet.DeSerialize();

        [Benchmark]
        public string SerializeNewtonSoft() => newtonSoftLargeDataSet.Serialize();

        [Benchmark]
        public string SerializeNetJSON() => netJsonLargeDataSet.Serialize();


    }
}
