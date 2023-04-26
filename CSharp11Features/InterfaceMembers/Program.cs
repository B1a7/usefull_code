public interface IShape
{
    double CalculateArea();
    static abstract string? Color { get; set; }

    static virtual string? Name {get; set; }
    static virtual bool operator >(IShape left, IShape right)
        => left.CalculateArea() > right.CalculateArea();

    static virtual bool operator <(IShape left, IShape right)
        => left.CalculateArea() < right.CalculateArea();
}