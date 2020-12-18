using System;

    class Program
    {
        static void Main(string[] args)
        {
            B classB = new B(3, 4, 5);
            if (!classB)
                Console.WriteLine("Пример 1");

            B classB2 = new B();
            classB2.key = "342";
            classB2.password = "12345678";
            Console.WriteLine(classB2 ? "Секретная информация, пароль: qwerty" : "Неверный пароль");
        }
    }
    class A
    {
        private int _a = 3;
        private int _b = 10;

        public A(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public A()
        {}

        public int c
        {
            get
            {
                return _a %= (_a + _b);
            }
            set
            {
                _a = value;
            }
        }
    }
    class B : A
    {
        private int _d;
        public string key;
        public string password;

        public B(int a, int b, int d) : base(a, b)
        {
            _d = d;
        }
        public B()
        {}

        public int year 
        { 
            get 
            {
                return _d;
            } 
            set
            {
                _d = value;
            } 
        }
        public static bool operator true(B variable)
        {
            return variable.key == "32" || variable.password == "18";
        }
        public static bool operator false(B variable)
        {
            return  variable.year == 1990;
        }
        public static bool operator !(B variable)
        {
            return true;
        }
    }