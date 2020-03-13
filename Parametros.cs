using System;

namespace Parametro
{
    class Prueba
    {
        public static void sumauno(ref int x)
    {
         x = x + 2;
         Console.WriteLine(x);
    }
    public static void suma(in int a, in int b, out int c)
    {
        c= a + b;
    }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 12; int b = 10; int c;
            Prueba.sumauno(ref a);
            Console.WriteLine(a);
            Prueba.suma( in a, in b, out c);
            Console.WriteLine(c);
        }
    }
}