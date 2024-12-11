public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Check for null before accessing MyProperty
        if (this != null && MyProperty != null) //Example of avoiding NullReferenceException with null checks
        {
            Console.WriteLine(MyProperty.ToString());
        }
        else
        {
            Console.WriteLine("MyProperty is null");
        }
    }
} 
//Alternative solution using null-conditional operator (?.)
public void MyMethod()
    {
        Console.WriteLine(MyProperty?.ToString() ?? "MyProperty is null");
    } 