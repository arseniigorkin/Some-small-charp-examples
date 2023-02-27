// See https://aka.ms/new-console-template for more information


using Basic_examples_console_Character;
using Basic_examples_console_inheritance;

    double avg = Calc.Average(new int[] { 1, 2, 3, 4 });
    Console.WriteLine(avg.ToString());
    
    Character ch = new Character();
    // ch.Name = "Sofia";
    
    Console.WriteLine(ch.Name);

    if (Calc.TryDevide(5, 0, out double res))
    {
        Console.WriteLine(res.ToString());
    }
    else
    {
        Console.WriteLine("Деление на 0! Ай-ай-ай!");
    }
    
    Inheritance inh = new Inheritance(10, 12);
    Child1 chld1 = new Child1(x: 12, y: 55);
    
    chld1.SumXY();
    inh.SumXY();
    