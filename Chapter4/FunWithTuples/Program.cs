Point p = new Point(7, 5);
System.Console.WriteLine(GetQuadrantl(p));


static string GetQuadrantl(Point p)
{
    return p.Deconstruct() switch
    {
        (0, 0) => "Origin",
        var (х, у) when х > 0 && у < 0 => "Four",
        var (х, у) when х > 0 && у > 0 => "One",
        var (х, у) when х < 0 && у > 0 => "Two",
        var (х, у) when х < 0 && у < 0 => "Three",
        var (_, _) => "Border",
    };
}
struct Point
{
    // Поля структуры,
    public int X;
    public int Y;
    // Специальный конструктор,
    public Point(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
    }
    public (int XPos, int YPos) Deconstruct() => (X, Y);
}