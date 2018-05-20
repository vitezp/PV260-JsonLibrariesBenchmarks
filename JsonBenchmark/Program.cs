using System;
using System.Collections.Generic;
using System.IO;
using BenchmarkDotNet.Running;
using JsonBenchmark.TestDTOs;
using Newtonsoft.Json;

namespace JsonBenchmark
{
    class Program
    {

        static void Main(string[] args)
        {
            BenchmarkRunner.Run<JsonDeserializersBenchmarks>();
            BenchmarkRunner.Run<JsonSerializersBenchmarks>();
        }
    }
}
