using System;
using System.Collections.Generic;
using System.Threading.Tasks;

//////// BLOCKING //////
// ForEacher(5);
//     ;
// void ForEacher(int slices)
// {
//     var counter = new ClassCounter();
//     for (int slice = 1; slice < slices; slice++)
//     {
//          cutABread(slice, counter);
//     }
// }
//
// static SlicerClass getSlice(int slice, string someTxt)
//  {
//      SlicerClass newSC = new SlicerClass();
//      Console.WriteLine($"Начинаю резать кусочек номер {slice.ToString()}, текст: {someTxt}");
//      Task.Delay(1000);
//      Console.WriteLine($"Порезал кусочек {slice.ToString()}, текст: {someTxt}");
//      newSC.NumberOfSlice = 10;
//      newSC.TextOfSlice = "Текстик для класса из getSlice()";
//      return newSC;
//  }
//
// static SlicerClass cutABread(int slice, ClassCounter counter)
//          {
//              // int counter = BreadCounter;
//              SlicerClass newSC = new SlicerClass();
//              string someTxt = "Привет, ";
//              Console.WriteLine($"Текст №1 внутри цикла {slice.ToString()}: {someTxt}.");
//              Task.Delay(1000);
//              someTxt += "Медвед!";
//              // Console.WriteLine($"ClassCounter.Counter = {counter.Counter.ToString()} в слайсе {slice.ToString()}");
//              if (slice == 3)
//              {
//                  newSC.NumberOfSlice = slice;
//                  newSC.TextOfSlice = "Слайс ПРОПУС --- из butBread()";
//                  Console.WriteLine("Слайс ПРОПУС --- из butBread()");
//                  return newSC;
//              }
//
//              int lcCounter = counter.IncreaseCounter();
//              // Console.WriteLine($"lcCounter3 = {lcCounter} в слайсе {slice.ToString()}");
//              
//              Console.WriteLine($"Текст №2 внутри цикла {slice.ToString()}: {someTxt}.");
//              getSlice(slice, someTxt);
//              Task.Delay(1000);
//              someTxt += " Бабасики!";
//              // Console.WriteLine($"Текст №3 внутри цикла {slice.ToString()}: {someTxt}.");
//              newSC.NumberOfSlice = slice;
//              // newSC.SliceCounter = BreadCounter;
//              newSC.SliceCounter = lcCounter;
//              // newSC.SliceCounter = counter;
//              newSC.TextOfSlice = "Текстик для класса из butBread()";
//              Console.WriteLine($"lcCounter = {lcCounter} в слайсе {slice.ToString()}");
//              return newSC;
//          }
//
// public class SlicerClass
//  {
//      public int NumberOfSlice { get; set; }
//      public string TextOfSlice { get; set; }
//      public int SliceCounter { get; set; }
//  }
//
// internal class ClassCounter
//  {
//      public static int Counter { get; set; } = 1;
//
//      public  int IncreaseCounter()
//      {
//          Task.Delay(10);
//          return Counter += 1;
//      }
//  }
//
//
//
// public class SlicesCounterClass
// {
//     private int SlicesCounter { get; set; } = 1;
// }


///////// / BLOCKING/ //////



