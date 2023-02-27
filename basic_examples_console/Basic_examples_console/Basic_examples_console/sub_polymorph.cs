using Basic_examples_console_Polymorph;

namespace Basic_examples_console_subPolymorph;

public class sub_polymorph : polymorph
{
    private readonly string text;
    private readonly int number;

    public sub_polymorph(string text, int number)
    {
        this.text = text;
        this.number = number;
        Console.WriteLine("Суб_Полиморф создан.");
    }


    public override string GetText()
    {
        return $"Из Суб_Полиморфа: GetText: {text}!";
    }

    public override int getNumber()
    {
        return this.number;
    }
}