public class MyClass
{
    public int MyProperty { get; set; } = 0; //Explicit Initialization

    public void MyMethod()
    {
        // Initialize the property explicitly to avoid default values
        MyProperty = 5;
        Console.WriteLine(MyProperty); // Output: 5

        int result = MyProperty * 10; // result will be 50
        int? nullableProperty = MyProperty;
        int anotherResult = (nullableProperty ?? 5) * 10; //anotherResult will be 50

    }
} 