///////// ASYNC /////////
 // internal class Slice
 // {
 // }
 //
 // internal class SlicerClass
 // {
 //     public int NumberOfSlice { get; set; }
 //     public string TextOfSlice { get; set; }
 //     public int SliceCounter { get; set; }
 // }
 // class Program
 // {
 //     static int BreadCounter { get; set; } = 1;
 //
 //     static async Task setBreadCounter(int counter)
 //     {
 //         BreadCounter = counter;
 //     }
 //     
 //     private static int SliceNo { get; set; }
 //
 //     static async Task Main(string[] args)
 //     {
 //         await ToastBreadAsync(5);
 //
 //         // return new Task();
 //     }
 //
 //     static async Task<SlicerClass> getSlice(int slice, string someTxt)
 //     {
 //         SlicerClass newSC = new SlicerClass();
 //         Console.WriteLine($"Начинаю резать кусочек номер {slice.ToString()}, текст: {someTxt}");
 //         await Task.Delay(3000);
 //         Console.WriteLine($"Порезал кусочек {slice.ToString()}, текст: {someTxt}");
 //         newSC.NumberOfSlice = 10;
 //         newSC.TextOfSlice = "Текстик для класса из getSlice()";
 //         return newSC;
 //     }
 //
 //     internal class ClassCounter
 //     {
 //         public static int Counter { get; set; } = 1;
 //
 //         public async Task<int> IncreaseCounter()
 //         {
 //             await Task.Delay(10);
 //             return Counter += 1;
 //         }
 //     }
 //     private static async Task<SlicerClass> cutABread(int slice, ClassCounter counter)
 //     {
 //         // int counter = BreadCounter;
 //         SlicerClass newSC = new SlicerClass();
 //         string someTxt = "Привет, ";
 //         Console.WriteLine($"Текст №1 внутри цикла {slice.ToString()}: {someTxt}.");
 //         await Task.Delay(1000);
 //         someTxt += "Медвед!";
 //         // Console.WriteLine($"ClassCounter.Counter = {counter.Counter.ToString()} в слайсе {slice.ToString()}");
 //         if (slice == 3)
 //         {
 //             newSC.NumberOfSlice = 100;
 //             // newSC.SliceCounter = counter;
 //             // newSC.SliceCounter = counter.Counter;
 //             newSC.TextOfSlice = "Слайс ПРОПУС --- из butBread()";
 //             Console.WriteLine("Слайс ПРОПУС --- из butBread()");
 //             return newSC;
 //         }
 //
 //         // counter += 1;
 //         // Console.WriteLine($"ClassCounter.Counter2 = {counter.Counter.ToString()} в слайсе {slice.ToString()}");
 //         // Console.WriteLine($"ClassCounter.Counter2 = {counter.Counter.ToString()} в слайсе {slice.ToString()}");
 //         // int lcCounter = counter.Counter += 1;
 //         Task<int> IntlcCounter = await Task.WhenAny(counter.IncreaseCounter());
 //         int lcCounter = IntlcCounter.Result;
 //         // Console.WriteLine($"lcCounter3 = {lcCounter} в слайсе {slice.ToString()}");
 //         
 //         Console.WriteLine($"Текст №2 внутри цикла {slice.ToString()}: {someTxt}.");
 //         getSlice(slice, someTxt);
 //         await Task.Delay(1000);
 //         someTxt += " Бабасики!";
 //         // Console.WriteLine($"Текст №3 внутри цикла {slice.ToString()}: {someTxt}.");
 //         newSC.NumberOfSlice = slice;
 //         // newSC.SliceCounter = BreadCounter;
 //         newSC.SliceCounter = lcCounter;
 //         // newSC.SliceCounter = counter;
 //         newSC.TextOfSlice = "Текстик для класса из butBread()";
 //         // Console.WriteLine($"BreadCounter4 = {BreadCounter} в слайсе {slice.ToString()}");
 //         return newSC;
 //     }
 //     
 //     private static async Task ToastBreadAsync(int slices)
 //     {
 //         // класс, который возвращается из метода
 //         var slicesList = new List<Task<SlicerClass>>();
 //         var counter = new ClassCounter();
 //
 //         for (int slice = 1; slice < slices; slice++)
 //         {
 //
 //             slicesList.Add(cutABread(slice, counter));
 //
 //         }
 //         
 //         SlicerClass[] thisSC = await Task.WhenAll(slicesList);
 //         // await Task.WhenAll(slicesList.Select(async sl => BreadCounter = sl.Result.SliceCounter));
 //         // await Task.WhenAll(slicesList.Select(async sl => await setBreadCounter(sl.Result.SliceCounter)));
 //         // SlicerClass[] thisSC = await Task.WhenAll(slicesList.Select());
 //         
 //         await Task.Delay(5000);
 //         foreach (var a in thisSC)
 //         {
 //             Console.WriteLine($"POST: Кусочек хлеба № {a.NumberOfSlice}, Counter = {a.SliceCounter}. Text: {a.TextOfSlice}.");
 //             if (a.NumberOfSlice == 100)
 //             {
 //                 Console.WriteLine($"POST: Вернул 100-ку");
 //             }
 //         }
 //     }
 // }


// using AsyncTestNameSpace;
// static void Main(string[] args)
// {
//     
// }
// var P = new ProgramAsyncClass();
// P.TestAsync();


using Test_foreach_async;
// using AsyncBreakfast;






