using System;

    class Program
    {
        static void Main(string[] args)
        {
            B classB = new B(4, 4);
            foreach(int i in classB.arrayClass)
            {
                Console.WriteLine("Ответ:  "+i);
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
        public int[] arrayClass;
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
            arrayClass = new int[a];
            for (int i = 0; i < arrayClass.Length; i++)
            {
                arrayClass[i] = c2 * i;
            }
        }
    }