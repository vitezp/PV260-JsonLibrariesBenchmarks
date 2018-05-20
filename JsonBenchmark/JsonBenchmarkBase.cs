using System;
using System.IO;

namespace JsonBenchmark
{
    public abstract class JsonBenchmarkBase
    {
        private const string TestFilesFolder = "TestFiles";
        protected string JsonChuckNorrisString;
        protected string JsonPersonString;

        protected JsonBenchmarkBase()
        {
            JsonChuckNorrisString = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, TestFilesFolder, "chucknorris.json"));
            JsonPersonString = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, TestFilesFolder, "persondata.json"));

        }
    }
}
