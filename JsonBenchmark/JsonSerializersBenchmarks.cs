using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
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
    public class JsonSerializersBenchmarks : JsonBenchmarkBase
    {
        private const string TestFilesFolder = "TestFiles";

        private readonly Rootobject _ser;
        private readonly Root _serialized;


        [Benchmark]
        public string NewtonsoftJson_Serialize()
        {
            return JsonConvert.SerializeObject(_serialized);
        }

        [Benchmark]
        public string NewtonsoftJsonPerson_Serialize()
        {
            return JsonConvert.SerializeObject(_ser);
        }

        [Benchmark]
        public string DataContractJsonSerializer_Serialize()
        {
            using (var ms = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Rootobject));
                ser.WriteObject(ms, _ser);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        [Benchmark]
        public string JavaScriptSerializer_Serialize()
        {
            return new JavaScriptSerializer().Serialize(_ser);
        }

        //Ctor
        public JsonSerializersBenchmarks()
        {
            _serialized = GetDeserializedObject<Root>("persondata.json");
            _ser = GetDeserializedObject<Rootobject>("chucknorris.json");

        }



        private static T GetDeserializedObject<T>(string jsonPath)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(
                Path.Combine(AppContext.BaseDirectory, TestFilesFolder, jsonPath)));
        }
    }
}
