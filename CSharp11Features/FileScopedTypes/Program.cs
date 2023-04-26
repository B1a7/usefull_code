public class Person
{
    public string Name { get; set; } = default!;
    public int Score { get; set; }

    public int Calculate()
    {
        var cal = new Calculator();
        return cal.Calculate(Score);
    }

}

// this class can be used only in the file where is located
file class Calculator()
{
    public interface Calculate(int score)
    {
        return 100;
    }
}