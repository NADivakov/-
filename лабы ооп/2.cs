using System;

class Programm
{
    static void Main(string[] args)
    {
        A classA = new A(2,3);
        B classB = new B(1);
        Console.WriteLine("c2 = " + classB.c2);
    }
}

class A
{
    public float a = 5.4f;
    public float b = 3;

    public A(float a, float b){
        this.a=a;
        this.b=b;
        Console.WriteLine("A: a-b = "+(a-b));
        
    }
    public A (){}
 
    public float с
    {
        get { return a - b; }
        set {a = value;}
    }
  
}

class B: A
{
    public float d = 8;


    public B(float a, float b, float d):base(a,b){
        this.d=d;
        Console.WriteLine("B: a+b+d = "+(a+b+d));
    }
    public B(float d){
        this.d=d;
        Console.WriteLine("B: d = " + d);
    }

    public float c2{
        get{for(float i=0;i<3;i++)
            d=d+a+b+i;
            return d;
        }
        set{ c2 = value; }
    }
    
    
}