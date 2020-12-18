using System;

    class Program
    {
        static void Main(string[] args)
        {
            B classB = new B(4, 4);
            C<string> classC_string = new C<string>();
            C<int> classC_int = new C<int>();
            Console.WriteLine("Первый массив:");
            foreach(var ind in classB.arrayClass1)
            {
                Console.WriteLine(ind);
            }
            Console.WriteLine("Второй массив:");
            foreach (var ind in classB.arrayClass2)
            {
                Console.WriteLine(ind);
            }
        }
    }

 class A
    {
        public int a = 7;
        private int _b = 4;

        public A(int a1, int b)
        {
            a = a1;
            _b = b;
        }

        public A()
        {}
        public int c
        {
            get
            {
                return a %= (a + _b);
            }
            set
            {
                a = value;
            }
        }
    }

class B : A
    {
        private int _d;
        public int[] arrayClass1;
        public int[] arrayClass2 = { 2, 7, 3, 5, 6, 8, 4 };
        public B(int a, int b, int d) : base(a, b)
        {
            _d = d;
        }
        public B()
        {}
        public int c2 { get; set; }
        public B(int var1, int var2)
        {
            a = var1;
            c2 = var2;
            arrayClass1 = new int[a];
            for (int i = 0; i < arrayClass1.Length; i++)
            {
                arrayClass1[i] = c2 * i;
            }
        }
        public int this[int ind1]
        {
            get
            {
                return arrayClass1[ind1];
            }
            set
            {
                arrayClass1[ind1] = value;
            }
        }
    }
class C<T>
    {
        private static T _somevariable;
        public static string _staticVariableStr;
        public T GetSomeVariable
        {
            get
            {
                return _somevariable;
            }
            private set
            {
                _somevariable = value;  
            }
        }
    }
