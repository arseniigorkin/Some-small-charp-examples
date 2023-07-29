// using System.Threading.Tasks.Dataflow;
// namespace Test_foreach_async;
//
//
// public class AsyncClass
// {
//
//     public static async Task DownloadUrl(string url)
//     {
//         Console.WriteLine("Сделано");
//     }
//         
//     public static Task AsyncParallelForEach<T>(
//         IEnumerable<T> source,
//         Func<T, Task> body,
//         int maxDegreeOfParallelism = DataflowBlockOptions.Unbounded,
//         TaskScheduler scheduler = null)
//     {
//         var options = new ExecutionDataflowBlockOptions
//         {
//             MaxDegreeOfParallelism = maxDegreeOfParallelism
//         };
//         if (scheduler != null)
//             options.TaskScheduler = scheduler;
//
//         var block = new ActionBlock<T>(body, options);
//
//         foreach (var item in source)
//             block.Post(item);
//
//         block.Complete();
//         return block.Completion;
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
//
// namespace AsyncTestNameSpace
// {
//
//     internal class TestMessage
//     {
//         public string Message { get; set; }
//     }
//
//     internal class ResponseClass
//     {
//         public string RespMessage { get; set; }
//     }
//
//     internal class ReturnObjClass
//     {
//         public string ReturnObjString { get; set; }
//     }
//
//     class Program
//     {
//         static async Task Main(string[] args)
//         {
//             
//             
//             var placesList = new List<Task<ResponseClass>>();
//             // var placesList = new List<Task>();
//             for (int i = 1; i <= 5; i++)
//             {
//                 TestMessage TM = new TestMessage() { Message = $"Значение №1 в [{i}]" };
//                 Console.WriteLine(TM.Message);
//                 placesList.Add(TestAsyncSUB(i, TM));
//                 // var r = TestAsyncSUB(i, TM);
//                 
//             }
//
//             int v = 2;
//             
//             while (placesList.Count > 0)
//             {
//                  // Task finishedTask = await Task.WhenAny(placesList);
//                  Task<ResponseClass> finishedTask = await Task.WhenAny(placesList);
//                  await finishedTask;
//                  if (finishedTask.Result.RespMessage != null)
//                  {
//                      Console.WriteLine($"После выполнения получено значение: {finishedTask.Result.RespMessage}");
//                  }
//                  placesList.Remove(finishedTask);
//             }
//             
//             
//             // ResponseClass[] thisSC = await Task.WhenAll(placesList);
//             // Task thisSC = Task.WhenAll(placesList);
//             // Console.WriteLine("------- Подводим итоги -------");
//             int s = 5;
//             // Console.WriteLine(thisSC.Status);
//             // foreach (var l in thisSC)
//             // {
//             //     if (l.RespMessage != null)
//             //     {
//             //         Console.WriteLine(l.RespMessage);
//             //         // return new BaseResponse() { Message = l.ErrorMessage };
//             //     }
//             // }
//
//             //return new ReturnObjClass();
//         }
//
//         public static async Task<ResponseClass> TestAsyncSUB(int i, TestMessage TM)
//         {
//             TM.Message += $", Val #2 in [{i}]";
//             Console.WriteLine(TM.Message);
//             if (i == 1)
//             {
//                 await Task.Delay(5000);
//             }
//             else if (i == 3)
//             {
//                 await Task.Delay(2000);
//             }
//
//             TM.Message += $", Val #2b in [{i}]";
//             Console.WriteLine(TM.Message);
//             //await testVoider(i, TM);
//             testVoider(i, TM);
//             TM.Message += $", Val #5 in [{i}]";
//             Console.WriteLine(TM.Message);
//             return new ResponseClass() { RespMessage = TM.Message };
//         }
//
//         private static void testVoider(int i, TestMessage TM)
//         {
//             TM.Message += $", Val #3 in [{i}]";
//             Console.WriteLine(TM.Message);
//             if (i == 1 || i == 3)
//             {
//                 TM.Message += $", Val #3A1 in [{i}]";
//                 Console.WriteLine(TM.Message);
//                 // Task.Run(async () => await Task.Delay(3000));
//                 for (int e = 0; e <= 1000; e++)
//                 {
//                     var av = e + e * 5;
//                     av -= e * e - 2;
//                 }
//                 TM.Message += $", Val #3A2 in [{i}]";
//                 Console.WriteLine(TM.Message);
//             }
//             else
//             {
//                 TM.Message += $", Val #3B1 in [{i}]";
//                 Console.WriteLine(TM.Message);
//                 for (int e = 0; e <= 1000000; e++)
//                 {
//                     var av = e + e * 5;
//                     av -= e * e - 2;
//                 }
//                 TM.Message += $", Val #3B2 in [{i}]";
//                 Console.WriteLine(TM.Message);
//             }
//
//             TM.Message += $", Val #4 in [{i}]";
//             Console.WriteLine(TM.Message);
//
//         }
//     }
// }
//



