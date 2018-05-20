Your task is to write benchmarks for JSON serializers/deserializers.

Steps:
[x] 1. Try to run test and get familiar with benchmark framework.
[x] 2. Implement serialization benchmark for Newtonsoft.Json.
[x] 3. Prepare another test JSON data and use them in benchmarks.
[x] 4. Find out, how to do some performance optimalizations for Newtonsoft.Json and try it.
[x] 5. Implement serialization/deseralization benchmarks for another library and compare it with Newtonsoft.Json.
[x] 6. Choose one task:
[ ] 	a. Configure benchmarks to run on different platforms (.net framework, .net core).
[ ] 	b. Refactor benchmarks for stream deserialization (not whole string JSON will be in memory, but will be read as stream and deserialized in stream fashion).
[x] 	c. Pick another two JSON serializers/deserializers.
[ ] 	d. Write powershell and FAKE or CAKE build script, copy HTML reports from build folder to artifact folder.

Feel free to refactor code, add meaningful metrics or benchmarks. Be creative.
