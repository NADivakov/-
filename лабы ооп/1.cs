using System;

class Programm
{
    static void Main(string[] args)
    {
        A obj = new A();
        Console.WriteLine(obj.Operation("/="));
        Console.ReadKey();
    }
}
 
class A
{
    private float a = 4.6f;
    private float b = 2.3f;
 
    public float c
    {
        get { return a + b; }
    }
 
    public float Operation(string str)
    {
        switch (str)
        {
            case "+": return a + b;
            case "/=": return a /= b;
        }
        return 0;
    }
}