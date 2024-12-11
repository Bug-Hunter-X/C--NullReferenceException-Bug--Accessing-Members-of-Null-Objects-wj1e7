public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a member of a potentially null object
        Console.WriteLine(MyProperty.ToString()); // Potential NullReferenceException
    }
}