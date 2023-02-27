namespace Basic_examples_console_inheritance;

public class Inheritance
{
    protected int x;
    protected int y;

    public Inheritance(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public virtual void SumXY()
    {
      Console.WriteLine($"Сумма X и Y равна: {x + y}");  
    }
    
    
}

public class Child1 : Inheritance
{
    public Child1(int x, int y) : base(x, y)
    {
        
    }
    
    public override void SumXY()
    {
        base.SumXY();
        Console.WriteLine($"Произведение X на Y равно: {x * y}");  
    }
}