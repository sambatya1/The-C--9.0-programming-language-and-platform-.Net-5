static void ValueTypeContainingRefType()
{
    // See https://aka.ms/new-console-template for more information
    Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
    // Присвоить новой переменной Rectangle переменную r1.
    Rectangle r2 = r1;
    Console.WriteLine("Иначально r1 и r2 выглядят так:");
    r1.Display();
    r2.Display();
    // Изменить некоторые значения в r2.
    Console.WriteLine("-> Changing values of r2");
    r2.Rectlnfo.InfoString = "This is new info!";
    r2.RectBottom = 4444;

    // Вывести значения из обеих переменных Rectangle ,
    r1.Display();
    r2.Display();
}

ValueTypeContainingRefType();


class Shapelnfo
{
    public string InfoString;

    public Shapelnfo(string info)
    {
        InfoString = info;
    }
}

struct Rectangle
{
    // Структура Rectangle содержит член ссылочного типа ,
    public Shapelnfo Rectlnfo;
    public int RectTop, RectLeft, RectBottom, RectRight;
    public Rectangle(string info, int top, int left, int bottom, int right)
    {
        Rectlnfo = new Shapelnfo(info);
        RectTop = top; RectBottom = bottom;
        RectLeft = left; RectRight = right;
    }
    public void Display()
    {
        Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
        "Left = {3}, Right = {4}",
        Rectlnfo.InfoString, RectTop, RectBottom, RectLeft, RectRight);
    }
}

