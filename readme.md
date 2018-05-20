Your task is to write benchmarks for JSON serializers/deserializers.

Steps:<br />
[x] 1. Try to run test and get familiar with benchmark framework.	<br />
[x] 2. Implement serialization benchmark for Newtonsoft.Json.<br />
[x] 3. Prepare another test JSON data and use them in benchmarks.<br />
[x] 4. Find out, how to do some performance optimalizations for Newtonsoft.Json and try it.<br />
[x] 5. Implement serialization/deseralization benchmarks for another library and compare it with Newtonsoft.Json.<br />
[x] 6. Choose one task:<br />
[ ] 	a. Configure benchmarks to run on different platforms (.net framework, .net core).<br />
[ ] 	b. Refactor benchmarks for stream deserialization (not whole string JSON will be in memory, but will be read as stream and deserialized in stream fashion).<br />
[x] 	c. Pick another two JSON serializers/deserializers.<br />
[ ] 	d. Write powershell and FAKE or CAKE build script, copy HTML reports from build folder to artifact folder.<br />

Feel free to refactor code, add meaningful metrics or benchmarks. Be creative.<br />

Results:<br />
                                  Method |     Mean |     Error |    StdDev |   Median | Scaled | Rank |<br />
---------------------------------------- |---------:|----------:|----------:|---------:|-------:|-----:|<br />
        NewtonsoftJsonPerson_Deserialize | 2.737 ms | 0.0539 ms | 0.0773 ms | 2.718 ms |   1.00 |    1 |<br />
                                         |          |           |           |          |        |      |<br />
              NewtonsoftJson_Deserialize | 1.837 ms | 0.0420 ms | 0.1224 ms | 1.796 ms |   1.00 |    1 |<br />
                                         |          |           |           |          |        |      |<br />
      NewtonsoftJson_Streams_Deserialize | 3.494 ms | 0.0690 ms | 0.1879 ms | 3.453 ms |   1.00 |    1 |<br />
                                         |          |           |           |          |        |      |<br />
 JsonSerializer_DataContract_Deserialize | 6.835 ms | 0.1345 ms | 0.2748 ms | 6.790 ms |   1.00 |    1 |<br />

                           
    						   Method |       Mean |    Error |    StdDev | Scaled | Rank |<br />
------------------------------------- |-----------:|---------:|----------:|-------:|-----:|<br />
             NewtonsoftJson_Serialize |   648.2 ns | 13.04 ns |  35.49 ns |   1.00 |    1 |<br />
                                      |            |          |           |        |      |<br />
       NewtonsoftJsonPerson_Serialize |   519.1 ns | 10.72 ns |  31.09 ns |   1.00 |    1 |<br />
                                      |            |          |           |        |      |<br />
 DataContractJsonSerializer_Serialize | 1,074.5 ns | 21.49 ns |  60.96 ns |   1.00 |    1 |<br />
                                      |            |          |           |        |      |<br />
       JavaScriptSerializer_Serialize | 2,426.2 ns | 48.44 ns | 111.29 ns |   1.00 |    1 |<br />
	   
	   