namespace Basic_examples_console_IExample;

public class InterfaceExampleClass : IExample_sub1
{
    private string Text { get;}
    private int Number { get;}
    private bool isTrueField { get;}

    public InterfaceExampleClass(string text, int number, bool isTrue)
    {
        this.Text   = text;
        this.Number = number;
    }

    public string getText(string text)
    {
        return $"Получили текст {text}, а базовый - {Text}.";
    }

    public int getNumber(int number)
    {
        return number + Number;
    }

    public bool isTrue(bool isTrue)
    {
        return this.isTrueField;
    }
}