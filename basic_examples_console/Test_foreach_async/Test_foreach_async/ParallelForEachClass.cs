using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Test_foreach_async;

public class ParallelForEachClass
{
    internal class ErrorReturnClass
    {
        public string ErrorMessage { get; set; }
    }
    internal class TestItemClass
    {
        public string ItemName { get; set; }
        public int ItemID { get; set; }
    }
    public static void Main()
    {
        var numbers = Enumerable.Range(0, 10).ToList();
        ParallelForEacher(numbers);
    }

    static async Task ParallelForEacher(List<int> numbers)
    {
        var ReturnErrorMesssage = string.Empty;
        int Index = 0;
        List<TestItemClass> Items = new List<TestItemClass>();
        for (int t = 0; t <= 9; t++)
        {
            Items.Add(new TestItemClass(){ItemName = $"Предмет #{t.ToString()}"});
        }

        int ForEachIndex = 0;
        Parallel.ForEach(Items, (item, state) =>
        {
            ForEachIndex++;
            
            Console.WriteLine($"Запуск № {ForEachIndex.ToString()}:1 и индекс: {Index.ToString()}");
            Index++;
            item.ItemID = Index;
            
            Console.WriteLine($"Запуск № {ForEachIndex.ToString()}:2 и индекс: {Index.ToString()}");
            
            ErrorReturnClass RespTemp = InLoopMainMethod(ForEachIndex);
            if (RespTemp.ErrorMessage != null)
            {
                ReturnErrorMesssage = RespTemp.ErrorMessage;
                state.Break();
            }


        });
        int y = 0;
        foreach (TestItemClass item in Items)
        {
            Console.WriteLine($"Item[{y}] Name: {Items[y].ItemName}, ID: {Items[y].ItemID}");
            y++;
        }
        if (!string.IsNullOrEmpty(ReturnErrorMesssage))
        {
            Console.WriteLine($"Срыв в ошибку: {ReturnErrorMesssage}");
            //return false;
        }
        
        Console.WriteLine($"Максимальный Индекс = {Index.ToString()}");
        //return true;
    }

    static async Task TestAsync()
    {
        
        Console.WriteLine("Печать до ожидания (внутри TestAsync)");
        await Task.Delay(2000);
        Console.WriteLine("Печать после ожидания (внутри TestAsync)");
    }
    private static bool InLoopFirstTestMethod(int number)
    {
        if (number == 3)
        {
            return false;
        }
        return true;
    }
    
    private static ErrorReturnClass InLoopMainMethod(int number)
    {
        if (number == 4)
        {
            return new ErrorReturnClass() {ErrorMessage = $"Ошибка в номере {number.ToString()}"};
            // return $", Обрабтка + {number.ToString()}"; 
        }
        // return $", Обрабтка + {number.ToString()}";
        return new ErrorReturnClass();
    }
}