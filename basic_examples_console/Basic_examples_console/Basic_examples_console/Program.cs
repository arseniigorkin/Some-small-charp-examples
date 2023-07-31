using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using Basic_examples_console_Character;
using Basic_examples_console_inheritance;
using Basic_examples_console_Polymorph;
using Basic_examples_console_subPolymorph;

using Basic_examples_console_IExample;

    // double avg = Calc.Average(new int[] { 1, 2, 3, 4 });
    // Console.WriteLine(avg.ToString());
    //
    // Character ch = new Character();
    // // ch.Name = "Sofia";
    //
    // Console.WriteLine(ch.Name);
    //
    // if (Calc.TryDevide(5, 0, out double res))
    // {
    //     Console.WriteLine(res.ToString());
    // }
    // else
    // {
    //     Console.WriteLine("Деление на 0! Ай-ай-ай!");
    // }
    //
    // Inheritance inh = new Inheritance(10, 12);
    // Child1 chld1 = new Child1(x: 12, y: 55);
    //
    // chld1.SumXY();
    // inh.SumXY();

    // polymorph sPM = new sub_polymorph("Привет, медвед!", 900);
    // Console.WriteLine(sPM.GetText());
    // Console.WriteLine($"Get_number из суб_полиморфа: {sPM.getNumber()}");
    //
    // // ТУТ НЕВАЖНО, какой из наследников передан будет сюда. Главное - он имеет контракт
    // // с polymorph, а значит его структура и методы будут всегда определены одинаково
    // // с точки зрения конструкции
    // static void Something(polymorph plmr)
    // {
    //    Console.WriteLine($"Число: {plmr.getNumber()}"); 
    //    Console.WriteLine($"Текст: {plmr.GetText()}"); 
    // }
    //
    // polymorph newPlm = new sub_polymorph("Жизнь хороша!", 701);
    // Something(newPlm);


//
// InterfaceExampleClass iFEc = new InterfaceExampleClass("Мишка колосапый", 800, true);
// Console.WriteLine(iFEc.getText("Заря."));
// Console.WriteLine(iFEc.getNumber(200));


namespace Basic_examples_console
{
    class Program
    {
        static void Main()
        {
            ////// ENUM example
            /// 
            // var Tree = new Enum.EnumTrees(Enum.Trees.Oak);
            //
            // Console.WriteLine(Tree._treeLength);
            
            // ////// Generic example
            // var GenericStr = new GenericExample<string>();
            // Console.WriteLine(GenericStr.makeDefault("Hello!"));
            // var GenericInt = new GenericExample<int>();
            // int a = 100;
            // Console.WriteLine(GenericInt.makeDefault(a));
            
            ///// IEnumerator + foreach
            var IEnum = new IEnumExample<int>();
            IEnum.Push(1);
            IEnum.Push(3);
            IEnum.Push(5);
            Console.WriteLine(IEnum.Peek());
            Console.WriteLine(IEnum.Pop());
            IEnum.Push(7);
            Console.WriteLine(IEnum.Peek());
            Console.WriteLine(IEnum.Pop());
            Console.WriteLine(IEnum.Pop());
            Console.WriteLine(IEnum.Pop());
            Console.WriteLine(IEnum.Pop()); // throws exception about the about of range, which is correct.


        }
    }
    
}

