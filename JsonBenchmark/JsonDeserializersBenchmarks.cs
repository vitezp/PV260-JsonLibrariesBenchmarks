using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using JsonBenchmark.TestDTOs;
using Newtonsoft.Json;

namespace JsonBenchmark
{
    [ClrJob(isBaseline: true)]
    [RPlotExporter, RankColumn]
    [HtmlExporter]
    public class JsonDeserializersBenchmarks : JsonBenchmarkBase
    {

        [Benchmark]
        public Rootobject NewtonsoftJsonPerson_Deserialize()
        {
            return JsonConvert.DeserializeObject<Rootobject>(JsonPersonString);
        }

        [Benchmark]
        public Root NewtonsoftJson_Deserialize()
        {
            return JsonConvert.DeserializeObject<Root>(JsonChuckNorrisString);
        }

        ///////////////////////////
        
        [Benchmark]
        public Root NewtonsoftJson_Streams_Deserialize()
        {

            using (Stream s = File.OpenRead("TestFiles/persondata.json"))
            using (StreamReader sr = new StreamReader(s))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return new JsonSerializer().Deserialize<Root>(reader);
            }
        }

        [Benchmark]
        public Root JsonSerializer_DataContract_Deserialize()
        {
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(JsonPersonString)))
            {
                return new DataContractJsonSerializer(typeof(Root)).ReadObject(stream) as Root;
            }
        }

        


    }
}
